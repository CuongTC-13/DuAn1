using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DuAn1_Nhom6.DomainClass;

[Table("Voucher")]
public partial class Voucher
{
    [Key]
    [Column("IDVoucher")]
    [StringLength(10)]
    public string Idvoucher { get; set; } = null!;

    public int? MenhGia { get; set; }

    [Column(TypeName = "date")]
    public DateTime? HanSuDung { get; set; }

    [StringLength(25)]
    public string? NguoiTao { get; set; }

    [InverseProperty("IdvoucherNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();
}
