using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class TaiKhoanDTO : BaseDTO
    {
        [Required]
        public int NhanVienId { get; set; }

        [Required]
        public int QuyenId { get; set; }

        [StringLength(100)]
        [Required]
        public string Username { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required]
        public bool Status { get; set; }

        public ICollection<HdNhapDTO> HoaDonNhaps { get; set; }
        public ICollection<HdXuatDTO> HoaDonXuats { get; set; }
    }
}
