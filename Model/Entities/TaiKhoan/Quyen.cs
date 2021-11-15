using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Quyen : BaseEntity
    {
        public string TenQuyen { get; set; }
        public string MoTa { get; set; }
        public ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
