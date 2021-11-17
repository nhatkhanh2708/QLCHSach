using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class SachTheLoaiDTO : BaseDTO 
    {
        [Required]
        public int SachId { get; set; }

        [Required]
        public int TheLoaiId { get; set; }
    }
}
