using QLMH.DangDuyHoang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMH.DangDuyHoang.Admin
{
    public partial class frm_TaiKhoanNguoiDung : Form
    {
        private DBContext dbContext = new DBContext();
        public frm_TaiKhoanNguoiDung()
        {
            InitializeComponent();
        }

        private void frm_TaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var dataUser = dbContext.Tai_Khoan_Nguoi_Dung
                                        .Select(tk => new
                                        {
                                            MaTKND = tk.MaTKND,
                                            TenDangNhap = tk.TenDangNhap,
                                            MatKhau = tk.MatKhau,
                                            MaSV = tk.MaSV,
                                            MaQTC = tk.MaQTC
                                        }).ToList();

                // Gán dữ liệu cho DataGridView
                dgvTaiKhoanNguoiDung.DataSource = dataUser;

                // Tùy chỉnh hiển thị DataGridView (nếu cần)
                dgvTaiKhoanNguoiDung.Columns["MatKhau"].Visible = false; // Ẩn cột mật khẩu vì lý do bảo mật
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu:" + ex.Message);
            }
        }

        private void dgvTaiKhoanNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải là dòng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgvTaiKhoanNguoiDung.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox tương ứng
                txtMaTKND.Text = row.Cells["MaTKND"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                txtMaQTC.Text = row.Cells["MaQTC"].Value.ToString();

                // Đổ dữ liệu vào TextBox mật khẩu nhưng hiển thị dưới dạng ký tự mật khẩu
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtMatKhau.PasswordChar = '*'; // Hiển thị mật khẩu dạng ẩn
            }
        }
        private void ClearTextBoxes()
        {
            txtMaTKND.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtMaSV.Clear();
            txtMaQTC.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (dgvTaiKhoanNguoiDung.CurrentRow != null && dgvTaiKhoanNguoiDung.CurrentRow.Index >= 0)
                {
                    // Lấy MaTKND từ dòng đang được chọn trong DataGridView
                    string maTKND = dgvTaiKhoanNguoiDung.CurrentRow.Cells["MaTKND"].Value.ToString();

                    // Xác nhận xóa tài khoản
                    DialogResult confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?",
                                                                 "Xác nhận xóa",
                                                                 MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Tìm tài khoản trong cơ sở dữ liệu
                        var taiKhoan = dbContext.Tai_Khoan_Nguoi_Dung.SingleOrDefault(tk => tk.MaTKND == maTKND);

                        if (taiKhoan != null)
                        {
                            // Xóa tài khoản
                            dbContext.Tai_Khoan_Nguoi_Dung.Remove(taiKhoan);
                            dbContext.SaveChanges();

                            MessageBox.Show("Xóa tài khoản thành công.");

                            // Làm mới lại dữ liệu trong DataGridView
                            LoadData();

                            // Xóa dữ liệu trong các TextBox
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản người dùng.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần xóa từ bảng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xóa tài khoản: " + ex.Message);
            }
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            frm_GV frm_GV = new frm_GV();
            this.Hide();
            frm_GV.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frm_Login frm_DN = new frm_Login();
            this.Hide();
            frm_DN.Show();
        }

        private void btnQLKhoa_Click(object sender, EventArgs e)
        {
            frm_Khoa frmKhoa = new frm_Khoa();
            this.Hide();
            frmKhoa.Show();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            frm_qlSV frmQLSV = new frm_qlSV();
            this.Hide();
            frmQLSV.Show();
        }

        private void btnQlyLop_Click(object sender, EventArgs e)
        {
            frm_Lop frmLop = new frm_Lop();
            this.Hide();
            frmLop.Show();
        }
    }
}
