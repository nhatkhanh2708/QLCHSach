using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class HoaDonXuat : BaseEntity
    {
        public int TaiKhoanId { get; set; }
        public decimal TongTien { get; set; }
        public DateTime NgayTao { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public ICollection<ChiTietXuat> ChiTietXuats { get; set; }
    }
}
