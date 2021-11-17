using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class DiaChiDTO
    {
        [StringLength(20)]
        [Required]
        public string Duong { get; set; }
        [StringLength(20)]
        [Required]
        public string Quan { get; set; }
        [StringLength(20)]
        [Required]
        public string ThanhPho { get; set; }
    }
}
