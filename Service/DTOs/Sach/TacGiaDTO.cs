using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class TacGiaDTO : PersonDTO
    {
        [Required]
        public string ButDanh { get; set; }
    }
}
