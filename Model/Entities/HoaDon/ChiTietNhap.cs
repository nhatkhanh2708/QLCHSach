using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class ChiTietNhap : BaseEntity
    {
        [Required]
        public int SachId { get; set; }

        public Sach Sach { get; set; }

        [Required]
        public int HdNhapId { get; set; }

        public HoaDonNhap HoaDonNhap { get; set; }

        [Required]
        [DefaultValue(0)]
        public int SoLuong { get; set; }
    }
}
