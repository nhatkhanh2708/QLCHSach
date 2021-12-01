using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class TheLoaiDTO : BaseDTO
    {
        [Required]
        [DisplayName("Tên thể loại")]
        public string TenTheLoai { get; set; }
    }
}
