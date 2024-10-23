using QLMH.DangDuyHoang.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace QLMH.DangDuyHoang
{
    public partial class Form2 : Form
    {
        private DBContext dbContext = new DBContext(); // Khởi tạo context của Entity Framework

        public Form2()
        {
            InitializeComponent();
            btnThemCapNhat.Click += new EventHandler(btnThemCapNhat_Click);
            btnDelete.Click += new EventHandler(btnXoa_Click);
            LoadData(); // Tải dữ liệu khi form khởi tạo
        }

        private void LoadData()
        {
            var listDiem = dbContext.Quan_Ly_Diem.ToList(); // Lấy danh sách điểm từ cơ sở dữ liệu
            FillDataGridView(listDiem); // Điền dữ liệu vào DataGridView
        }

        private void FillDataGridView(List<Quan_Ly_Diem> diemList)
        {
            dgvDiem.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView
            foreach (var diem in diemList)
            {
                int rowIndex = dgvDiem.Rows.Add(); // Thêm hàng mới
                dgvDiem.Rows[rowIndex].Cells[0].Value = diem.MaQLD; // Gán mã quản lý điểm
                dgvDiem.Rows[rowIndex].Cells[1].Value = diem.Diem; // Gán điểm
                dgvDiem.Rows[rowIndex].Cells[2].Value = diem.KetQuaHocTap; // Gán kết quả học tập
            }
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            string maQLD = txtMaQLD.Text.Trim(); // Lấy mã quản lý điểm
            string diemText = txtDiem.Text.Trim(); // Lấy điểm
            string ketQua = txtKetQua.Text.Trim(); // Lấy kết quả học tập

            if (string.IsNullOrWhiteSpace(maQLD) || string.IsNullOrWhiteSpace(diemText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double diem;
            if (!double.TryParse(diemText, out diem))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra nếu mã quản lý điểm đã tồn tại
            var existingDiem = dbContext.Quan_Ly_Diem.FirstOrDefault(d => d.MaQLD == maQLD);
            if (existingDiem != null)
            {
                // Cập nhật thông tin
                existingDiem.Diem = diem;
                existingDiem.KetQuaHocTap = ketQua;
                dbContext.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thêm mới
                var newDiem = new Quan_Ly_Diem { MaQLD = maQLD, Diem = diem, KetQuaHocTap = ketQua };
                dbContext.Quan_Ly_Diem.Add(newDiem);
                try
                {
                    dbContext.SaveChanges();
                    MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Tải lại dữ liệu
                    ClearTextBoxes(); // Xóa nội dung các textbox
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
            txtMaQLD.Clear();
            txtDiem.Clear();
            txtKetQua.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDiem.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDiem.SelectedRows)
                {
                    string maQLD = row.Cells[0].Value.ToString(); // Giả sử đây là cột MaQLD

                    // Xóa các bản ghi liên quan trong ChiTietLuuDiem
                    var chiTietLuuDiemList = dbContext.ChiTietLuuDiems.Where(ct => ct.MaQLD == maQLD).ToList();
                    foreach (var chiTiet in chiTietLuuDiemList)
                    {
                        dbContext.ChiTietLuuDiems.Remove(chiTiet);
                    }

                    // Xóa bản ghi trong bảng chính
                    var monHocToDelete = dbContext.MonHocs.FirstOrDefault(m => m.MaQLD == maQLD);
                    if (monHocToDelete != null)
                    {
                        dbContext.MonHocs.Remove(monHocToDelete);
                        dbContext.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                    }
                    dgvDiem.Rows.RemoveAt(row.Index); // Xóa hàng trong DataGridView
                }
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Điền thông tin vào textbox khi chọn hàng trong DataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiem.Rows[e.RowIndex];
                txtMaQLD.Text = row.Cells[0].Value.ToString();
                txtDiem.Text = row.Cells[1].Value.ToString();
                txtKetQua.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
