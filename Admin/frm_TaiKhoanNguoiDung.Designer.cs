namespace QLMH.DangDuyHoang.Admin
{
    partial class frm_TaiKhoanNguoiDung
    {
        private System.Windows.Forms.DataGridView dgvTaiKhoanNguoiDung;
        private System.Windows.Forms.TextBox txtMaTKND;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaQTC;
        private System.Windows.Forms.Label lblMaTKND;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaQTC;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTaiKhoanNguoiDung = new System.Windows.Forms.DataGridView();
            this.txtMaTKND = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaQTC = new System.Windows.Forms.TextBox();
            this.lblMaTKND = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblMaQTC = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnQLGV = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoanNguoiDung
            // 
            this.dgvTaiKhoanNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanNguoiDung.Location = new System.Drawing.Point(30, 291);
            this.dgvTaiKhoanNguoiDung.Name = "dgvTaiKhoanNguoiDung";
            this.dgvTaiKhoanNguoiDung.ReadOnly = true;
            this.dgvTaiKhoanNguoiDung.Size = new System.Drawing.Size(454, 115);
            this.dgvTaiKhoanNguoiDung.TabIndex = 0;
            this.dgvTaiKhoanNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoanNguoiDung_CellClick);
            // 
            // txtMaTKND
            // 
            this.txtMaTKND.Location = new System.Drawing.Point(150, 82);
            this.txtMaTKND.Name = "txtMaTKND";
            this.txtMaTKND.Size = new System.Drawing.Size(200, 20);
            this.txtMaTKND.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(150, 112);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(200, 20);
            this.txtTenDangNhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(150, 142);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(200, 20);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(150, 172);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(200, 20);
            this.txtMaSV.TabIndex = 4;
            // 
            // txtMaQTC
            // 
            this.txtMaQTC.Location = new System.Drawing.Point(150, 202);
            this.txtMaQTC.Name = "txtMaQTC";
            this.txtMaQTC.Size = new System.Drawing.Size(200, 20);
            this.txtMaQTC.TabIndex = 5;
            // 
            // lblMaTKND
            // 
            this.lblMaTKND.AutoSize = true;
            this.lblMaTKND.Location = new System.Drawing.Point(30, 82);
            this.lblMaTKND.Name = "lblMaTKND";
            this.lblMaTKND.Size = new System.Drawing.Size(72, 13);
            this.lblMaTKND.TabIndex = 6;
            this.lblMaTKND.Text = "Mã tài khoản:";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(30, 112);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(84, 13);
            this.lblTenDangNhap.TabIndex = 7;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(30, 142);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(55, 13);
            this.lblMatKhau.TabIndex = 8;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(30, 172);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(70, 13);
            this.lblMaSV.TabIndex = 9;
            this.lblMaSV.Text = "Mã sinh viên:";
            // 
            // lblMaQTC
            // 
            this.lblMaQTC.AutoSize = true;
            this.lblMaQTC.Location = new System.Drawing.Point(30, 202);
            this.lblMaQTC.Name = "lblMaQTC";
            this.lblMaQTC.Size = new System.Drawing.Size(98, 13);
            this.lblMaQTC.TabIndex = 10;
            this.lblMaQTC.Text = "Mã quyền truy cập:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(400, 124);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(400, 179);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnQLGV
            // 
            this.btnQLGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLGV.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQLGV.Location = new System.Drawing.Point(381, 243);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(126, 30);
            this.btnQLGV.TabIndex = 14;
            this.btnQLGV.Text = "Quản Lý Giáo Viên";
            this.btnQLGV.UseVisualStyleBackColor = false;
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(184, 242);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 30);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tài Khoản Người Dùng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_TaiKhoanNguoiDung
            // 
            this.ClientSize = new System.Drawing.Size(519, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnQLGV);
            this.Controls.Add(this.dgvTaiKhoanNguoiDung);
            this.Controls.Add(this.txtMaTKND);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtMaQTC);
            this.Controls.Add(this.lblMaTKND);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblMaQTC);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TaiKhoanNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản người dùng";
            this.Load += new System.EventHandler(this.frm_TaiKhoanNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnQLGV;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}
