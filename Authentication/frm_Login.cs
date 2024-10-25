using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using QLMH.DangDuyHoang.Admin;
using QLMH.DangDuyHoang.SinhVien;
using QLMH.DangDuyHoang.Model;
using System.Security.Cryptography;

namespace QLMH.DangDuyHoang
{
    public partial class frm_Login : Form
    {
        DBContext dbContext = new DBContext();  
        public frm_Login()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            usererror.Visible = false;
            passerror.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
            Application.Exit();
        }
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Chuyển đổi thành chuỗi hex
                }
                return builder.ToString();
            }
        }
        private bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            // So sánh mật khẩu đã nhập với mật khẩu đã hash
            return HashPassword(enteredPassword) == hashedPassword;
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" && txtPassword.Text == "")
            {
                usererror.Visible = true;
                passerror.Visible = true;
                errormsg.Text = "Please fill the form !";
            }
            // Tìm tài khoản người dùng trong CSDL
            var user = dbContext.Tai_Khoan_Nguoi_Dung
                .Include("Sinh_Vien") // Bao gồm thông tin sinh viên
                .SingleOrDefault(u => u.TenDangNhap == txtUsername.Text);

            if (user != null && VerifyPassword(txtPassword.Text, user.MatKhau))
            {
                var sinhVien = user.Sinh_Vien;
                // Nếu thông tin đăng nhập hợp lệ
                frm_SinhVien frm_SV = new frm_SinhVien(sinhVien);
                frm_SV.Show();
                this.Hide();
            }
            else
            {
                // Thông báo lỗi đăng nhập
                errormsg.Text = "Invalid username or password!";
            }

            if ((txtUsername.Text == "admin123" && txtPassword.Text == "Passw0rd@"))
            {
                frm_TaiKhoanNguoiDung frm_TKND = new frm_TaiKhoanNguoiDung();
                frm_TKND.Show();
                this.Hide();
            }
            else
            {
                //Xử lý login
                // Nếu thông tin đăng nhập không khớp
                usererror.Visible = true;
                passerror.Visible = true;
                errormsg.Text = "Invalid username or password!";
            }
            
            
        }
        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
            usererror.Visible= false;
            if(txtPassword.Text == "")
            {
                passerror.Visible = true;
                errormsg.Text = "Please fill the form !";

            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
            txtUsername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            passerror.Visible= false;
            if(txtUsername.Text == "")
            {
                usererror.Visible = true;
                errormsg.Text = "Please fill the form !";
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else {
                txtPassword.UseSystemPasswordChar = true;
            }
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                usererror.Visible = true;
                errormsg.Text = "Please fill the form !";
            }
            else
            {
                usererror.Visible = false;
                errormsg.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") 
            { 
                passerror.Visible = true;
                errormsg.Text = "Please fill the form !";
            }
            else
            {
                passerror.Visible = false;
                errormsg.Text = "";
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            // Tạo mới form đăng ký
            frm_Signup frm_Signup = new frm_Signup();

            // Đóng form đăng nhập hiện tại
            this.Hide();

            // Mở form đăng ký
            frm_Signup.Show();

        }
    }
}
