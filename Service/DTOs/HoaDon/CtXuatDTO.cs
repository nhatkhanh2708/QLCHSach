﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class CtXuatDTO : BaseDTO
    {
        [Required]
        public int SachId { get; set; }
        [Required]
        public int HdXuatId { get; set; }
        [Required]
        public int SoLuong { get; set; }
    }
}
