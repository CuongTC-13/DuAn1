using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("KichCo")]
public partial class KichCo
{
    [Key]
    [StringLength(10)]
    public string MaSize { get; set; } = null!;

    [StringLength(50)]
    public string? LoaiSize { get; set; }

    [InverseProperty("MaSizeNavigation")]
    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
