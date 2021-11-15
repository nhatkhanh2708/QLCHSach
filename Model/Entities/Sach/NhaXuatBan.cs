using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class NhaXuatBan : BaseEntity
    {
        public string TenNxb { get; set; }
        public string VietTat { get; set; }
        public ICollection<Sach> Sachs { get; set; }
    }
}
