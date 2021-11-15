using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class TacGia : Person
    {
        public string ButDanh { get; set; }
        public ICollection<SachTacGia> SachTacGias { get; set; }
    }
}
