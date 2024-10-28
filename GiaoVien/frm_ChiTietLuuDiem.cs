using System;
using System.Linq;
using System.Windows.Forms;
using QLMH.DangDuyHoang.Model;

namespace QLMH.DangDuyHoang.GiaoVien
{
    public partial class frm_ChiTietLuuDiem : Form
    {
        private readonly DBContext _dBContext;

        public frm_ChiTietLuuDiem()
        {
            InitializeComponent();
            _dBContext = new DBContext();
            LoadData();
            
            loadDataSV();
           
        }

        private void LoadData()
        {
            try
            {
                // Thực hiện truy vấn để lấy dữ liệu từ bảng ChiTietLuuDiem và join với các bảng liên quan
                var data = from cld in _dBContext.ChiTietLuuDiems
                           join pdg in _dBContext.Phieu_Danh_Gia on cld.MaPDG equals pdg.MaPDG
                           join sv in _dBContext.Sinh_Vien on cld.MaSV equals sv.MaSV
                           join qld in _dBContext.Quan_Ly_Diem on cld.MaQLD equals qld.MaQLD
                           select new
                           {
                               cld.MaQLD,
                               cld.MaPDG,
                               HoTen = sv.HoTenSV, // Tên sinh viên
                               qld.Diem,
                               KetQuaHocTap = qld.KetQuaHocTap,
                               qld.TrangThaiDiem
                           };

                // Gán dữ liệu cho DataGridView
                dgvChiTietLuuDiem.DataSource = data.ToList();

                // Đặt tên cho các cột
                dgvChiTietLuuDiem.Columns[0].HeaderText = "Mã Quản Lý Điểm";
                dgvChiTietLuuDiem.Columns[1].HeaderText = "Mã Phiếu Đánh Giá";
                dgvChiTietLuuDiem.Columns[2].HeaderText = "Họ Tên Sinh Viên";
                dgvChiTietLuuDiem.Columns[3].HeaderText = "Điểm";
                dgvChiTietLuuDiem.Columns[4].HeaderText = "Kết Quả Học Tập";
                dgvChiTietLuuDiem.Columns[5].HeaderText = "Trạng Thái Điểm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận đăng xuất
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                                                  "Xác nhận đăng xuất",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Kiểm tra lựa chọn của người dùng
            if (result == DialogResult.Yes)
            {
                // Tạo instance của form đăng nhập
                frm_Login loginForm = new frm_Login();

                // Hiển thị form đăng nhập
                loginForm.Show();

                // Đóng form hiện tại
                this.Hide();
            }
        }
        private void loadDataSV()
        {
            var listSV = _dBContext.Sinh_Vien
                                    .Select(s => new
                                    {
                                        s.MaSV,
                                        s.HoTenSV
                                    }).ToList();
            cmbMaSV.DataSource = listSV;
            cmbMaSV.DisplayMember = "HoTenSV";
            cmbMaSV.ValueMember = "MaSV";
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các trường nhập liệu
                string maQLD = txtMaQLD.Text; // Giả sử MaQLD là string
                string maPDG = txtPDG.Text; // Giả sử MaPDG là string
                string maSV = cmbMaSV.SelectedValue.ToString(); // Chọn giá trị từ ComboBox
                float diem = float.Parse(txtDiem.Text); // Chuyển đổi điểm thành float
                string ketQuaHocTap = txtKetQuaHocTap.Text; // Kết quả học tập
                string trangThaiDiem = txtTrangThaiDiem.Text; // Trạng thái điểm

                // Kiểm tra xem MaQLD và MaPDG đã tồn tại hay chưa
                bool existsMaQLD = _dBContext.Quan_Ly_Diem.Any(cld => cld.MaQLD == maQLD);

                if (!existsMaQLD)
                {
                    MessageBox.Show($"Mã quản lý điểm {maQLD} không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra xem MaPDG có tồn tại trong bảng PhieuDanhGia không
                bool existsMaPDG = _dBContext.Phieu_Danh_Gia.Any(pdg => pdg.MaPDG == maPDG);
                if (!existsMaPDG)
                {
                    MessageBox.Show($"Mã phiếu đánh giá {maPDG} không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng lại nếu không tồn tại
                }


                // Tạo đối tượng mới của ChiTietLuuDiem
                var chiTietLuuDiem = new ChiTietLuuDiem
                {
                    MaQLD = maQLD,
                    MaPDG = maPDG,
                    MaSV = maSV,
                    // Các trường khác cần phải thiết lập từ bảng ChiTietLuuDiem
                    // Cần thiết lập các giá trị Diem, KetQuaHocTap, TrangThaiDiem
                };

                // Nếu cần thêm thông tin từ bảng QuanLyDiem
                var quanLyDiem = new Quan_Ly_Diem
                {
                    Diem = diem,
                    KetQuaHocTap = ketQuaHocTap,
                    TrangThaiDiem = trangThaiDiem
                };

                // Thêm đối tượng vào DBContext
                _dBContext.ChiTietLuuDiems.Add(chiTietLuuDiem);
                _dBContext.Quan_Ly_Diem.Add(quanLyDiem); // Thêm vào bảng QuanLyDiem nếu cần
                _dBContext.SaveChanges();

                // Tải lại dữ liệu
                LoadData();
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị mã quản lý điểm từ TextBox
                string maQLD = txtMaQLD.Text;

                // Tìm bản ghi cần cập nhật dựa trên MaQLD
                var chiTietLuuDiem = _dBContext.ChiTietLuuDiems
                    .FirstOrDefault(cld => cld.MaQLD == maQLD);

                if (chiTietLuuDiem != null)
                {
                    // Cập nhật các giá trị
                    chiTietLuuDiem.MaPDG = txtPDG.Text; // Cập nhật MaPDG là string
                    chiTietLuuDiem.MaSV = cmbMaSV.SelectedValue.ToString(); // Chuyển SelectedValue sang string
                    chiTietLuuDiem.Quan_Ly_Diem.Diem = double.Parse(txtDiem.Text); // Cập nhật Diem là string
                    chiTietLuuDiem.Quan_Ly_Diem.KetQuaHocTap = txtKetQuaHocTap.Text; // Cập nhật Kết Quả Học Tập
                    chiTietLuuDiem.Quan_Ly_Diem.TrangThaiDiem = txtTrangThaiDiem.Text; // Cập nhật Trạng Thái Điểm

                    // Lưu thay đổi vào DBContext
                    _dBContext.SaveChanges();

                    // Tải lại dữ liệu
                    LoadData();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Tìm bản ghi cần xóa dựa trên MaQLD
                int maQLD = int.Parse(txtMaQLD.Text);
                var chiTietLuuDiem = _dBContext.ChiTietLuuDiems
                    .FirstOrDefault(cld => cld.MaQLD.Equals(maQLD));

                if (chiTietLuuDiem != null)
                {
                    // Xóa bản ghi khỏi DBContext
                    _dBContext.ChiTietLuuDiems.Remove(chiTietLuuDiem);
                    _dBContext.SaveChanges();

                    // Tải lại dữ liệu
                    LoadData();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaQLD.Clear();
            txtPDG.Clear();
            txtDiem.Clear();
            txtKetQuaHocTap.Clear();
            txtTrangThaiDiem.Clear();
            cmbMaSV.SelectedIndex = 0; // Hoặc chọn một giá trị mặc định
        }

        private void dgvChiTietLuuDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem hàng được chọn có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow row = dgvChiTietLuuDiem.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột của hàng hiện tại
                var maQLD = row.Cells["MaQLD"].Value?.ToString();
                var maPDG = row.Cells["MaPDG"].Value?.ToString();
                var hoTenSV = row.Cells["HoTen"].Value?.ToString();
                var diem = row.Cells["Diem"].Value?.ToString();
                var ketQuaHocTap = row.Cells["KetQuaHocTap"].Value?.ToString();
                var trangThaiDiem = row.Cells["TrangThaiDiem"].Value?.ToString();

                // Tìm và chọn giá trị trong ComboBox cmbMaSV dựa vào tên sinh viên
                cmbMaSV.SelectedIndex = cmbMaSV.FindStringExact(hoTenSV);

                // Tương tự, đổ các giá trị vào các ComboBox hoặc TextBox khác nếu có
                // Ví dụ:
                txtMaQLD.Text = maQLD;
                txtPDG.Text = maPDG;
                txtDiem.Text = diem;
                txtKetQuaHocTap.Text = ketQuaHocTap;
                txtTrangThaiDiem.Text = trangThaiDiem;
                
            }
        }

        private void btnGiaoTL_Click(object sender, EventArgs e)
        {
            frm_QLTaiLieu frmTL = new frm_QLTaiLieu();
            this.Hide();
            frmTL.Show();
        }
    }
}
