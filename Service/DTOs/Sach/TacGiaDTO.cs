using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class TacGiaDTO : BaseDTO
    {
        [StringLength(60)]
        [Required]
        [DisplayName("Tên tác giả")]
        public string HoTen { get; set; }

        [Required]
        [DisplayName("Bút danh")]
        public string ButDanh { get; set; }
    }
}
