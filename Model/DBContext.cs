using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLMH.DangDuyHoang.Model
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<ChiTietLuuDiem> ChiTietLuuDiems { get; set; }
        public virtual DbSet<Giao_Vien> Giao_Vien { get; set; }
        public virtual DbSet<Hoat_Dong_Ngoai_Khoa> Hoat_Dong_Ngoai_Khoa { get; set; }
        public virtual DbSet<Hop_Dong_Lam_Viec> Hop_Dong_Lam_Viec { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<Phieu_Danh_Gia> Phieu_Danh_Gia { get; set; }
        public virtual DbSet<Quan_Ly_Cap_Cao> Quan_Ly_Cap_Cao { get; set; }
        public virtual DbSet<Quan_Ly_Diem> Quan_Ly_Diem { get; set; }
        public virtual DbSet<Quan_Tri_Vien> Quan_Tri_Vien { get; set; }
        public virtual DbSet<Quyen_Truy_Cap> Quyen_Truy_Cap { get; set; }
        public virtual DbSet<Sinh_Vien> Sinh_Vien { get; set; }
        public virtual DbSet<Tai_Khoan_Nguoi_Dung> Tai_Khoan_Nguoi_Dung { get; set; }
        public virtual DbSet<Tai_lIeu> Tai_lIeu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietLuuDiem>()
                .Property(e => e.MaQLD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLuuDiem>()
                .Property(e => e.MaPDG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLuuDiem>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Giao_Vien>()
                .Property(e => e.MaGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Giao_Vien>()
                .Property(e => e.MaQTV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Giao_Vien>()
                .Property(e => e.MaQTC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Giao_Vien>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Giao_Vien>()
                .HasMany(e => e.Hop_Dong_Lam_Viec)
                .WithRequired(e => e.Giao_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Giao_Vien>()
                .HasMany(e => e.MonHocs)
                .WithRequired(e => e.Giao_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Giao_Vien>()
                .HasMany(e => e.Tai_lIeu)
                .WithRequired(e => e.Giao_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hoat_Dong_Ngoai_Khoa>()
                .Property(e => e.MaHDNK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoat_Dong_Ngoai_Khoa>()
                .Property(e => e.MaQTV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoat_Dong_Ngoai_Khoa>()
                .HasMany(e => e.Sinh_Vien)
                .WithMany(e => e.Hoat_Dong_Ngoai_Khoa)
                .Map(m => m.ToTable("Thanh_Tich").MapLeftKey("MaHDNK").MapRightKey("MaSV"));

            modelBuilder.Entity<Hop_Dong_Lam_Viec>()
                .Property(e => e.MaHopDong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hop_Dong_Lam_Viec>()
                .Property(e => e.MucLuong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Hop_Dong_Lam_Viec>()
                .Property(e => e.MaQTV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hop_Dong_Lam_Viec>()
                .Property(e => e.MaGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.Giao_Vien)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.Lops)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.MonHocs)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.Sinh_Vien)
                .WithRequired(e => e.Lop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaPDG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaQLD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Danh_Gia>()
                .Property(e => e.MaPDG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Danh_Gia>()
                .HasMany(e => e.ChiTietLuuDiems)
                .WithRequired(e => e.Phieu_Danh_Gia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phieu_Danh_Gia>()
                .HasMany(e => e.MonHocs)
                .WithRequired(e => e.Phieu_Danh_Gia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quan_Ly_Cap_Cao>()
                .Property(e => e.MaQLCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Quan_Ly_Cap_Cao>()
                .HasMany(e => e.Quan_Tri_Vien)
                .WithRequired(e => e.Quan_Ly_Cap_Cao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quan_Ly_Diem>()
                .Property(e => e.MaQLD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Quan_Ly_Diem>()
                .HasMany(e => e.ChiTietLuuDiems)
                .WithRequired(e => e.Quan_Ly_Diem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quan_Ly_Diem>()
                .HasMany(e => e.MonHocs)
                .WithRequired(e => e.Quan_Ly_Diem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quan_Tri_Vien>()
                .Property(e => e.MaQTV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Quan_Tri_Vien>()
                .Property(e => e.BangCap)
                .IsUnicode(false);

            modelBuilder.Entity<Quan_Tri_Vien>()
                .Property(e => e.MaQLCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Quan_Tri_Vien>()
                .HasMany(e => e.Giao_Vien)
                .WithRequired(e => e.Quan_Tri_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quan_Tri_Vien>()
                .HasMany(e => e.Hoat_Dong_Ngoai_Khoa)
                .WithRequired(e => e.Quan_Tri_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quan_Tri_Vien>()
                .HasMany(e => e.Hop_Dong_Lam_Viec)
                .WithRequired(e => e.Quan_Tri_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quan_Tri_Vien>()
                .HasMany(e => e.Quyen_Truy_Cap)
                .WithRequired(e => e.Quan_Tri_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quyen_Truy_Cap>()
                .Property(e => e.MaQTC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Quyen_Truy_Cap>()
                .Property(e => e.MaQTV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Quyen_Truy_Cap>()
                .HasMany(e => e.Giao_Vien)
                .WithRequired(e => e.Quyen_Truy_Cap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quyen_Truy_Cap>()
                .HasMany(e => e.Tai_Khoan_Nguoi_Dung)
                .WithRequired(e => e.Quyen_Truy_Cap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sinh_Vien>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sinh_Vien>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sinh_Vien>()
                .HasMany(e => e.ChiTietLuuDiems)
                .WithRequired(e => e.Sinh_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sinh_Vien>()
                .HasMany(e => e.Tai_Khoan_Nguoi_Dung)
                .WithRequired(e => e.Sinh_Vien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sinh_Vien>()
                .HasMany(e => e.Tai_lIeu)
                .WithMany(e => e.Sinh_Vien)
                .Map(m => m.ToTable("TaiLieuChiTiet").MapLeftKey("MaSV").MapRightKey("MaTL"));

            modelBuilder.Entity<Tai_Khoan_Nguoi_Dung>()
                .Property(e => e.MaTKND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tai_Khoan_Nguoi_Dung>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tai_Khoan_Nguoi_Dung>()
                .Property(e => e.MaQTC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tai_lIeu>()
                .Property(e => e.MaTL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tai_lIeu>()
                .Property(e => e.MaGV)
                .IsFixedLength()
                .IsUnicode(false);



        }
    }
}
