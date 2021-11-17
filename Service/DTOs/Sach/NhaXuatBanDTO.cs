using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class NhaXuatBanDTO : BaseDTO
    {
        [StringLength(100)]
        [Required]
        public string TenNxb { get; set; }

        public string VietTat { get; set; }

        public ICollection<SachDTO> Sachs { get; set; }
    }
}
