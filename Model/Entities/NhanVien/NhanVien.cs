﻿using Model.Entities.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class NhanVien : Person
    {
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string SDT { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime NgayBatDau { get; set; }

        public string ChucVu { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        public bool Status { get; set; }

        public TaiKhoan TaiKhoan { get; set; }
    }
}
