using Model.Entities.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class TheLoai : BaseEntity
    {
        [Required]
        public string TenTheLoai { get; set; }

        public ICollection<SachTheLoai> SachTheLoais { get; set; }

        public TheLoai()
        {
            SachTheLoais = new Collection<SachTheLoai>();
        }
    }
}
