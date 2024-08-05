using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("HoaDonChiTiet")]
public partial class HoaDonChiTiet
{
    [Key]
    [Column("MaHoaDonCT")]
    [StringLength(10)]
    public string MaHoaDonCt { get; set; } = null!;

    [Column("IDHoaDon")]
    [StringLength(10)]
    public string? IdhoaDon { get; set; }

    [StringLength(10)]
    public string? MaSanPham { get; set; }

    [Column("IDVoucher")]
    [StringLength(10)]
    public string? Idvoucher { get; set; }

    public int? SoLuong { get; set; }

    public double? TongTien { get; set; }

    [ForeignKey("IdhoaDon")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual HoaDon? IdhoaDonNavigation { get; set; }

    [ForeignKey("Idvoucher")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual Voucher? IdvoucherNavigation { get; set; }

    [ForeignKey("MaSanPham")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
