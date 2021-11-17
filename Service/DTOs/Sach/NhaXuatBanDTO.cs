using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class NhaXuatBanDTO : BaseDTO
    {
        [StringLength(100)]
        [Required]
        public string TenNxb { get; set; }
        public string VietTat { get; set; }

        //Test
        public ICollection<SachDTO> Sachs { get; set; }
    }
}
