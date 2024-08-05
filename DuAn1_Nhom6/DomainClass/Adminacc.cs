using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("Adminacc")]
public partial class Adminacc
{
    [Key]
    [StringLength(255)]
    public string MaAdmin { get; set; } = null!;

    [StringLength(255)]
    public string? HoVaTen { get; set; }

    public string? MatKhau { get; set; }

    [StringLength(20)]
    public string? GioiTinh { get; set; }

    [StringLength(255)]
    public string? Email { get; set; }

    [StringLength(20)]
    public string? Chucvu { get; set; }
}
