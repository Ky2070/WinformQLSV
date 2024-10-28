using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLMH.DangDuyHoang.Model;

namespace QLMH.DangDuyHoang.Admin
{
    public partial class frm_Lop : Form
    {
        DBContext dbContext = new DBContext();
        public frm_Lop()
        {
            InitializeComponent();
        }

        private void frm_Lop_Load(object sender, EventArgs e)
        {
            LoadDataLopHoc();
            LoadKhoaComboBox();
        }

        private void LoadDataLopHoc()
        {
            var dataClass = dbContext.Lops
                                    .Select(l => new
                                    {
                                        MaLop = l.MaLop,
                                        TenLop = l.TenLop,
                                        TenKhoa = l.Khoa.TenKhoa
                                        
                                    }).ToList();
            dgvLop.DataSource = dataClass;

        }

        private void LoadKhoaComboBox()
        {
            var lishKhoas = dbContext.Khoas
                                    .Select(k => new
                                    {
                                        MaKhoa = k.MaKhoa,
                                        TenKhoa = k.TenKhoa
                                    }).ToList();
            cmbMaKhoa.DataSource = lishKhoas;
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvLop.Rows[e.RowIndex];
                txtMaLop.Text = selectedRow.Cells["MaLop"].Value.ToString();
                txtTenLop.Text = selectedRow.Cells["TenLop"].Value.ToString();

                if (selectedRow.Cells["TenKhoa"].Value != null) 
                {
                    var tenKhoa = selectedRow.Cells["TenKhoa"].Value.ToString();
                    cmbMaKhoa.SelectedValue = dbContext.Khoas
                                            .FirstOrDefault(k => k.TenKhoa == tenKhoa)?.MaKhoa;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
            txtMaLop.ReadOnly= false;
        }
        private void ClearData()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();

            cmbMaKhoa.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaLop.Text)
                || string.IsNullOrWhiteSpace(txtTenLop.Text)
                )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           var existingLop = dbContext.Lops
                                      .FirstOrDefault(l => l.MaLop == txtMaLop.Text);
            if(existingLop != null)
            {
                MessageBox.Show("Mã lớp đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Lop newLop = new Lop
            {
                MaLop = txtMaLop.Text,
                TenLop = txtTenLop.Text,
                MaKhoa = cmbMaKhoa.SelectedValue?.ToString() ?? "",
            };
            try
            {
                dbContext.Lops.Add(newLop);
                dbContext.SaveChanges();

                LoadDataLopHoc();
                // Thông báo thêm thành công
                MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (Exception ex) 
            {
                // Thông báo lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi khi thêm lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn một dòng hợp lệ
            if (dgvLop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã lớp từ dòng đã chọn
            var selectedRow = dgvLop.SelectedRows[0];
            string maLop = selectedRow.Cells["MaLop"].Value.ToString();

            // Tìm lớp trong cơ sở dữ liệu
            var lopToEdit = dbContext.Lops
                                     .FirstOrDefault(l => l.MaLop == maLop);
            if (lopToEdit == null)
            {
                MessageBox.Show("Không tìm thấy lớp với mã đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận người dùng có chắc chắn muốn sửa
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin lớp này không?",
                                                "Xác nhận sửa",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            // Nếu người dùng chọn 'Yes', thực hiện sửa
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Cập nhật thông tin lớp từ các trường nhập
                    lopToEdit.TenLop = txtTenLop.Text;
                    lopToEdit.MaKhoa = cmbMaKhoa.SelectedValue?.ToString(); // Nếu có ComboBox mã khoa

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbContext.SaveChanges();

                    // Tải lại danh sách lớp học
                    LoadDataLopHoc();

                    // Thông báo sửa thành công
                    MessageBox.Show("Sửa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa dữ liệu nhập
                    ClearData();
                }
                catch (Exception ex)
                {
                    // Thông báo lỗi nếu có
                    MessageBox.Show("Đã xảy ra lỗi khi sửa lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn một dòng hợp lệ
            if (dgvLop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm mã lớp trong cơ sở dữ liệu
            var selectedRow = dgvLop.SelectedRows[0];
            string maLop = selectedRow.Cells["MaLop"].Value.ToString();

            // Tìm lớp trong cơ sở dữ liệu
            var lopToDelete = dbContext.Lops
                                       .FirstOrDefault(l => l.MaLop == maLop);
            if (lopToDelete == null)
            {
                MessageBox.Show("Không tìm thấy lớp với mã đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận người dùng có chắc chắn muốn xóa
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này không?",
                                                "Xác nhận xóa",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            // Nếu người dùng chọn 'Yes', thực hiện xóa
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    dbContext.Lops.Remove(lopToDelete);
                    dbContext.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    LoadDataLopHoc();

                    // Thông báo xóa thành công
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearData();
                }
                catch (Exception ex)
                {
                    // Thông báo lỗi nếu có
                    MessageBox.Show("Đã xảy ra lỗi khi xóa lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Nếu người dùng chọn 'No', hủy xóa
        }

    }
}
