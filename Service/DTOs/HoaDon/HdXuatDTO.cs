using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class HdXuatDTO : BaseDTO
    {
        [Required]
        public int TaiKhoanId { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal TongTien { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime NgayTao { get; set; }

        public ICollection<CtXuatDTO> ChiTietXuats { get; set; }
    }
}
