using Model.Entities.Common;
using Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class NhaCungCap : BaseEntity
    {
        public string TenNCC { get; set; }
        public string VietTat { get; set; }
        public DiaChi DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string NgayHopTac { get; set; }
        public bool Status { get; set; }
        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
    }
}
