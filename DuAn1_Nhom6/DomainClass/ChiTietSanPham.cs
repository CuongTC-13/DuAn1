using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("ChiTietSanPham")]
public partial class ChiTietSanPham
{
    [Key]
    [Column("MaCTSanPham")]
    [StringLength(10)]
    public string MaCtsanPham { get; set; } = null!;

    [StringLength(10)]
    public string? MaSanPham { get; set; }

    [StringLength(10)]
    public string? MaSize { get; set; }

    [StringLength(10)]
    public string? MaChatLieu { get; set; }

    public int? SoLuong { get; set; }

    public int? Gia { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgaySanXuat { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayTao { get; set; }

    [ForeignKey("MaChatLieu")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual ChatLieu? MaChatLieuNavigation { get; set; }

    [ForeignKey("MaSanPham")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual SanPham? MaSanPhamNavigation { get; set; }

    [ForeignKey("MaSize")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual KichCo? MaSizeNavigation { get; set; }
}
