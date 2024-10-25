namespace QLMH.DangDuyHoang
{
    partial class frm_GV
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtMaQTV = new System.Windows.Forms.TextBox();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaQTC = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtBangCap = new System.Windows.Forms.TextBox();
            this.txtTrangThaiGV = new System.Windows.Forms.TextBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblMaQTV = new System.Windows.Forms.Label();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            this.lblPhai = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblMaQTC = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblBangCap = new System.Windows.Forms.Label();
            this.lblTrangThaiGV = new System.Windows.Forms.Label();
            this.btnQLMH = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(60, 30);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(100, 20);
            this.txtMaGV.TabIndex = 0;
            // 
            // txtMaQTV
            // 
            this.txtMaQTV.Location = new System.Drawing.Point(62, 70);
            this.txtMaQTV.Name = "txtMaQTV";
            this.txtMaQTV.Size = new System.Drawing.Size(100, 20);
            this.txtMaQTV.TabIndex = 1;
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Location = new System.Drawing.Point(75, 108);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(100, 20);
            this.txtHoTenGV.TabIndex = 2;
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(48, 147);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(50, 20);
            this.txtPhai.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(71, 188);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(56, 226);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtMaQTC
            // 
            this.txtMaQTC.Location = new System.Drawing.Point(66, 266);
            this.txtMaQTC.Name = "txtMaQTC";
            this.txtMaQTC.Size = new System.Drawing.Size(70, 20);
            this.txtMaQTC.TabIndex = 6;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(67, 308);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(70, 20);
            this.txtMaKhoa.TabIndex = 7;
            // 
            // txtBangCap
            // 
            this.txtBangCap.Location = new System.Drawing.Point(70, 347);
            this.txtBangCap.Name = "txtBangCap";
            this.txtBangCap.Size = new System.Drawing.Size(100, 20);
            this.txtBangCap.TabIndex = 8;
            // 
            // txtTrangThaiGV
            // 
            this.txtTrangThaiGV.Location = new System.Drawing.Point(90, 387);
            this.txtTrangThaiGV.Name = "txtTrangThaiGV";
            this.txtTrangThaiGV.ReadOnly = true;
            this.txtTrangThaiGV.Size = new System.Drawing.Size(100, 20);
            this.txtTrangThaiGV.TabIndex = 9;
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Location = new System.Drawing.Point(196, 43);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.Size = new System.Drawing.Size(592, 367);
            this.dgvGiaoVien.TabIndex = 10;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(130, 420);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(220, 420);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(310, 420);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(400, 420);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(12, 30);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(43, 13);
            this.lblMaGV.TabIndex = 15;
            this.lblMaGV.Text = "Mã GV:";
            // 
            // lblMaQTV
            // 
            this.lblMaQTV.AutoSize = true;
            this.lblMaQTV.Location = new System.Drawing.Point(12, 70);
            this.lblMaQTV.Name = "lblMaQTV";
            this.lblMaQTV.Size = new System.Drawing.Size(50, 13);
            this.lblMaQTV.TabIndex = 16;
            this.lblMaQTV.Text = "Mã QTV:";
            // 
            // lblHoTenGV
            // 
            this.lblHoTenGV.AutoSize = true;
            this.lblHoTenGV.Location = new System.Drawing.Point(12, 110);
            this.lblHoTenGV.Name = "lblHoTenGV";
            this.lblHoTenGV.Size = new System.Drawing.Size(60, 13);
            this.lblHoTenGV.TabIndex = 17;
            this.lblHoTenGV.Text = "Họ tên GV:";
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(12, 150);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(31, 13);
            this.lblPhai.TabIndex = 18;
            this.lblPhai.Text = "Phái:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(12, 190);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(57, 13);
            this.lblNgaySinh.TabIndex = 19;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(12, 230);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 20;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblMaQTC
            // 
            this.lblMaQTC.AutoSize = true;
            this.lblMaQTC.Location = new System.Drawing.Point(12, 270);
            this.lblMaQTC.Name = "lblMaQTC";
            this.lblMaQTC.Size = new System.Drawing.Size(50, 13);
            this.lblMaQTC.TabIndex = 21;
            this.lblMaQTC.Text = "Mã QTC:";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(12, 310);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(52, 13);
            this.lblMaKhoa.TabIndex = 22;
            this.lblMaKhoa.Text = "Mã khoa:";
            // 
            // lblBangCap
            // 
            this.lblBangCap.AutoSize = true;
            this.lblBangCap.Location = new System.Drawing.Point(12, 350);
            this.lblBangCap.Name = "lblBangCap";
            this.lblBangCap.Size = new System.Drawing.Size(56, 13);
            this.lblBangCap.TabIndex = 23;
            this.lblBangCap.Text = "Bằng cấp:";
            // 
            // lblTrangThaiGV
            // 
            this.lblTrangThaiGV.AutoSize = true;
            this.lblTrangThaiGV.Location = new System.Drawing.Point(12, 390);
            this.lblTrangThaiGV.Name = "lblTrangThaiGV";
            this.lblTrangThaiGV.Size = new System.Drawing.Size(76, 13);
            this.lblTrangThaiGV.TabIndex = 24;
            this.lblTrangThaiGV.Text = "Trạng thái GV:";
            // 
            // btnQLMH
            // 
            this.btnQLMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMH.Location = new System.Drawing.Point(532, 419);
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.Size = new System.Drawing.Size(124, 23);
            this.btnQLMH.TabIndex = 25;
            this.btnQLMH.Text = "Quản lý môn học";
            this.btnQLMH.UseVisualStyleBackColor = true;
            this.btnQLMH.Click += new System.EventHandler(this.btnQLMH_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBack.Location = new System.Drawing.Point(772, -3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frm_GV
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnQLMH);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.txtTrangThaiGV);
            this.Controls.Add(this.txtBangCap);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.txtMaQTC);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtPhai);
            this.Controls.Add(this.txtHoTenGV);
            this.Controls.Add(this.txtMaQTV);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.lblMaQTV);
            this.Controls.Add(this.lblHoTenGV);
            this.Controls.Add(this.lblPhai);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblMaQTC);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.lblBangCap);
            this.Controls.Add(this.lblTrangThaiGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Giáo viên";
            this.Load += new System.EventHandler(this.frm_GV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtMaQTV;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaQTC;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtBangCap;
        private System.Windows.Forms.TextBox txtTrangThaiGV;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        // Các Label mới được thêm
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblMaQTV;
        private System.Windows.Forms.Label lblHoTenGV;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMaQTC;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblBangCap;
        private System.Windows.Forms.Label lblTrangThaiGV;
        private System.Windows.Forms.Button btnQLMH;
        private System.Windows.Forms.Button btnBack;
    }
}
