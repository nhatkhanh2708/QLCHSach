using Model.Entities.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model.Entities
{
    public class HoaDonNhap : BaseEntity 
    {
        [Required]
        public int TaiKhoanId { get; set; }
        [Required]
        public int NccId { get; set; }
        [DefaultValue(0)]
        [Required]
        public decimal TongTien { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime NgayTao { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public NhaCungCap NCC { get; set; }
        public ICollection<ChiTietNhap> ChiTietNhaps { get; set; }

        public HoaDonNhap()
        {
            ChiTietNhaps = new Collection<ChiTietNhap>();
        }
    }
}
