using System;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class NhanVienDTO : PersonDTO
    {
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string SDT { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime NgayBatDau { get; set; }

        [Required]
        public string ChucVu { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
