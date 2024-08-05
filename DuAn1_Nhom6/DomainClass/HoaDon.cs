using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("HoaDon")]
public partial class HoaDon
{
    [Key]
    [Column("IDHoaDon")]
    [StringLength(10)]
    public string IdhoaDon { get; set; } = null!;

    [Column("IDNhanVien")]
    [StringLength(10)]
    public string? IdnhanVien { get; set; }

    [Column("IDKhachHang")]
    [StringLength(10)]
    public string? IdkhachHang { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayTao { get; set; }

    [Column("PTThanhToan")]
    [StringLength(50)]
    public string? PtthanhToan { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayMua { get; set; }

    [InverseProperty("IdhoaDonNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    [ForeignKey("IdkhachHang")]
    [InverseProperty("HoaDons")]
    public virtual KhachHang? IdkhachHangNavigation { get; set; }

    [ForeignKey("IdnhanVien")]
    [InverseProperty("HoaDons")]
    public virtual NhanVien? IdnhanVienNavigation { get; set; }
}
