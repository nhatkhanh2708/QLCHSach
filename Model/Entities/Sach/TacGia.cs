using Model.Entities.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class TacGia : Person
    {
        [Required]
        public string ButDanh { get; set; }

        public ICollection<SachTacGia> SachTacGias { get; set; }

        public TacGia()
        {
            SachTacGias = new Collection<SachTacGia>();
        }
    }
}
