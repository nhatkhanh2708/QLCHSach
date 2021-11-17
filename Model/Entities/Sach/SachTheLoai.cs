using Model.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class SachTheLoai : BaseEntity
    {
        [Required]
        public int SachId { get; set; }

        public Sach Sach { get; set; }

        [Required]
        public int TheLoaiId { get; set; }

        public TheLoai TheLoai { get; set; }
    }
}
