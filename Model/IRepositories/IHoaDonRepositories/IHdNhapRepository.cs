using Model.Entities;

namespace Model.IRepositories
{
    public interface IHdNhapRepository : IRepository<HoaDonNhap>
    {
        public int Add_ReturnId(HoaDonNhap entity);
    }
}
