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
using System.Data.Entity.Infrastructure;
using QLMH.DangDuyHoang.Admin;


namespace QLMH.DangDuyHoang
    {
        public partial class frm_GV : Form
        {
        private DBContext dbContext = new DBContext(); // Khởi tạo context của Entity Framework
        private List<Giao_Vien> listGiaoVien;
        public frm_GV()
            {
                InitializeComponent();
                LoadGiaoVien();
            }

            private void frm_GV_Load(object sender, EventArgs e)
            {
                LoadGiaoVien();
            }

        private void LoadGiaoVien()
        {
            // Giả lập việc lấy dữ liệu từ cơ sở dữ liệu
            // Ở đây bạn có thể gọi đến DBContext để lấy danh sách giáo viên thực tế
            var listGiaoVien = dbContext.Giao_Vien
                               .Select(gv => new
                               {
                                   gv.MaGV,
                                   gv.MaQTV,
                                   gv.HoTenGV,
                                   gv.Phai,
                                   gv.NgaySinh,
                                   gv.DiaChi,
                                   gv.MaQTC,
                                   gv.MaKhoa,
                                   gv.BangCap,
                                   gv.TrangThaiGV
                                   // Có thể thêm hoặc bớt các trường tùy ý
                               })
                               .ToList();

            // Hiển thị danh sách giáo viên vào một DataGridView (nếu có)
            dgvGiaoVien.DataSource = listGiaoVien;
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.ReadOnly = true;
            btnThem.Enabled = false;
            // Kiểm tra nếu người dùng đã nhấp vào một ô hợp lệ (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng đã nhấp
                var selectedRow = dgvGiaoVien.Rows[e.RowIndex];

                // Giả sử bạn có các TextBox để hiển thị dữ liệu
                txtMaGV.Text = selectedRow.Cells["MaGV"].Value.ToString();
                txtMaQTV.Text = selectedRow.Cells["MaQTV"].Value.ToString();
                txtHoTenGV.Text = selectedRow.Cells["HoTenGV"].Value.ToString();
                txtPhai.Text = selectedRow.Cells["Phai"].Value.ToString();
                // Gán giá trị cho DateTimePicker
                if (DateTime.TryParse(selectedRow.Cells["NgaySinh"].Value.ToString(), out DateTime ngaySinh))
                {
                    dtpNgaySinh.Value = ngaySinh; // Gán giá trị vào DateTimePicker
                }
                else
                {
                    dtpNgaySinh.Value = DateTime.Now; // Hoặc giá trị mặc định nếu không thành công
                }
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtMaQTC.Text = selectedRow.Cells["MaQTC"].Value.ToString();
                txtMaKhoa.Text = selectedRow.Cells["MaKhoa"].Value.ToString();
                txtBangCap.Text = selectedRow.Cells["BangCap"].Value.ToString();
                txtTrangThaiGV.Text = selectedRow.Cells["TrangThaiGV"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearData();
            txtMaGV.ReadOnly = false;
            btnThem.Enabled = true;
            dtpNgaySinh.Value = DateTime.Now;
        }   

        private void ClearData()
        {
            txtMaGV.Clear();
            txtMaQTV.Clear();
            txtHoTenGV.Clear();
            txtPhai.Clear();
            txtDiaChi.Clear();
            txtMaQTC.Clear();
            txtMaKhoa.Clear();
            txtBangCap.Clear();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường bắt buộc đã được điền đầy đủ hay chưa
            if (string.IsNullOrWhiteSpace(txtMaGV.Text) || string.IsNullOrWhiteSpace(txtHoTenGV.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mã giáo viên đã tồn tại chưa
            var existingGiaoVien = dbContext.Giao_Vien
                                    .FirstOrDefault(gv => gv.MaGV == txtMaGV.Text);

            if (existingGiaoVien != null)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mã QTV đã tồn tại chưa
            var existingQuanTriVien = dbContext.Giao_Vien
                                                .FirstOrDefault(gv => gv.MaQTV == txtMaQTV.Text);

            if (existingQuanTriVien != null)
            {
                MessageBox.Show("Mã quản trị viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra độ tuổi của giáo viên (phải từ 18 tuổi trở lên)
            DateTime today = DateTime.Now;
            DateTime ngaySinh = dtpNgaySinh.Value;

            if ((today.Year - ngaySinh.Year) < 18 || (today.Year - ngaySinh.Year == 18 && today < ngaySinh.AddYears(18)))
            {
                MessageBox.Show("Giáo viên phải từ 18 tuổi trở lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng Giao_Vien mới
            Giao_Vien newGiaoVien = new Giao_Vien
            {
                MaGV = txtMaGV.Text.ToUpper(),
                MaQTV = txtMaQTV.Text.ToUpper(),
                HoTenGV = txtHoTenGV.Text,
                Phai = txtPhai.Text,
                NgaySinh = dtpNgaySinh.Value,
                DiaChi = txtDiaChi.Text,
                MaQTC = txtMaQTC.Text.ToUpper(),
                MaKhoa = txtMaKhoa.Text.ToUpper(),
                BangCap = txtBangCap.Text,
                TrangThaiGV = txtTrangThaiGV.Text,
            };

            try
            {
                // Thêm giáo viên vào cơ sở dữ liệu
                dbContext.Giao_Vien.Add(newGiaoVien);
                dbContext.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                // Tải lại danh sách giáo viên để cập nhật DataGridView
                LoadGiaoVien();

                // Thông báo thêm thành công
                MessageBox.Show("Thêm giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa dữ liệu nhập để thêm giáo viên mới
                ClearData();
            }
            catch (DbUpdateException dbEx)
            {
                // Kiểm tra InnerException để lấy thông tin chi tiết
                var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : dbEx.Message;
                MessageBox.Show("Đã xảy ra lỗi khi thêm giáo viên: " + innerException, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Thông báo lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi khi thêm giáo viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng hợp lệ
            if (dgvGiaoVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một giáo viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã giáo viên từ dòng được chọn
            var selectedRow = dgvGiaoVien.SelectedRows[0];
            string maGV = selectedRow.Cells["MaGV"].Value.ToString();

            // Tìm giáo viên trong cơ sở dữ liệu
            var giaoVienToUpdate = dbContext.Giao_Vien.FirstOrDefault(gv => gv.MaGV == maGV);

            if (giaoVienToUpdate == null)
            {
                MessageBox.Show("Không tìm thấy giáo viên với mã đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mã giáo viên có tồn tại không (trừ mã hiện tại)
            //string newMaGV = txtMaGV.Text; // Giả định rằng mã mới được nhập vào txtMaGV
            //if (newMaGV != maGV && dbContext.Giao_Vien.Any(gv => gv.MaGV == newMaGV))
            //{
            //    MessageBox.Show("Mã giáo viên đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(txtMaGV.Text) ||
                string.IsNullOrWhiteSpace(txtMaQTV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTenGV.Text) ||
                string.IsNullOrWhiteSpace(txtPhai.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtMaQTC.Text) ||
                string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtBangCap.Text) ||
                string.IsNullOrWhiteSpace(txtTrangThaiGV.Text))
            {
                MessageBox.Show("Vui lòng không để trống các trường thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin giáo viên từ các TextBox
            //giaoVienToUpdate.MaGV = txtMaGV.Text; // Cập nhật mã giáo viên nếu cần thiết
            giaoVienToUpdate.MaQTV = txtMaQTV.Text;
            giaoVienToUpdate.HoTenGV = txtHoTenGV.Text;
            giaoVienToUpdate.Phai = txtPhai.Text;
            giaoVienToUpdate.NgaySinh = dtpNgaySinh.Value;
            giaoVienToUpdate.DiaChi = txtDiaChi.Text;
            giaoVienToUpdate.MaQTC = txtMaQTC.Text;
            giaoVienToUpdate.MaKhoa = txtMaKhoa.Text;
            giaoVienToUpdate.BangCap = txtBangCap.Text;
            giaoVienToUpdate.TrangThaiGV = txtTrangThaiGV.Text;

            try
            {
                // Lưu thay đổi vào cơ sở dữ liệu
                dbContext.SaveChanges();

                // Tải lại danh sách giáo viên để cập nhật DataGridView
                LoadGiaoVien();

                // Thông báo sửa thành công
                MessageBox.Show("Sửa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa dữ liệu nhập sau khi sửa
                ClearData();
            }
            catch (Exception ex)
            {
                // Thông báo lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi khi sửa giáo viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn một dòng hợp lệ
            if (dgvGiaoVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một giáo viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã giáo viên từ dòng được chọn
            var selectedRow = dgvGiaoVien.SelectedRows[0];
            string maGV = selectedRow.Cells["MaGV"].Value.ToString();

            // Tìm giáo viên trong cơ sở dữ liệu
            var giaoVienToDelete = dbContext.Giao_Vien.FirstOrDefault(gv => gv.MaGV == maGV);
            Console.WriteLine(giaoVienToDelete.ToString());
            if (giaoVienToDelete == null)
            {
                MessageBox.Show("Không tìm thấy giáo viên với mã đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xóa giáo viên khỏi cơ sở dữ liệu
            try
            {
                dbContext.Giao_Vien.Remove(giaoVienToDelete);
                dbContext.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                // Tải lại danh sách giáo viên để cập nhật DataGridView
                LoadGiaoVien();

                // Thông báo xóa thành công
                MessageBox.Show("Xóa giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa dữ liệu nhập sau khi xóa
                ClearData();
            }
            catch (Exception ex)
            {
                // Thông báo lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi khi xóa giáo viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_TaiKhoanNguoiDung frm_TKND = new frm_TaiKhoanNguoiDung();
            this.Hide();
            frm_TKND.Show();
        }
    }
}
