using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Sach
{
    public class SachTheLoai : BaseEntity
    {
        public int SachId { get; set; }
        public Sach Sach { get; set; }
        public int TheLoaiId { get; set; }
        public TheLoai TheLoai { get; set; }
    }
}
