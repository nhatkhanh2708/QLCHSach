using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class TheLoai : BaseEntity
    {
        public string TenTheLoai { get; set; }
        public ICollection<SachTheLoai> SachTheLoais { get; set; }
    }
}
