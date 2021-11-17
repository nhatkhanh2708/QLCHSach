using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class TheLoaiDTO : BaseDTO
    {
        [Required]
        public string TenTheLoai { get; set; }
    }
}
