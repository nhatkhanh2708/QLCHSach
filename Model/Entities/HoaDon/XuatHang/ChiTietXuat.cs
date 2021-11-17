using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model.Entities
{
    public class ChiTietXuat : BaseEntity
    {
        [Required]
        public int SachId { get; set; }
        public Sach Sach { get; set; }
        [Required]
        public int HdXuatId { get; set; }
        public HoaDonXuat HoaDonXuat { get; set; }
        [DefaultValue(0)]
        [Required]
        public int SoLuong { get; set; }
    }
}
