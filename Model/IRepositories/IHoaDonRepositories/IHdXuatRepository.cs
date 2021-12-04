using Model.Entities;

namespace Model.IRepositories
{
    public interface IHdXuatRepository : IRepository<HoaDonXuat>
    {
        public int Add_ReturnId(HoaDonXuat entity);
    }
}
