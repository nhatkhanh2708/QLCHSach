using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class SachTacGiaDTO : BaseDTO
    {
        [Required]
        public int SachId { get; set; }
        [Required]
        public int TacGiaId { get; set; }
    }
}
