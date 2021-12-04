using Model.Entities;

namespace Model.IRepositories
{
    public interface INhanVienRepository : IRepository<NhanVien>
    {
        public int Add_ReturnId(NhanVien entity);
    }
}
