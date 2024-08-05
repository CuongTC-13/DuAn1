using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("ChatLieu")]
public partial class ChatLieu
{
    [Key]
    [StringLength(10)]
    public string MaChatLieu { get; set; } = null!;

    [StringLength(50)]
    public string? LoaiChatLieu { get; set; }

    [InverseProperty("MaChatLieuNavigation")]
    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
