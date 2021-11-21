using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs
{
    public class SachDTO : BaseDTO 
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
        [DefaultValue(0)]
        public int SoLuong { get; set; }

        [Required]
        public bool Status { get; set; }

        public ICollection<SachTheLoaiDTO> SachTheLoais { get; set; }
        public ICollection<SachTacGiaDTO> SachTacGias { get; set; }
    }
}
