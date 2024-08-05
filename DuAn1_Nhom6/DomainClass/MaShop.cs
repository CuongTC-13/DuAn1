using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("MaShop")]
public partial class MaShop
{
    [Key]
    [StringLength(255)]
    public string MaMayChu { get; set; } = null!;
}
