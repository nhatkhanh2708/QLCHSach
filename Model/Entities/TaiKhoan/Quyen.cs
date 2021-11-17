using Model.Entities.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class Quyen : BaseEntity
    {
        [StringLength(20)]
        [Required]
        public string TenQuyen { get; set; }

        [StringLength(60)]
        public string MoTa { get; set; }

        public ICollection<TaiKhoan> TaiKhoans { get; set; }

        public Quyen()
        {
            TaiKhoans = new Collection<TaiKhoan>();
        }
    }
}
