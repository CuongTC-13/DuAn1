using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    [Column("IDNhanVien")]
    [StringLength(10)]
    public string IdnhanVien { get; set; } = null!;

    [StringLength(50)]
    public string? TenNhanVien { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgaySinh { get; set; }

    [Column("SDT")]
    [StringLength(50)]
    public string? Sdt { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [StringLength(50)]
    public string? GioiTinh { get; set; }

    public int? LuongNhanVien { get; set; }

    [Column("MK")]
    [StringLength(50)]
    public string? Mk { get; set; }

    [InverseProperty("IdnhanVienNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
