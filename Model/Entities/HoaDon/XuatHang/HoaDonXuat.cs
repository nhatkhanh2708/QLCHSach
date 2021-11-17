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
    public class HoaDonXuat : BaseEntity
    {
        [Required]
        public int TaiKhoanId { get; set; }
        [DefaultValue(0)]
        [Required]
        public decimal TongTien { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime NgayTao { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public ICollection<ChiTietXuat> ChiTietXuats { get; set; }
        
        public HoaDonXuat()
        {
            ChiTietXuats = new Collection<ChiTietXuat>();
        }
    }
}
