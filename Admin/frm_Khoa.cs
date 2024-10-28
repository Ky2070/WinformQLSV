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
    public partial class frm_Khoa : Form
    {
        DBContext dbContext = new DBContext();
        public frm_Khoa()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var dataKhoa = dbContext.Khoas.Select(k => new
                                {
                                    MaKhoa = k.MaKhoa,
                                    TenKhoa = k.TenKhoa,
                                    TrangThaiKhoa = k.TrangThaiKhoa,
                                }).ToList();

                dgvKhoa.DataSource = dataKhoa;
            }
            catch (Exception ex) {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu:" + ex.Message);
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.ReadOnly = true;
            //txtMaKhoa.ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];
                txtMaKhoa.Text = row.Cells["MaKhoa"].Value.ToString();
                txtTenKhoa.Text = row.Cells["TenKhoa"].Value.ToString();
                txtTrangThaiKhoa.Text = row.Cells["TrangThaiKhoa"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu không được để trống
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text) || string.IsNullOrWhiteSpace(txtTrangThaiKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mã khoa có trùng không
            var existingKhoa = dbContext.Khoas.SingleOrDefault(k => k.MaKhoa == txtMaKhoa.Text);
            if (existingKhoa != null)
            {
                MessageBox.Show("Mã khoa đã tồn tại. Vui lòng nhập mã khoa khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var existingTenKhoa = dbContext.Khoas.SingleOrDefault(nk => nk.TenKhoa == txtTenKhoa.Text);
            if (existingTenKhoa != null)
            {
                MessageBox.Show("Tên khoa đã tồn tại. Vui lòng nhập tên khoa khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Tạo đối tượng Khoa mới
            var newKhoa = new Khoa
            {
                MaKhoa = txtMaKhoa.Text.Trim(),
                TenKhoa = txtTenKhoa.Text.Trim(),
                TrangThaiKhoa = txtTrangThaiKhoa.Text.Trim()
            };

            // Thêm Khoa vào DbContext và lưu thay đổi
            dbContext.Khoas.Add(newKhoa);
            dbContext.SaveChanges();

            // Tải lại dữ liệu trong DataGridView và hiển thị thông báo thành công
            LoadData();
            MessageBox.Show("Thêm khoa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trắng các TextBox sau khi thêm
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtTrangThaiKhoa.Clear();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn một dòng hợp lệ
            if (dgvKhoa.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một khoa để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã khoa từ dòng đã chọn
            var selectedRow = dgvKhoa.SelectedRows[0];
            string maKhoa = selectedRow.Cells["MaKhoa"].Value.ToString();

            
            // Tìm khoa trong cơ sở dữ liệu
            var khoaToEdit = dbContext.Khoas
                                      .SingleOrDefault(k => k.MaKhoa == maKhoa);
            if (khoaToEdit == null)
            {
                MessageBox.Show("Không tìm thấy khoa với mã đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận người dùng có chắc chắn muốn sửa
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin khoa này không?",
                                                "Xác nhận sửa",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            // Nếu người dùng chọn 'Yes', thực hiện sửa
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Cập nhật thông tin khoa từ các trường nhập
                    khoaToEdit.TenKhoa = txtTenKhoa.Text.Trim();
                    khoaToEdit.TrangThaiKhoa = txtTrangThaiKhoa.Text.Trim();

                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbContext.SaveChanges();

                    // Tải lại danh sách khoa
                    LoadData();

                    // Thông báo sửa thành công
                    MessageBox.Show("Sửa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKhoa.ReadOnly = false;
                    // Xóa trắng các TextBox sau khi sửa
                    txtMaKhoa.Clear();
                    txtTenKhoa.Clear();
                    txtTrangThaiKhoa.Clear();
                }
                catch (Exception ex)
                {
                    // Thông báo lỗi nếu có
                    MessageBox.Show("Đã xảy ra lỗi khi sửa khoa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng có chọn một dòng không
            if (dgvKhoa.SelectedRows.Count > 0)
            {
                // Lấy MaKhoa từ dòng được chọn
                var selectedRow = dgvKhoa.SelectedRows[0];
                string maKhoa = selectedRow.Cells["MaKhoa"].Value.ToString();

                var khoa = dbContext.Khoas.SingleOrDefault(k => k.MaKhoa == maKhoa);
                if (khoa != null)
                {
                    // Xác nhận xóa trước khi thực hiện
                    var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dbContext.Khoas.Remove(khoa);
                        dbContext.SaveChanges();

                        MessageBox.Show("Xóa khoa thành công.");
                        LoadData();

                        // Xóa trắng các TextBox sau khi thêm
                        txtMaKhoa.Clear();
                        txtTenKhoa.Clear();
                        txtTrangThaiKhoa.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtTrangThaiKhoa.Clear();
            txtMaKhoa.ReadOnly = false;
        }
    }
}
