using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class SachTacGia : BaseEntity
    {
        public int SachId { get; set; }
        public Sach Sach { get; set; }
        public int TacGiaId { get; set; }
        public TacGia TacGia { get; set; }
    }
}
