using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
