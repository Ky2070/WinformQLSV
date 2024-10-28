using QLMH.DangDuyHoang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMH.DangDuyHoang.Admin
{
    public partial class frm_qlSV : Form
    {
        DBContext dbContext = new DBContext();
        public frm_qlSV()
        {
            InitializeComponent();
            LoadData();
            LoadKhoaComboBox();
            LoadTenLopComboBox();
        }

        private void LoadData()
        {
            var dataSinhVien = dbContext.Sinh_Vien
                                    .Select(sv => new
                                    {
                                        MaSV = sv.MaSV,
                                        MaLop = sv.Lop.TenLop,
                                        HoTen = sv.HoTenSV,
                                        Phai = sv.Phai,
                                        NgaySinh = sv.NgaySinh,
                                        Khoa = sv.Khoa,
                                        TrangThai = sv.TrangThaiSV
                                    }).ToList();

            // Gán dữ liệu cho DataGridView
            dgvSinhVien.Rows.Clear(); // Xóa các dòng trước đó (nếu có)

            foreach (var sv in dataSinhVien)
            {
                dgvSinhVien.Rows.Add(sv.MaSV, sv.MaLop, sv.HoTen, sv.Phai, sv.NgaySinh, sv.Khoa, sv.TrangThai);
            }
        }

        private void LoadTenLopComboBox()
        {
            var listClass = dbContext.Lops
                                     .Select(l => new
                                     {
                                         l.MaLop,
                                         l.TenLop
                                     }).ToList();

            cbMaLop.DataSource = listClass;
            cbMaLop.DisplayMember = "TenLop";
            cbMaLop.ValueMember = "MaLop";
        }

        private void LoadKhoaComboBox()
        {
            // Lấy danh sách khoa duy nhất từ bảng Sinh_Vien
            var listKhoa = dbContext.Sinh_Vien
                                     .Select(sv => sv.Khoa)
                                     .Distinct() // Lấy các giá trị khoa khác nhau
                                     .ToList();
            cbKhoa.DataSource = listKhoa;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the row index is valid
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dgvSinhVien.Rows[e.RowIndex];

                    // Populate the fields with the selected row's data
                    txtMaSV.Text = row.Cells["dataGridViewTextBoxColumn1"].Value?.ToString() ?? string.Empty;
                    cbMaLop.Text = row.Cells["dataGridViewTextBoxColumn2"].Value?.ToString() ?? string.Empty;
                    txtHoTenSV.Text = row.Cells["dataGridViewTextBoxColumn3"].Value?.ToString() ?? string.Empty;
                    cbPhai.Text = row.Cells["dataGridViewTextBoxColumn4"].Value?.ToString() ?? string.Empty;
                    dtNgaySinh.Value = DateTime.TryParse(row.Cells["dataGridViewTextBoxColumn5"].Value?.ToString(), out DateTime date) ? date : DateTime.Now;
                    cbKhoa.Text = row.Cells["dataGridViewTextBoxColumn6"].Value?.ToString() ?? string.Empty;
                    txtTrangThaiSV.Text = row.Cells["dataGridViewTextBoxColumn7"].Value?.ToString() ?? string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có lớp nào được chọn không
                if (cbMaLop.SelectedValue != null) // Đảm bảo rằng giá trị SelectedValue không null
                {
                    // Kiểm tra xem MaSV đã tồn tại trong cơ sở dữ liệu chưa
                    string maSVInput = txtMaSV.Text.Trim();
                    bool exists = dbContext.Sinh_Vien.Any(sv => sv.MaSV == maSVInput);

                    if (exists)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Ngừng thực hiện nếu mã sinh viên đã tồn tại
                    }

                    var newStudent = new Sinh_Vien
                    {
                        MaSV = txtMaSV.Text,
                        HoTenSV = txtHoTenSV.Text,
                        Phai = cbPhai.Text,
                        NgaySinh = dtNgaySinh.Value,
                        Khoa = cbKhoa.Text,
                        TrangThaiSV = txtTrangThaiSV.Text,
                        MaLop = cbMaLop.SelectedValue?.ToString() ?? "", // Giá trị từ ComboBox// Lấy mã lớp từ SelectedValue
                    };

                    dbContext.Sinh_Vien.Add(newStudent);
                    dbContext.SaveChanges();
                    LoadData(); // Tải lại dữ liệu
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có lớp nào được chọn không
                if (cbMaLop.SelectedValue != null) // Đảm bảo rằng giá trị SelectedValue không null
                {
                    string maSVInput = txtMaSV.Text.Trim();

                    // Tìm sinh viên cần sửa
                    var studentToEdit = dbContext.Sinh_Vien.FirstOrDefault(sv => sv.MaSV == maSVInput);
                    if (studentToEdit == null)
                    {
                        MessageBox.Show("Sinh viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Cập nhật thông tin
                    studentToEdit.HoTenSV = txtHoTenSV.Text;
                    studentToEdit.Phai = cbPhai.Text;
                    studentToEdit.NgaySinh = dtNgaySinh.Value;
                    studentToEdit.Khoa = cbKhoa.Text;
                    studentToEdit.TrangThaiSV = txtTrangThaiSV.Text;
                    studentToEdit.MaLop = cbMaLop.SelectedValue?.ToString() ?? ""; // Lấy mã lớp từ SelectedValue

                    dbContext.SaveChanges();
                    LoadData(); // Tải lại dữ liệu
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maSVInput = txtMaSV.Text.Trim();

                // Tìm sinh viên cần xóa
                var studentToDelete = dbContext.Sinh_Vien.FirstOrDefault(sv => sv.MaSV == maSVInput);
                if (studentToDelete == null)
                {
                    MessageBox.Show("Sinh viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xóa sinh viên
                dbContext.Sinh_Vien.Remove(studentToDelete);
                dbContext.SaveChanges();
                LoadData(); // Tải lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
