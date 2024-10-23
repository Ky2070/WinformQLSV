namespace QLMH.DangDuyHoang
{
    partial class Form1
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
            this.dgvBang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtMaPDG = new System.Windows.Forms.TextBox();
            this.txtMaQLD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnQLD = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBang
            // 
            this.dgvBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvBang.Location = new System.Drawing.Point(163, 88);
            this.dgvBang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBang.Name = "dgvBang";
            this.dgvBang.RowHeadersWidth = 51;
            this.dgvBang.RowTemplate.Height = 24;
            this.dgvBang.Size = new System.Drawing.Size(506, 203);
            this.dgvBang.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MaMH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TenMH";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MaGV";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MaPDG";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MaQLD";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(178, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Môn Học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.txtMaPDG);
            this.groupBox1.Controls.Add(this.txtMaQLD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(9, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TenMH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MaMH";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(62, 78);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(76, 20);
            this.txtTenMH.TabIndex = 1;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(62, 30);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(76, 20);
            this.txtMaMH.TabIndex = 0;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(62, 110);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(76, 20);
            this.txtMaGV.TabIndex = 4;
            // 
            // txtMaPDG
            // 
            this.txtMaPDG.Location = new System.Drawing.Point(62, 134);
            this.txtMaPDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPDG.Name = "txtMaPDG";
            this.txtMaPDG.Size = new System.Drawing.Size(76, 20);
            this.txtMaPDG.TabIndex = 5;
            // 
            // txtMaQLD
            // 
            this.txtMaQLD.Location = new System.Drawing.Point(62, 158);
            this.txtMaQLD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaQLD.Name = "txtMaQLD";
            this.txtMaQLD.Size = new System.Drawing.Size(76, 20);
            this.txtMaQLD.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MaGV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "MaPDG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "MaQLD";
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(22, 296);
            this.btnThemSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(76, 19);
            this.btnThemSua.TabIndex = 3;
            this.btnThemSua.Text = "Thêm/Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(103, 296);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 19);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnQLD
            // 
            this.btnQLD.Location = new System.Drawing.Point(9, 23);
            this.btnQLD.Margin = new System.Windows.Forms.Padding(2);
            this.btnQLD.Name = "btnQLD";
            this.btnQLD.Size = new System.Drawing.Size(89, 42);
            this.btnQLD.TabIndex = 6;
            this.btnQLD.Text = "Quản Lý Điểm";
            this.btnQLD.UseVisualStyleBackColor = true;
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(540, 305);
            this.btnForm2.Margin = new System.Windows.Forms.Padding(2);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(118, 26);
            this.btnForm2.TabIndex = 7;
            this.btnForm2.Text = "Quản lý điểm";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 359);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnQLD);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Môn Học";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3; // MaGV
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4; // MaPDG
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5; // MaQLD
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtMaPDG;
        private System.Windows.Forms.TextBox txtMaQLD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnQLD;
        private System.Windows.Forms.Button btnForm2;
    }
}
