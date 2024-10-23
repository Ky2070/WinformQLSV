namespace QLMH.DangDuyHoang
{
    using System.ComponentModel;
    using System.Windows.Forms;

    partial class frm_Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.signupbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.passerror = new System.Windows.Forms.Label();
            this.confirmpasserror = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 530);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.loginbtn);
            this.panel2.Controls.Add(this.signupbtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 530);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(400, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 530);
            this.panel6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "TrinhMinhHuy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Develop By";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "System";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QLMH.DangDuyHoang.Properties.Resources.scholarship1;
            this.pictureBox6.Location = new System.Drawing.Point(97, 89);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 150);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox8);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txtConfirmPass);
            this.panel5.Location = new System.Drawing.Point(40, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 40);
            this.panel5.TabIndex = 10;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::QLMH.DangDuyHoang.Properties.Resources.visibility;
            this.pictureBox8.Location = new System.Drawing.Point(320, 10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox8_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLMH.DangDuyHoang.Properties.Resources.security;
            this.pictureBox1.Location = new System.Drawing.Point(5, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(40, 10);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(310, 20);
            this.txtConfirmPass.TabIndex = 3;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(45, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Already have an account?";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(220, 422);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(150, 30);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Back to Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.ForeColor = System.Drawing.Color.White;
            this.signupbtn.Location = new System.Drawing.Point(148, 309);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(150, 30);
            this.signupbtn.TabIndex = 6;
            this.signupbtn.Text = "Sign Up";
            this.signupbtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Location = new System.Drawing.Point(40, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 40);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::QLMH.DangDuyHoang.Properties.Resources.visibility;
            this.pictureBox7.Location = new System.Drawing.Point(320, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QLMH.DangDuyHoang.Properties.Resources.padlock;
            this.pictureBox4.Location = new System.Drawing.Point(5, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(40, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(310, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(40, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 40);
            this.panel3.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(40, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(310, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLMH.DangDuyHoang.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(5, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(41, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "SIGN UP";
            // 
            // closebtn
            // 
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.closebtn.ForeColor = System.Drawing.Color.Black;
            this.closebtn.Location = new System.Drawing.Point(400, 10);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(35, 35);
            this.closebtn.TabIndex = 7;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            // 
            // passerror
            // 
            this.passerror.AutoSize = true;
            this.passerror.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passerror.ForeColor = System.Drawing.Color.Red;
            this.passerror.Location = new System.Drawing.Point(40, 245);
            this.passerror.Name = "passerror";
            this.passerror.Size = new System.Drawing.Size(0, 16);
            this.passerror.TabIndex = 11;
            // 
            // confirmpasserror
            // 
            this.confirmpasserror.AutoSize = true;
            this.confirmpasserror.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasserror.ForeColor = System.Drawing.Color.Red;
            this.confirmpasserror.Location = new System.Drawing.Point(40, 290);
            this.confirmpasserror.Name = "confirmpasserror";
            this.confirmpasserror.Size = new System.Drawing.Size(0, 16);
            this.confirmpasserror.TabIndex = 12;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(40, 265);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(310, 20);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLMH.DangDuyHoang.Properties.Resources.user__1_;
            this.pictureBox3.Location = new System.Drawing.Point(5, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::QLMH.DangDuyHoang.Properties.Resources.user__1_;
            this.pictureBox5.Location = new System.Drawing.Point(5, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(77, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(80, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Confirm Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(80, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label11.Location = new System.Drawing.Point(45, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "trinhminhhuy@gmail.com";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(59, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Contact:";
            // 
            // frm_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.closebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Signup";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label passerror;
        private System.Windows.Forms.Label confirmpasserror;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Panel panel5;
        private PictureBox pictureBox1;
        private TextBox txtConfirmPass;
        private Panel panel6;
        private PictureBox pictureBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label12;
        private Label label11;
    }
}
