using Model.Entities.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class TacGia : Person
    {
        [StringLength(60)]
        [Required]
        public string HoTen { get; set; }

        [Required]
        public string ButDanh { get; set; }

        public ICollection<SachTacGia> SachTacGias { get; set; }

        public TacGia()
        {
            SachTacGias = new Collection<SachTacGia>();
        }
    }
}
