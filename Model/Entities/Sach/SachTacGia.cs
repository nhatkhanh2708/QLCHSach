using Model.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class SachTacGia : BaseEntity
    {
        [Required]
        public int SachId { get; set; }

        public Sach Sach { get; set; }

        [Required]
        public int TacGiaId { get; set; }

        public TacGia TacGia { get; set; }
    }
}
