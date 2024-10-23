using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMH.DangDuyHoang
{
    public partial class frm_Signup : Form
    {
        public frm_Signup()
        {
            InitializeComponent();
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
    }
}
