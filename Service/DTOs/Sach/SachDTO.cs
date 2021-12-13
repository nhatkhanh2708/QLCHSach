using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class SachDTO : BaseDTO 
    {
        [StringLength(100)]
        public string TenSach { get; set; }

        [Required]
        public int NxbId { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal GiaNhap { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal GiaBan { get; set; }

        [Required]
        [DefaultValue(0)]
        public int SoLuong { get; set; }

        public byte[] Img { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public int NccId { get; set; }
    }
}
