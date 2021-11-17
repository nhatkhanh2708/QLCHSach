using System.ComponentModel.DataAnnotations;

namespace Model.ValueObjects
{
    public class DiaChi
    {
        [StringLength(20)]
        [Required]
        public string Duong { get; set; }

        [StringLength(20)]
        [Required]
        public string Quan { get; set; }

        [Required]
        [StringLength(20)]
        public string ThanhPho { get; set; }
    }
}
