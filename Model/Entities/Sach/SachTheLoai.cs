using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
