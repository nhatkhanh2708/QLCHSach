using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
