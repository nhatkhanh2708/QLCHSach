using System.ComponentModel.DataAnnotations;

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
