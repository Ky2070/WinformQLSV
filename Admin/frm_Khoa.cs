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
    }
}
