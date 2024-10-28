namespace QLMH.DangDuyHoang.Admin
{
    partial class frm_qlSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.lblPhai = new System.Windows.Forms.Label();
            this.cbPhai = new System.Windows.Forms.ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblTrangThaiSV = new System.Windows.Forms.Label();
            this.txtTrangThaiSV = new System.Windows.Forms.TextBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaLop
            // 
            this.cbMaLop.Location = new System.Drawing.Point(120, 124);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(150, 21);
            this.cbMaLop.TabIndex = 3;
            // 
            // cbKhoa
            // 
            this.cbKhoa.Location = new System.Drawing.Point(120, 284);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(150, 21);
            this.cbKhoa.TabIndex = 11;
            // 
            // lblMaSV
            // 
            this.lblMaSV.Location = new System.Drawing.Point(20, 84);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(90, 23);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã Sinh Viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(120, 84);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(150, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // lblMaLop
            // 
            this.lblMaLop.Location = new System.Drawing.Point(20, 124);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(50, 23);
            this.lblMaLop.TabIndex = 2;
            this.lblMaLop.Text = "Tên Lớp:";
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.Location = new System.Drawing.Point(20, 164);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(90, 23);
            this.lblHoTenSV.TabIndex = 4;
            this.lblHoTenSV.Text = "Họ Tên SV:";
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(120, 164);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(150, 20);
            this.txtHoTenSV.TabIndex = 5;
            // 
            // lblPhai
            // 
            this.lblPhai.Location = new System.Drawing.Point(20, 204);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(90, 23);
            this.lblPhai.TabIndex = 6;
            this.lblPhai.Text = "Phái:";
            // 
            // cbPhai
            // 
            this.cbPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbPhai.Location = new System.Drawing.Point(120, 204);
            this.cbPhai.Name = "cbPhai";
            this.cbPhai.Size = new System.Drawing.Size(150, 21);
            this.cbPhai.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 244);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(90, 23);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(120, 244);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(150, 20);
            this.dtNgaySinh.TabIndex = 9;
            // 
            // lblKhoa
            // 
            this.lblKhoa.Location = new System.Drawing.Point(20, 284);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(90, 23);
            this.lblKhoa.TabIndex = 10;
            this.lblKhoa.Text = "Khoa:";
            // 
            // lblTrangThaiSV
            // 
            this.lblTrangThaiSV.Location = new System.Drawing.Point(20, 324);
            this.lblTrangThaiSV.Name = "lblTrangThaiSV";
            this.lblTrangThaiSV.Size = new System.Drawing.Size(90, 23);
            this.lblTrangThaiSV.TabIndex = 12;
            this.lblTrangThaiSV.Text = "Trạng Thái:";
            // 
            // txtTrangThaiSV
            // 
            this.txtTrangThaiSV.Location = new System.Drawing.Point(120, 324);
            this.txtTrangThaiSV.Name = "txtTrangThaiSV";
            this.txtTrangThaiSV.Size = new System.Drawing.Size(150, 20);
            this.txtTrangThaiSV.TabIndex = 13;
            // 
            // dgvSinhVien
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSinhVien.Location = new System.Drawing.Point(290, 78);
            this.dgvSinhVien.Name = "dgvSinhVien";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSinhVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSinhVien.Size = new System.Drawing.Size(544, 300);
            this.dgvSinhVien.TabIndex = 14;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã SV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Lớp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ Tên SV";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Phái";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày Sinh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Khoa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(110, 387);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 387);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(290, 387);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Làm Mới";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 50);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quản Lý Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_qlSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.cbMaLop);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblHoTenSV);
            this.Controls.Add(this.txtHoTenSV);
            this.Controls.Add(this.lblPhai);
            this.Controls.Add(this.cbPhai);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblTrangThaiSV);
            this.Controls.Add(this.txtTrangThaiSV);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frm_qlSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // Khai báo ComboBox cho Khoa và Lớp
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.ComboBox cbPhai;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtTrangThaiSV;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblTrangThaiSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
    }
}