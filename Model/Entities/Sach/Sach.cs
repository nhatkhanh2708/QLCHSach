using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Sach : BaseEntity
    {
        [StringLength(100)]
        public string TenSach { get; set; }
        [Required]
        public string MaSach { get; set; }
        [Required]
        public int NxbId { get; set; }
        public byte[] Thumbnail { get; set; }
        [DefaultValue(0)]
        [Required]
        public decimal GiaNhap { get; set; }
        [DefaultValue(0)]
        [Required]
        public decimal GiaBan { get; set; }
        [Required]
        public bool Status { get; set; }

        public NhaXuatBan Nxb { get; set; }
        public ICollection<SachTheLoai> SachTheLoais { get; set; }
        public ICollection<SachTacGia> SachTacGias { get; set; }
        public ICollection<ChiTietNhap> ChiTietNhaps { get; set; }
        public ICollection<ChiTietXuat> ChiTietXuats { get; set; }
    }
}
