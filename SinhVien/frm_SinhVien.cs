using QLMH.DangDuyHoang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMH.DangDuyHoang.SinhVien
{
    public partial class frm_SinhVien : Form
    {
        private Sinh_Vien sinhVien;
        public frm_SinhVien(Sinh_Vien sinhVien)
        {
            InitializeComponent();
            this.sinhVien = sinhVien;

            // Hiển thị thông tin sinh viên lên các điều khiển
            DisplaySinhVienInfo();
        }

        private void DisplaySinhVienInfo()
        {
            // Hiển thị thông tin sinh viên vào TextBox
            txtMaSV.Text = sinhVien.MaSV;
            txtHoTen.Text = sinhVien.HoTenSV;
            txtLop.Text = sinhVien.Lop.TenLop;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận đăng xuất
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Kiểm tra nếu người dùng chọn "Yes"
            if (result == DialogResult.Yes)
            {
                // Hiển thị form đăng nhập
                frm_Login loginForm = new frm_Login();
                loginForm.Show();

                // Đóng form sinh viên hiện tại
                this.Close();
            }
            // Nếu chọn "No", không làm gì cả
        }
        private IEnumerable<dynamic> TraCuuChiTietLuuDiem(string maSV)
        {
            using (var context = new DBContext()) // `DBContext` là DbContext bạn đang sử dụng
            {
                // Truy vấn từ bảng ChiTietLuuDiem và liên kết với các bảng khác nếu cần thiết
                var query = from ctd in context.ChiTietLuuDiems
                            where ctd.MaSV == maSV
                            select new
                            {
                                MaQLD = ctd.MaQLD,
                                MaPDG = ctd.MaPDG,
                                MaSV = ctd.MaSV,
                                TenSV = ctd.Sinh_Vien.HoTenSV,
                                Diem = ctd.Quan_Ly_Diem.Diem, // Giả sử bạn có thuộc tính Điểm trong Quan_Ly_Diem
                                XepLoai = ctd.Quan_Ly_Diem.KetQuaHocTap // Nếu bạn muốn lấy thông tin từ bảng liên quan
                            };

                return query.ToList();
            }
        }

        private void btnKQHT_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;

            // Gọi hàm tra cứu điểm từ Entity Framework
            var chiTietDiem = TraCuuChiTietLuuDiem(maSV);

            // Hiển thị dữ liệu lên DataGridView
            dataGridView1.DataSource = chiTietDiem.ToList();
        }

        // Phương thức lấy hoạt động ngoại khóa từ CSDL
        private List<dynamic> LayHoatDongNgoaiKhoa(string maSV)
        {
            using (var context = new DBContext())
            {
                var query = from hdnk in context.Thanh_Tich
                            where hdnk.MaSV == maSV
                            select new
                            {
                                MaHD = hdnk.MaHDNK,
                                TenHDNK = hdnk.Hoat_Dong_Ngoai_Khoa.TenHDNK,
                                TenSV = hdnk.Sinh_Vien.HoTenSV   
                            };

                return query.ToList<dynamic>();
            }
        }

        private List<dynamic> TraCuuTaiLieus(string maSV)
        {
            using (var context = new DBContext())
            {
                var query = from tlct in context.TaiLieuChiTiets
                            where tlct.MaSV == maSV
                            select new
                            {
                                MaTL = tlct.MaTL,
                                TenTaiLieu = tlct.Tai_lIeu.TenTL,
                                LoaiTaiLieu = tlct.Tai_lIeu.LoaiTL,
                                PhuTrachTL = tlct.Tai_lIeu.Giao_Vien.HoTenGV
                            };

                return query.ToList<dynamic>();
            }
        }
        private void btnHDNK_Click(object sender, EventArgs e)
        {
            // Lấy Mã Sinh Viên từ TextBox
            string maSV = txtMaSV.Text;

            // Gọi phương thức lấy dữ liệu hoạt động ngoại khóa
            var hoatDongNK = LayHoatDongNgoaiKhoa(maSV);

            // Gán dữ liệu vào DataGridView
            dataGridView1.DataSource = hoatDongNK;
        }

        private void btnTaiLieu_Click(object sender, EventArgs e)
        {
            // Lấy Mã Sinh Viên từ TextBox
            string maSV = txtMaSV.Text;
            
            var TaiLieuSV = TraCuuTaiLieus(maSV);

            dataGridView1.DataSource = TaiLieuSV;
        }
    }
}
