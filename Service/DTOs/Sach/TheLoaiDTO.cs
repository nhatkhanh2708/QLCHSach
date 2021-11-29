using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class TheLoaiDTO : BaseDTO
    {
        [Required]
        public string TenTheLoai { get; set; }
    }
}
