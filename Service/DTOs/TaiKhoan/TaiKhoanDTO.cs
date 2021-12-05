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

        public byte[] PasswordHash { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
