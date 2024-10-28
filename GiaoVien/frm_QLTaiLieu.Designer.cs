namespace QLMH.DangDuyHoang.GiaoVien
{
    partial class frm_QLTaiLieu
    {
        private System.ComponentModel.IContainer components = null;

        // Các điều khiển cần thiết
        private System.Windows.Forms.DataGridView dgvTaiLieu;
        private System.Windows.Forms.ComboBox cmbMaTL;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.TextBox txtMaTLCT; // Thêm TextBox cho Mã Tài Liệu Chi Tiết
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMaTL;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaTLCT; // Thêm Label cho Mã Tài Liệu Chi Tiết
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvTaiLieu = new System.Windows.Forms.DataGridView();
            this.cmbMaTL = new System.Windows.Forms.ComboBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaTL = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaTLCT = new System.Windows.Forms.Label();
            this.txtMaTLCT = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiLieu
            // 
            this.dgvTaiLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiLieu.Location = new System.Drawing.Point(9, 65);
            this.dgvTaiLieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTaiLieu.Name = "dgvTaiLieu";
            this.dgvTaiLieu.RowTemplate.Height = 24;
            this.dgvTaiLieu.Size = new System.Drawing.Size(525, 203);
            this.dgvTaiLieu.TabIndex = 0;
            this.dgvTaiLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiLieu_CellClick);
            // 
            // cmbMaTL
            // 
            this.cmbMaTL.FormattingEnabled = true;
            this.cmbMaTL.Location = new System.Drawing.Point(131, 279);
            this.cmbMaTL.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaTL.Name = "cmbMaTL";
            this.cmbMaTL.Size = new System.Drawing.Size(136, 21);
            this.cmbMaTL.TabIndex = 1;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(283, 279);
            this.cmbMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(136, 21);
            this.cmbMaSV.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 309);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 24);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(75, 309);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 24);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(150, 309);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 24);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMaTL
            // 
            this.lblMaTL.AutoSize = true;
            this.lblMaTL.Location = new System.Drawing.Point(131, 263);
            this.lblMaTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTL.Name = "lblMaTL";
            this.lblMaTL.Size = new System.Drawing.Size(76, 13);
            this.lblMaTL.TabIndex = 9;
            this.lblMaTL.Text = "Chọn Tài Liệu:";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(283, 263);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(83, 13);
            this.lblMaSV.TabIndex = 10;
            this.lblMaSV.Text = "Chọn Sinh Viên:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(9, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(525, 40);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Quản Lý Giao Tài Liệu Cho Sinh Viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaTLCT
            // 
            this.lblMaTLCT.AutoSize = true;
            this.lblMaTLCT.Location = new System.Drawing.Point(10, 264);
            this.lblMaTLCT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTLCT.Name = "lblMaTLCT";
            this.lblMaTLCT.Size = new System.Drawing.Size(105, 13);
            this.lblMaTLCT.TabIndex = 11;
            this.lblMaTLCT.Text = "Mã Tài Liệu Chi Tiết:";
            // 
            // txtMaTLCT
            // 
            this.txtMaTLCT.Location = new System.Drawing.Point(10, 279);
            this.txtMaTLCT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTLCT.Name = "txtMaTLCT";
            this.txtMaTLCT.Size = new System.Drawing.Size(100, 20);
            this.txtMaTLCT.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(431, 309);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frm_QLTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.lblMaTL);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbMaSV);
            this.Controls.Add(this.cmbMaTL);
            this.Controls.Add(this.txtMaTLCT);
            this.Controls.Add(this.lblMaTLCT);
            this.Controls.Add(this.dgvTaiLieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_QLTaiLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Liệu";
            this.Load += new System.EventHandler(this.frm_QLTaiLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnBack;
    }
}
