using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities.Common
{
    public abstract class Person : BaseEntity
    {
        [StringLength(60)]
        [Required]
        public string HoTen { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Required]
        public DateTime NgaySinh { get; set; }

        [Required]
        public bool GioiTinh { get; set; }
    }
}
