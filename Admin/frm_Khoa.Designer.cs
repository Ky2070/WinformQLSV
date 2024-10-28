namespace QLMH.DangDuyHoang.Admin
{
    partial class frm_Khoa
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
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtTrangThaiKhoa = new System.Windows.Forms.TextBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblTrangThaiKhoa = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpKhoaInfo = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.grpKhoaInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.Location = new System.Drawing.Point(20, 220);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.ReadOnly = true;
            this.dgvKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoa.Size = new System.Drawing.Size(760, 250);
            this.dgvKhoa.TabIndex = 1;
            this.dgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellClick);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(110, 30);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(50, 20);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(110, 60);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(150, 20);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // txtTrangThaiKhoa
            // 
            this.txtTrangThaiKhoa.Location = new System.Drawing.Point(130, 90);
            this.txtTrangThaiKhoa.Name = "txtTrangThaiKhoa";
            this.txtTrangThaiKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtTrangThaiKhoa.TabIndex = 5;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.Location = new System.Drawing.Point(20, 30);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(80, 20);
            this.lblMaKhoa.TabIndex = 0;
            this.lblMaKhoa.Text = "Mã Khoa:";
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.Location = new System.Drawing.Point(20, 60);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(80, 20);
            this.lblTenKhoa.TabIndex = 2;
            this.lblTenKhoa.Text = "Tên Khoa:";
            // 
            // lblTrangThaiKhoa
            // 
            this.lblTrangThaiKhoa.Location = new System.Drawing.Point(20, 90);
            this.lblTrangThaiKhoa.Name = "lblTrangThaiKhoa";
            this.lblTrangThaiKhoa.Size = new System.Drawing.Size(100, 20);
            this.lblTrangThaiKhoa.TabIndex = 4;
            this.lblTrangThaiKhoa.Text = "Trạng Thái Khoa:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(581, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(581, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(581, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Khoa";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpKhoaInfo
            // 
            this.grpKhoaInfo.Controls.Add(this.btnClear);
            this.grpKhoaInfo.Controls.Add(this.lblMaKhoa);
            this.grpKhoaInfo.Controls.Add(this.txtMaKhoa);
            this.grpKhoaInfo.Controls.Add(this.lblTenKhoa);
            this.grpKhoaInfo.Controls.Add(this.txtTenKhoa);
            this.grpKhoaInfo.Controls.Add(this.lblTrangThaiKhoa);
            this.grpKhoaInfo.Controls.Add(this.txtTrangThaiKhoa);
            this.grpKhoaInfo.Controls.Add(this.btnAdd);
            this.grpKhoaInfo.Controls.Add(this.btnEdit);
            this.grpKhoaInfo.Controls.Add(this.btnDelete);
            this.grpKhoaInfo.Location = new System.Drawing.Point(20, 66);
            this.grpKhoaInfo.Name = "grpKhoaInfo";
            this.grpKhoaInfo.Size = new System.Drawing.Size(760, 134);
            this.grpKhoaInfo.TabIndex = 0;
            this.grpKhoaInfo.TabStop = false;
            this.grpKhoaInfo.Text = "Thông Tin Khoa";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(472, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Làm mới";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frm_Khoa
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpKhoaInfo);
            this.Controls.Add(this.dgvKhoa);
            this.Name = "frm_Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.grpKhoaInfo.ResumeLayout(false);
            this.grpKhoaInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtTrangThaiKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblTrangThaiKhoa;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpKhoaInfo;
        private System.Windows.Forms.Button btnClear;
    }
}
