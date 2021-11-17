using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class SachTacGiaDTO : BaseDTO
    {
        [Required]
        public int SachId { get; set; }

        [Required]
        public int TacGiaId { get; set; }
    }
}
