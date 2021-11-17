using Model.Entities.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
