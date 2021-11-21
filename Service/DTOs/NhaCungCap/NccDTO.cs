using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class NccDTO : BaseDTO
    {
        [StringLength(60)]
        [Required]
        public string TenNCC { get; set; }

        public string VietTat { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string SDT { get; set; }

        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string NgayHopTac { get; set; }

        [Required]
        public bool Status { get; set; }

        public ICollection<HdNhapDTO> HoaDonNhaps { get; set; }
    }
}
