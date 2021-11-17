using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class TacGiaDTO : PersonDTO
    {
        [Required]
        public string ButDanh { get; set; }

        public ICollection<SachTacGiaDTO> SachTacGias { get; set; }
    }
}
