using Model.Entities.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class Sach : BaseEntity
    {
        [StringLength(100)]
        public string TenSach { get; set; }

        [Required]
        public int NxbId { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal GiaNhap { get; set; }

        [DefaultValue(0)]
        [Required]
        public decimal GiaBan { get; set; }

        [Required]
        [DefaultValue(0)]
        public int SoLuong { get; set; }

        public byte[] Img { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public int NccId { get; set; }

        public NhaXuatBan Nxb { get; set; }


        public ICollection<SachTheLoai> SachTheLoais { get; set; }
        public ICollection<SachTacGia> SachTacGias { get; set; }
        public ICollection<ChiTietNhap> ChiTietNhaps { get; set; }
        public ICollection<ChiTietXuat> ChiTietXuats { get; set; }

        public Sach()
        {
            SachTheLoais = new Collection<SachTheLoai>();
            SachTacGias = new Collection<SachTacGia>();
        }
    }
}