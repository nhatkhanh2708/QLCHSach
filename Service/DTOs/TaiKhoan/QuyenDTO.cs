using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class QuyenDTO : BaseDTO
    {
        [StringLength(20)]
        [Required]
        public string TenQuyen { get; set; }
        [StringLength(60)]
        public string MoTa { get; set; }
    }
}
