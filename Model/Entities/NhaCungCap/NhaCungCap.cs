using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class NhaCungCap : BaseEntity
    {
        [StringLength(60)]
        [Required]
        public string TenNCC { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string SDT { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime NgayHopTac { get; set; }

        public bool? Status { get; set; }

        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }

        public NhaCungCap()
        {
            HoaDonNhaps = new Collection<HoaDonNhap>();            
        }
    }
}
