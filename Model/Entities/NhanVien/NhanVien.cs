using Model.Entities.Common;
using Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class NhanVien : Person
    {
        public string Email { get; set; }
        public string SDT { get; set; }
        public DateTime NgayBatDau { get; set; }
        public string ChucVu { get; set; }
        public DiaChi DiaChi { get; set; }
        public bool Status { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
    }
}
