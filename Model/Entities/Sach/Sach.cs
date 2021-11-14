using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Sach
{
    public class Sach : BaseEntity
    {
        public string TenSach { get; set; }
        public string MaSach { get; set; }
        public int NxbId { get; set; }
        public byte[] Thumbnail { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiamGia { get; set; }
        public bool Status { get; set; }

        public NhaXuatBan Nxb { get; set; }
        public ICollection<SachTheLoai> SachTheLoais { get; set; }
        public ICollection<SachTacGia> SachTacGias { get; set; }
        public ICollection<LichSuGia> LichSuGias { get; set; }
    }
}
