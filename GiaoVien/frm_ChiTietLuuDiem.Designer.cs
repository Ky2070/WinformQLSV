namespace QLMH.DangDuyHoang.GiaoVien
{
    partial class frm_ChiTietLuuDiem
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
            this.dgvChiTietLuuDiem = new System.Windows.Forms.DataGridView();
            this.txtMaQLD = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtKetQuaHocTap = new System.Windows.Forms.TextBox();
            this.lblMaQLD = new System.Windows.Forms.Label();
            this.lblMaPDG = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblKetQuaHocTap = new System.Windows.Forms.Label();
            this.lblTrangThaiDiem = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpChiTietInfo = new System.Windows.Forms.GroupBox();
            this.txtTrangThaiDiem = new System.Windows.Forms.TextBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtPDG = new System.Windows.Forms.TextBox();
            this.btnGiaoTL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLuuDiem)).BeginInit();
            this.grpChiTietInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChiTietLuuDiem
            // 
            this.dgvChiTietLuuDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietLuuDiem.Location = new System.Drawing.Point(20, 227);
            this.dgvChiTietLuuDiem.Name = "dgvChiTietLuuDiem";
            this.dgvChiTietLuuDiem.ReadOnly = true;
            this.dgvChiTietLuuDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietLuuDiem.Size = new System.Drawing.Size(760, 250);
            this.dgvChiTietLuuDiem.TabIndex = 1;
            this.dgvChiTietLuuDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietLuuDiem_CellClick);
            // 
            // txtMaQLD
            // 
            this.txtMaQLD.Location = new System.Drawing.Point(130, 30);
            this.txtMaQLD.Name = "txtMaQLD";
            this.txtMaQLD.Size = new System.Drawing.Size(100, 20);
            this.txtMaQLD.TabIndex = 1;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(358, 30);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 20);
            this.txtDiem.TabIndex = 7;
            // 
            // txtKetQuaHocTap
            // 
            this.txtKetQuaHocTap.Location = new System.Drawing.Point(358, 60);
            this.txtKetQuaHocTap.Name = "txtKetQuaHocTap";
            this.txtKetQuaHocTap.Size = new System.Drawing.Size(100, 20);
            this.txtKetQuaHocTap.TabIndex = 9;
            // 
            // lblMaQLD
            // 
            this.lblMaQLD.Location = new System.Drawing.Point(20, 30);
            this.lblMaQLD.Name = "lblMaQLD";
            this.lblMaQLD.Size = new System.Drawing.Size(100, 20);
            this.lblMaQLD.TabIndex = 0;
            this.lblMaQLD.Text = "Mã Quản Lý Điểm:";
            // 
            // lblMaPDG
            // 
            this.lblMaPDG.Location = new System.Drawing.Point(20, 60);
            this.lblMaPDG.Name = "lblMaPDG";
            this.lblMaPDG.Size = new System.Drawing.Size(100, 20);
            this.lblMaPDG.TabIndex = 2;
            this.lblMaPDG.Text = "Phiếu Đánh Giá:";
            // 
            // lblMaSV
            // 
            this.lblMaSV.Location = new System.Drawing.Point(20, 90);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(60, 20);
            this.lblMaSV.TabIndex = 4;
            this.lblMaSV.Text = "Sinh Viên:";
            // 
            // lblDiem
            // 
            this.lblDiem.Location = new System.Drawing.Point(248, 30);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(100, 20);
            this.lblDiem.TabIndex = 6;
            this.lblDiem.Text = "Điểm:";
            // 
            // lblKetQuaHocTap
            // 
            this.lblKetQuaHocTap.Location = new System.Drawing.Point(248, 60);
            this.lblKetQuaHocTap.Name = "lblKetQuaHocTap";
            this.lblKetQuaHocTap.Size = new System.Drawing.Size(100, 20);
            this.lblKetQuaHocTap.TabIndex = 8;
            this.lblKetQuaHocTap.Text = "Kết Quả Học Tập:";
            // 
            // lblTrangThaiDiem
            // 
            this.lblTrangThaiDiem.Location = new System.Drawing.Point(248, 90);
            this.lblTrangThaiDiem.Name = "lblTrangThaiDiem";
            this.lblTrangThaiDiem.Size = new System.Drawing.Size(100, 20);
            this.lblTrangThaiDiem.TabIndex = 10;
            this.lblTrangThaiDiem.Text = "Trạng Thái Điểm:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(581, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(581, 93);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(581, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(141)))));
            this.lblTitle.Location = new System.Drawing.Point(258, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Quản Lý Điểm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpChiTietInfo
            // 
            this.grpChiTietInfo.Controls.Add(this.txtTrangThaiDiem);
            this.grpChiTietInfo.Controls.Add(this.cmbMaSV);
            this.grpChiTietInfo.Controls.Add(this.lblMaQLD);
            this.grpChiTietInfo.Controls.Add(this.txtMaQLD);
            this.grpChiTietInfo.Controls.Add(this.lblMaPDG);
            this.grpChiTietInfo.Controls.Add(this.lblMaSV);
            this.grpChiTietInfo.Controls.Add(this.lblDiem);
            this.grpChiTietInfo.Controls.Add(this.txtDiem);
            this.grpChiTietInfo.Controls.Add(this.lblKetQuaHocTap);
            this.grpChiTietInfo.Controls.Add(this.txtKetQuaHocTap);
            this.grpChiTietInfo.Controls.Add(this.lblTrangThaiDiem);
            this.grpChiTietInfo.Location = new System.Drawing.Point(20, 50);
            this.grpChiTietInfo.Name = "grpChiTietInfo";
            this.grpChiTietInfo.Size = new System.Drawing.Size(500, 155);
            this.grpChiTietInfo.TabIndex = 16;
            this.grpChiTietInfo.TabStop = false;
            this.grpChiTietInfo.Text = "Thông Tin Chi Tiết";
            // 
            // txtTrangThaiDiem
            // 
            this.txtTrangThaiDiem.Location = new System.Drawing.Point(358, 90);
            this.txtTrangThaiDiem.Name = "txtTrangThaiDiem";
            this.txtTrangThaiDiem.Size = new System.Drawing.Size(100, 20);
            this.txtTrangThaiDiem.TabIndex = 11;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.Location = new System.Drawing.Point(86, 90);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(144, 21);
            this.cmbMaSV.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(581, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Làm Mới";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(689, 110);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtPDG
            // 
            this.txtPDG.Location = new System.Drawing.Point(150, 105);
            this.txtPDG.Name = "txtPDG";
            this.txtPDG.Size = new System.Drawing.Size(100, 20);
            this.txtPDG.TabIndex = 19;
            // 
            // btnGiaoTL
            // 
            this.btnGiaoTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGiaoTL.FlatAppearance.BorderSize = 0;
            this.btnGiaoTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoTL.ForeColor = System.Drawing.Color.White;
            this.btnGiaoTL.Location = new System.Drawing.Point(572, 185);
            this.btnGiaoTL.Name = "btnGiaoTL";
            this.btnGiaoTL.Size = new System.Drawing.Size(120, 30);
            this.btnGiaoTL.TabIndex = 20;
            this.btnGiaoTL.Text = "Giao Tài Liệu";
            this.btnGiaoTL.UseVisualStyleBackColor = false;
            this.btnGiaoTL.Click += new System.EventHandler(this.btnGiaoTL_Click);
            // 
            // frm_ChiTietLuuDiem
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnGiaoTL);
            this.Controls.Add(this.txtPDG);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpChiTietInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvChiTietLuuDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChiTietLuuDiem";
            this.Text = "Quản Lý Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLuuDiem)).EndInit();
            this.grpChiTietInfo.ResumeLayout(false);
            this.grpChiTietInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.DataGridView dgvChiTietLuuDiem;
        private System.Windows.Forms.TextBox txtMaQLD;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtKetQuaHocTap;
        private System.Windows.Forms.Label lblMaQLD;
        private System.Windows.Forms.Label lblMaPDG;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblKetQuaHocTap;
        private System.Windows.Forms.Label lblTrangThaiDiem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpChiTietInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtPDG;
        private System.Windows.Forms.TextBox txtTrangThaiDiem;
        private System.Windows.Forms.Button btnGiaoTL;
    }
}
