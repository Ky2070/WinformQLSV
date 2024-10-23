using QLMH.DangDuyHoang.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace QLMH.DangDuyHoang
{
    public partial class Form1 : Form
    {
        private DBContext dbContext = new DBContext(); // Khởi tạo context của Entity Framework
        private List<MonHoc> listMonHoc; // Danh sách môn học

        public Form1()
        {
            InitializeComponent();
            btnThemSua.Click += new EventHandler(btnThemSua_Click);
            btnXoa.Click += new EventHandler(btnXoa_Click);
            btnQLD.Click += new EventHandler(btnOpenForm2_Click);
            LoadData(); // Tải dữ liệu khi form khởi tạo
        }
        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Tạo một thể hiện mới của Form2
            form2.Show(); // Hiển thị Form2
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu khi form được load
        }

        private void LoadData()
        {
            listMonHoc = dbContext.MonHocs.ToList(); // Lấy danh sách môn học từ cơ sở dữ liệu
            FillDataGridView(listMonHoc); // Điền dữ liệu vào DataGridView
        }

        private void FillDataGridView(List<MonHoc> monHocList)
        {
            dgvBang.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView
            foreach (MonHoc mh in monHocList)
            {
                int rowIndex = dgvBang.Rows.Add(); // Thêm hàng mới
                dgvBang.Rows[rowIndex].Cells[0].Value = mh.MaMH; // Gán mã môn học
                dgvBang.Rows[rowIndex].Cells[1].Value = mh.TenMH; // Gán tên môn học
                dgvBang.Rows[rowIndex].Cells[2].Value = mh.MaGV;   // Cập nhật thêm MaGV
                dgvBang.Rows[rowIndex].Cells[3].Value = mh.MaPDG;  // Cập nhật thêm MaPDG
                dgvBang.Rows[rowIndex].Cells[4].Value = mh.MaQLD; // Cập nhật thêm MaQLD
            }
        }


        private void btnThemSua_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text.Trim(); // Lấy mã môn học
            string tenMH = txtTenMH.Text.Trim(); // Lấy tên môn học
            string maGV = txtMaGV.Text.Trim();
            string maPDG = txtMaPDG.Text.Trim();
            string maQLD = txtMaQLD.Text.Trim();

            if (string.IsNullOrWhiteSpace(maMH) || string.IsNullOrWhiteSpace(tenMH) ||
                string.IsNullOrWhiteSpace(maGV) || string.IsNullOrWhiteSpace(maPDG) ||
                string.IsNullOrWhiteSpace(maQLD))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu mã giáo viên đã tồn tại
            Giao_Vien existingGV = dbContext.Giao_Vien.FirstOrDefault(g => g.MaGV == maGV);
            if (existingGV == null)
            {
                MessageBox.Show("Mã giáo viên không tồn tại. Vui lòng thêm giáo viên trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra nếu mã môn học đã tồn tại
            MonHoc existingMonHoc = dbContext.MonHocs.FirstOrDefault(m => m.MaMH == maMH);
            if (existingMonHoc != null)
            {
                // Cập nhật tên môn học
                existingMonHoc.TenMH = tenMH;
                existingMonHoc.MaGV = maGV;
                existingMonHoc.MaPDG = maPDG;
                existingMonHoc.MaQLD = maQLD;
                dbContext.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thêm mới
                MonHoc newMonHoc = new MonHoc { MaMH = maMH, TenMH = tenMH, MaGV = maGV, MaPDG = maPDG, MaQLD = maQLD };
                dbContext.MonHocs.Add(newMonHoc);
                try
                {
                    dbContext.SaveChanges();
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearTextBoxes();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }
            }

            LoadData(); // Tải lại dữ liệu
            ClearTextBoxes(); // Xóa nội dung các textbox
        }



        private void ClearTextBoxes()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtMaGV.Clear();
            txtMaPDG.Clear();
            txtMaQLD.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xử lý nút "Xóa"
            if (dgvBang.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvBang.SelectedRows)
                {
                    string maMH = row.Cells[0].Value.ToString(); // Lấy mã môn học

                    // Tìm và xóa môn học khỏi cơ sở dữ liệu
                    MonHoc monHocToDelete = dbContext.MonHocs.FirstOrDefault(m => m.MaMH == maMH);
                    if (monHocToDelete != null)
                    {
                        dbContext.MonHocs.Remove(monHocToDelete);
                        dbContext.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    }
                    dgvBang.Rows.RemoveAt(row.Index); // Xóa hàng trong DataGridView
                }
                MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvBang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Điền thông tin vào textbox khi chọn hàng trong DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBang.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells[0].Value.ToString();
                txtTenMH.Text = row.Cells[1].Value.ToString();
                txtMaGV.Text = row.Cells[2].Value.ToString();  // Thêm để lấy MaGV
                txtMaPDG.Text = row.Cells[3].Value.ToString(); // Thêm để lấy MaPDG
                txtMaQLD.Text = row.Cells[4].Value.ToString(); // Thêm để lấy MaQLD
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }
    }
}
