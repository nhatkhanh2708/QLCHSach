using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
