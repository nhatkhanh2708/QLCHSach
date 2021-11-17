using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class CtNhapDTO : BaseDTO
    {
        [Required]
        public int SachId { get; set; }
        [Required]
        public int HdNhapId { get; set; }
        [DefaultValue(0)]
        [Required]
        public int SoLuong { get; set; }
    }
}
