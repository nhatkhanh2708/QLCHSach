﻿using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class TaiKhoan : BaseEntity
    {
        [Required]
        public int NhanVienId { get; set; }
        [Required]
        public int QuyenId { get; set; }
        [StringLength(100)]
        [Required]
        public string Username { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        [Required]
        public bool Status { get; set; }
        public Quyen Quyen { get; set; }
        public NhanVien nhanVien { get; set; }
        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
        public ICollection<HoaDonXuat> HoaDonXuats { get; set; }
    }
}
