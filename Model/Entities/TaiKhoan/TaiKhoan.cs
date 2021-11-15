using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class TaiKhoan : BaseEntity
    {
        public int NhanVienId { get; set; }
        public int QuyenId { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        public Quyen Quyen { get; set; }
        public NhanVien nhanVien { get; set; }
        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
        public ICollection<HoaDonXuat> HoaDonXuats { get; set; }
    }
}
