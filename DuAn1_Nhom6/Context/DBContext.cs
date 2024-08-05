using System;
using System.Collections.Generic;
using DuAn1_Nhom6.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adminacc> Adminaccs { get; set; }

    public virtual DbSet<BaoHanh> BaoHanhs { get; set; }

    public virtual DbSet<ChatLieu> ChatLieus { get; set; }

    public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KichCo> KichCos { get; set; }

    public virtual DbSet<MaShop> MaShops { get; set; }

    public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-K5I0S8PT;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adminacc>(entity =>
        {
            entity.HasKey(e => e.MaAdmin).HasName("PK__Adminacc__49341E38FE384E11");
        });

        modelBuilder.Entity<BaoHanh>(entity =>
        {
            entity.HasKey(e => e.MaBaoHanh).HasName("PK__BaoHanh__A8DF52E58D577815");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.BaoHanhs).HasConstraintName("FK__BaoHanh__MaSanPh__33D4B598");
        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {
            entity.HasKey(e => e.MaChatLieu).HasName("PK__ChatLieu__453995BCE2E962D2");
        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.MaCtsanPham).HasName("PK__ChiTietS__F525A439466D8633");

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaCha__3C69FB99");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaSan__3A81B327");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaSiz__3B75D760");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.IdhoaDon).HasName("PK__HoaDon__5B896F491403C526");

            entity.HasOne(d => d.IdkhachHangNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__IDKhachH__4222D4EF");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__IDNhanVi__412EB0B6");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonCt).HasName("PK__HoaDonCh__38C56E846483B387");

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__IDHoa__44FF419A");

            entity.HasOne(d => d.IdvoucherNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__IDVou__46E78A0C");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__MaSan__45F365D3");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdkhachHang).HasName("PK__KhachHan__5A7167B5EC9D4B73");
        });

        modelBuilder.Entity<KichCo>(entity =>
        {
            entity.HasKey(e => e.MaSize).HasName("PK__KichCo__A787E7ED6245B4FC");
        });

        modelBuilder.Entity<MaShop>(entity =>
        {
            entity.HasKey(e => e.MaMayChu).HasName("PK__MaShop__F8549736924B7F10");
        });

        modelBuilder.Entity<NhaSanXuat>(entity =>
        {
            entity.HasKey(e => e.MaNhaSanXuat).HasName("PK__NhaSanXu__838C17A1BB840AF2");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdnhanVien).HasName("PK__NhanVien__7AC2D9F7BC5871D0");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPham__FAC7442DB609B02F");

            entity.HasOne(d => d.MaNhaSanXuatNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK__SanPham__MaNhaSa__30F848ED");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Idvoucher).HasName("PK__Voucher__50249A27AF86F985");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
