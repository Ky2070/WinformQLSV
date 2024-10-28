using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using QLMH.DangDuyHoang.Model;

namespace QLMH.DangDuyHoang
{
    public partial class frm_Signup : Form
    {
        DBContext dbContext = new DBContext();
        public frm_Signup()
        {
            InitializeComponent();
            InitializeAccountCount(); // Gọi phương thức khởi tạo
        }

        private void InitializeAccountCount()
        {
            accountCount = dbContext.Tai_Khoan_Nguoi_Dung.Count(); // Lấy số lượng tài khoản hiện tại
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Tạo mới form đăng nhập
            frm_Login frm_Login = new frm_Login();

            // Đóng form đăng ký hiện tại
            this.Hide();

            // Mở form đăng nhập
            frm_Login.Show();
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        // Hàm xóa nội dung trong các ô nhập liệu
        private void ClearTextBoxes()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPass.Text = string.Empty;
            txtMaSV.Text = string.Empty;
        }

        // Biến static để theo dõi số lượng tài khoản đã tạo
        private static int accountCount = 0;

        private string GenerateNewMaQTC()
        {
            // Tăng số lượng tài khoản đã tạo lên 1
            accountCount++;

            // Tạo mã quyền truy cập mới
            string newMaQTC = "QTC" + accountCount.ToString("D3"); // Định dạng mã thành "QTC00X"

            return newMaQTC;
        }
        // Hàm tạo mã tài khoản người dùng mới
        private string GenerateNewMaTKND()
        {
            var lastAccount = dbContext.Tai_Khoan_Nguoi_Dung
                .OrderByDescending(t => t.MaTKND)
                .FirstOrDefault();

            string newMaTKND;

            if (lastAccount != null)
            {
                // Lấy mã tài khoản cuối cùng
                string lastMaTKND = lastAccount.MaTKND;

                // Lấy phần số của mã tài khoản và tăng giá trị lên 1
                int lastNumber = int.Parse(lastMaTKND.Substring(5)); // Lấy số từ "TKNDXXX"
                newMaTKND = "TKND" + (lastNumber + 1).ToString("D3"); // Định dạng lại thành "TKND00X"
            }
            else
            {
                // Nếu chưa có tài khoản nào, bắt đầu từ TKND001
                newMaTKND = "TKND001";
            }

            return newMaTKND;
        }
        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtConfirmPass.UseSystemPasswordChar == true)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các ô nhập có bị bỏ trống không
                if (string.IsNullOrEmpty(txtUsername.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text) ||
                    string.IsNullOrEmpty(txtConfirmPass.Text) ||
                    string.IsNullOrEmpty(txtMaSV.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                // Kiểm tra độ dài mật khẩu
                if (txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự.");
                    return;
                }

                // Kiểm tra xác nhận mật khẩu
                if (txtPassword.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                    return;
                }

                // Kiểm tra xem mã sinh viên đã có tài khoản chưa
                var existingAccount = dbContext.Tai_Khoan_Nguoi_Dung
                    .SingleOrDefault(tk => tk.MaSV == txtMaSV.Text);
                if (existingAccount != null)
                {
                    MessageBox.Show("Mã sinh viên đã có tài khoản, vui lòng sử dụng mã khác.");
                    return;
                }
                // Kiểm tra nếu mã sinh viên có tồn tại trong bảng Sinh_Vien
                var sinhVien = dbContext.Sinh_Vien.SingleOrDefault(sv => sv.MaSV == txtMaSV.Text);
                if (sinhVien == null)
                {
                    MessageBox.Show("Mã sinh viên không hợp lệ.");
                    return;
                }

                // Tạo mã tài khoản người dùng mới theo quy tắc
                string newMaTKND = GenerateNewMaTKND();

                // Tạo mã quyền truy cập mới
                string newMaQTC = GenerateNewMaQTC();
                // Tạo tài khoản người dùng mới
                var taiKhoanNguoiDung = new Tai_Khoan_Nguoi_Dung
                {
                    MaTKND = newMaTKND,
                    TenDangNhap = txtUsername.Text,
                    MatKhau = HashPassword(txtPassword.Text),  // Mã hóa mật khẩu trước khi lưu vào CSDL
                    MaSV = txtMaSV.Text,
                    MaQTC = newMaQTC  // Hoặc bất kỳ quyền truy cập nào phù hợp
                };

                // Thêm tài khoản vào CSDL
                dbContext.Tai_Khoan_Nguoi_Dung.Add(taiKhoanNguoiDung);
                dbContext.SaveChanges();

                // Cập nhật lại accountCount
                accountCount++; // Tăng giá trị khi có tài khoản mới

                MessageBox.Show("Đăng ký thành công!");
                // Xóa các ô nhập sau khi đăng ký thành công
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Có lỗi xảy ra khi đăng ký: " + ex.Message);
            }
        }
    }
}
