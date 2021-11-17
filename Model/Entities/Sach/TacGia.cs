using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class TacGia : Person
    {
        [Required]
        public string ButDanh { get; set; }
        public ICollection<SachTacGia> SachTacGias { get; set; }
        public TacGia(int id, String hoTen, DateTime ngaySinh, bool gioiTinh) : base(id, hoTen, ngaySinh, gioiTinh)
        {
            SachTacGias = new Collection<SachTacGia>();
        }
    }
}
