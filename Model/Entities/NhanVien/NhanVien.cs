﻿using Model.Entities.Common;
using Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class NhanVien : Person
    {
        [Required]
        public string Email { get; set; }
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
        public DiaChi DiaChi { get; set; }
        [Required]
        public bool Status { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
    }
}
