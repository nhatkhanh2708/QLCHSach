using Model.Entities.Common;
using Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class NhaCungCap : BaseEntity
    {
        [StringLength(60)]
        [Required]
        public string TenNCC { get; set; }
        public string VietTat { get; set; }
        [Required]
        public DiaChi DiaChi { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string SDT { get; set; }
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string NgayHopTac { get; set; }
        [Required]
        public bool Status { get; set; }
        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
    }
}
