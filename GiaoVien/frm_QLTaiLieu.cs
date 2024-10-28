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

namespace QLMH.DangDuyHoang.GiaoVien
{
    public partial class frm_QLTaiLieu : Form
    {
        DBContext dbContext = new DBContext();
        public frm_QLTaiLieu()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            var listSV = dbContext.Sinh_Vien.Select(s => new
            {
                s.MaSV,
                s.HoTenSV
            }).ToList();

            cmbMaSV.DataSource = listSV;
            cmbMaSV.DisplayMember = "HoTenSV";
            cmbMaSV.ValueMember = "MaSV";

            var listTL = dbContext.Tai_lIeu
                .Select(s => new 
                { 
                    s.MaTL,
                    s.TenTL
                }).ToList();

            cmbMaTL.DataSource = listTL;
            cmbMaTL.DisplayMember = "TenTL";
            cmbMaTL.ValueMember = "MaTL";


            dgvTaiLieu.DataSource = dbContext.TaiLieuChiTiets.Select(tl => new
            {
                MaTLCT = tl.MaTLCT,
                TenTaiLieu = tl.Tai_lIeu.TenTL,
                TenSinhVien = tl.Sinh_Vien.HoTenSV
            }).ToList();
        }
        private void dgvTaiLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu người dùng nhấp vào hàng hợp lệ
            {
                // Lấy dữ liệu từ hàng đã nhấp
                var row = dgvTaiLieu.Rows[e.RowIndex];
               

                // Cập nhật ComboBox và TextBox nếu cần
                var maTLCT = row.Cells["MaTLCT"].Value?.ToString();
                var hoTenSV = row.Cells["TenSinhVien"].Value?.ToString();
                var tenTL = row.Cells["TenTaiLieu"].Value?.ToString();

                txtMaTLCT.Text = maTLCT;
                cmbMaTL.SelectedIndex = cmbMaTL.FindStringExact(tenTL);
                cmbMaSV.SelectedIndex = cmbMaSV.FindStringExact(hoTenSV);
            }
        }
        private void frm_QLTaiLieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_ChiTietLuuDiem frmCTLD = new frm_ChiTietLuuDiem();
            this.Hide();
            frmCTLD.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int maTLCT;
                if (!int.TryParse(txtMaTLCT.Text.Trim(), out maTLCT))
                {
                    MessageBox.Show("Mã tài liệu chi tiết không hợp lệ!");
                    return;
                }
                string maSV = cmbMaSV.SelectedValue.ToString();
                string maTL = cmbMaTL.SelectedValue.ToString();

                // Kiểm tra mã TLCT đã tồn tại chưa
                if (dbContext.TaiLieuChiTiets.Any(t => t.MaTLCT == maTLCT))
                {
                    MessageBox.Show("Mã tài liệu chi tiết đã tồn tại!");
                    return;
                }

                // Kiểm tra sinh viên có tồn tại trong cơ sở dữ liệu không
                if (!dbContext.Sinh_Vien.Any(s => s.MaSV == maSV))
                {
                    MessageBox.Show("Sinh viên không tồn tại trong cơ sở dữ liệu!");
                    return;
                }

                // Kiểm tra xem sinh viên đã được giao tài liệu này chưa
                if (dbContext.TaiLieuChiTiets.Any(t => t.MaSV == maSV && t.MaTL == maTL))
                {
                    MessageBox.Show("Sinh viên đã được giao tài liệu này rồi!");
                    return;
                }

                // Tạo đối tượng tài liệu chi tiết mới
                var taiLieuCT = new TaiLieuChiTiet
                {
                    MaTLCT = maTLCT,
                    MaSV = maSV,
                    MaTL = maTL
                };

                // Thêm vào cơ sở dữ liệu
                dbContext.TaiLieuChiTiets.Add(taiLieuCT);
                dbContext.SaveChanges();

                LoadData();
                MessageBox.Show("Thêm tài liệu chi tiết thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm tài liệu chi tiết: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maTLCT;
                if (!int.TryParse(txtMaTLCT.Text.Trim(), out maTLCT))
                {
                    MessageBox.Show("Mã tài liệu chi tiết không hợp lệ!");
                    return;
                }

                string maSV = cmbMaSV.SelectedValue.ToString();
                string maTL = cmbMaTL.SelectedValue.ToString();

                // Kiểm tra tài liệu chi tiết có tồn tại không
                var taiLieuCT = dbContext.TaiLieuChiTiets.SingleOrDefault(t => t.MaTLCT == maTLCT);
                if (taiLieuCT == null)
                {
                    MessageBox.Show("Tài liệu chi tiết không tồn tại!");
                    return;
                }

                // Kiểm tra sinh viên đã được giao tài liệu này chưa
                if (dbContext.TaiLieuChiTiets.Any(t => t.MaSV == maSV && t.MaTL == maTL && t.MaTLCT != maTLCT))
                {
                    MessageBox.Show("Sinh viên đã được giao tài liệu này rồi!");
                    return;
                }

                // Cập nhật thông tin tài liệu chi tiết
                taiLieuCT.MaSV = maSV;
                taiLieuCT.MaTL = maTL;

                // Lưu thay đổi
                dbContext.SaveChanges();

                LoadData();
                MessageBox.Show("Cập nhật tài liệu chi tiết thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật tài liệu chi tiết: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maTLCT;
                if (!int.TryParse(txtMaTLCT.Text.Trim(), out maTLCT))
                {
                    MessageBox.Show("Mã tài liệu chi tiết không hợp lệ!");
                    return;
                }

                // Kiểm tra tài liệu chi tiết có tồn tại không
                var taiLieuCT = dbContext.TaiLieuChiTiets.SingleOrDefault(t => t.MaTLCT == maTLCT);
                if (taiLieuCT == null)
                {
                    MessageBox.Show("Tài liệu chi tiết không tồn tại!");
                    return;
                }

                // Xóa tài liệu chi tiết
                dbContext.TaiLieuChiTiets.Remove(taiLieuCT);
                dbContext.SaveChanges();

                LoadData();
                MessageBox.Show("Xóa tài liệu chi tiết thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa tài liệu chi tiết: " + ex.Message);
            }
        }

    }
}
