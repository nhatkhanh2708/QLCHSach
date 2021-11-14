using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Sach
{
    public class LichSuGia : BaseEntity
    {
        public int SachId { get; set; }
        public bool LoaiGia { get; set; }
        public decimal Gia { get; set; }
        public Sach Sach { get; set; }
    }
}
