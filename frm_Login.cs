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

namespace QLMH.DangDuyHoang
{
    public partial class frm_Login : Form
    {
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

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" && txtPassword.Text == "")
            {
                usererror.Visible = true;
                passerror.Visible = true;
                errormsg.Text = "Please fill the form !";
            }
            else
            {
                //Login code here...
                Form1 frm1 = new Form1();
                frm1.Show();
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
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") 
            { 
                passerror.Visible = true;
                errormsg.Text = "Please fill the form !";
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
