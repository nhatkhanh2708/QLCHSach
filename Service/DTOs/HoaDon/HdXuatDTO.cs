using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class HdXuatDTO : BaseDTO
    {
        [Required]
        public int TaiKhoanId { get; set; }
        [Required]
        public decimal TongTien { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime NgayTao { get; set; }
        public ICollection<CtXuatDTO> ChiTietXuats { get; set; }
    }
}
