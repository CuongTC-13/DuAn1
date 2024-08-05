using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("BaoHanh")]
public partial class BaoHanh
{
    [Key]
    [StringLength(10)]
    public string MaBaoHanh { get; set; } = null!;

    [StringLength(10)]
    public string? MaSanPham { get; set; }

    [Column("ThoiGianBH", TypeName = "date")]
    public DateTime? ThoiGianBh { get; set; }

    [ForeignKey("MaSanPham")]
    [InverseProperty("BaoHanhs")]
    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
