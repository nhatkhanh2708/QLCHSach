using Model.Entities.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class TaiKhoan : BaseEntity
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
        public bool Status { get; set; }

        public Quyen Quyen { get; set; }

        public NhanVien nhanVien { get; set; }

        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }

        public ICollection<HoaDonXuat> HoaDonXuats { get; set; }

        public TaiKhoan()
        {
            HoaDonNhaps = new Collection<HoaDonNhap>();
            HoaDonXuats = new Collection<HoaDonXuat>();
        }
    }
}
