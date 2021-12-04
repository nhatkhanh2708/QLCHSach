using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{    
    public class NhaXuatBanDTO : BaseDTO
    {
        [StringLength(100)]
        [Required]
        [DisplayName("Nhà xuất bản")]
        public string TenNxb { get; set; }

        [DisplayName("Viết tắt")]
        public string VietTat { get; set; }
    }
}
