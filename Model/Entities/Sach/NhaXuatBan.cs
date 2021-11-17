using Model.Entities.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class NhaXuatBan : BaseEntity
    {
        [StringLength(100)]
        [Required]
        public string TenNxb { get; set; }

        public string VietTat { get; set; }

        public ICollection<Sach> Sachs { get; set; }

        public NhaXuatBan()
        {
            Sachs = new Collection<Sach>();
        }
    }
}
