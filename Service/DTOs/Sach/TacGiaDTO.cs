using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class TacGiaDTO : BaseDTO
    {
        [StringLength(60)]
        [Required]
        public string HoTen { get; set; }

        [Required]
        public string ButDanh { get; set; }

        public ICollection<SachTacGiaDTO> SachTacGias { get; set; }
    }
}
