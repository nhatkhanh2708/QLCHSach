﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
