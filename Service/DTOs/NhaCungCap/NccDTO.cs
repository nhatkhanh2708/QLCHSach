﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class NccDTO : BaseDTO, ICloneable
    {
        [StringLength(60)]
        [Required]
        public string TenNCC { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string SDT { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime NgayHopTac { get; set; }

        public bool? Status { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
