using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class CtXuatDTO : BaseDTO
    {
        [Required]
        public int SachId { get; set; }
        [Required]
        public int HdXuatId { get; set; }
        [DefaultValue(0)]
        [Required]
        public int SoLuong { get; set; }
    }
}
