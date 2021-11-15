using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model.Entities
{
    public class ChiTietXuat : BaseEntity
    {
        public int SachId { get; set; }
        public Sach Sach { get; set; }
        public int HdXuatId { get; set; }
        public HoaDonXuat HoaDonXuat { get; set; }
        public int SoLuong { get; set; }
    }
}
