using System.Windows.Forms;

namespace QLMH.DangDuyHoang
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtMaQLD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemCapNhat = new System.Windows.Forms.Button();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtMaQLD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(186, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(118, 75);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(131, 20);
            this.txtKetQua.TabIndex = 5;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(118, 43);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(131, 20);
            this.txtDiem.TabIndex = 4;
            // 
            // txtMaQLD
            // 
            this.txtMaQLD.Location = new System.Drawing.Point(118, 15);
            this.txtMaQLD.Name = "txtMaQLD";
            this.txtMaQLD.Size = new System.Drawing.Size(131, 20);
            this.txtMaQLD.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kết Quả học tập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MaQLD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(200, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản lý điểm";
            // 
            // btnThemCapNhat
            // 
            this.btnThemCapNhat.Location = new System.Drawing.Point(106, 376);
            this.btnThemCapNhat.Name = "btnThemCapNhat";
            this.btnThemCapNhat.Size = new System.Drawing.Size(200, 30);
            this.btnThemCapNhat.TabIndex = 8;
            this.btnThemCapNhat.Text = "Thêm/CậpNhật";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeight = 29;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDiem.Location = new System.Drawing.Point(27, 220);
            this.dgvDiem.MultiSelect = false;
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(645, 150);
            this.dgvDiem.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MaQLD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Điểm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kết Quả Học Tập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(332, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(684, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemCapNhat);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtKetQua;
        private TextBox txtDiem;
        private TextBox txtMaQLD;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnThemCapNhat;
        private DataGridView dgvDiem;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}