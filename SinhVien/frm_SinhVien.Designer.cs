namespace QLMH.DangDuyHoang.SinhVien
{
    partial class frm_SinhVien
    {
        // Các điều khiển
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxInfo;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.btnKQHT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHDNK = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông Tin Sinh Viên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(30, 40);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(95, 17);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã Sinh Viên:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 90);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(59, 17);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ Tên:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(30, 140);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(36, 17);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaSV.Location = new System.Drawing.Point(150, 40);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(86, 23);
            this.txtMaSV.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHoTen.Location = new System.Drawing.Point(150, 87);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(133, 23);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtLop
            // 
            this.txtLop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLop.Location = new System.Drawing.Point(150, 140);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(187, 23);
            this.txtLop.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(250, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đăng xuất";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.lblMaSV);
            this.groupBoxInfo.Controls.Add(this.lblHoTen);
            this.groupBoxInfo.Controls.Add(this.lblLop);
            this.groupBoxInfo.Controls.Add(this.txtMaSV);
            this.groupBoxInfo.Controls.Add(this.txtHoTen);
            this.groupBoxInfo.Controls.Add(this.txtLop);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(100, 70);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(416, 190);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Thông Tin Sinh Viên";
            // 
            // btnKQHT
            // 
            this.btnKQHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKQHT.Location = new System.Drawing.Point(557, 147);
            this.btnKQHT.Name = "btnKQHT";
            this.btnKQHT.Size = new System.Drawing.Size(181, 30);
            this.btnKQHT.TabIndex = 3;
            this.btnKQHT.Text = "Tra cứu kết quả học tập";
            this.btnKQHT.UseVisualStyleBackColor = true;
            this.btnKQHT.Click += new System.EventHandler(this.btnKQHT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 138);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnHDNK
            // 
            this.btnHDNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDNK.Location = new System.Drawing.Point(557, 221);
            this.btnHDNK.Name = "btnHDNK";
            this.btnHDNK.Size = new System.Drawing.Size(181, 30);
            this.btnHDNK.TabIndex = 5;
            this.btnHDNK.Text = "Hoạt động ngoại khóa";
            this.btnHDNK.UseVisualStyleBackColor = true;
            this.btnHDNK.Click += new System.EventHandler(this.btnHDNK_Click);
            // 
            // frm_SinhVien
            // 
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.btnHDNK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKQHT);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SinhVien";
            this.Text = "Thông Tin Sinh Viên";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnKQHT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHDNK;
    }
}
