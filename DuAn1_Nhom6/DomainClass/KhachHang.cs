using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("KhachHang")]
public partial class KhachHang
{
    [Key]
    [Column("IDKhachHang")]
    [StringLength(10)]
    public string IdkhachHang { get; set; } = null!;

    [StringLength(50)]
    public string? TenKhachHang { get; set; }

    [Column("SDT")]
    [StringLength(50)]
    public string? Sdt { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [StringLength(50)]
    public string? GioiTinh { get; set; }

    [StringLength(255)]
    public string? DiaChi { get; set; }

    [InverseProperty("IdkhachHangNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
