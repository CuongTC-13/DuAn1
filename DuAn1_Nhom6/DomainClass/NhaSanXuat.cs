using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("NhaSanXuat")]
public partial class NhaSanXuat
{
    [Key]
    [StringLength(10)]
    public string MaNhaSanXuat { get; set; } = null!;

    [StringLength(50)]
    public string? TenNhaSanXuat { get; set; }

    [InverseProperty("MaNhaSanXuatNavigation")]
    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
