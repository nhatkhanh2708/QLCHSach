using Model.Entities;

namespace Model.IRepositories
{
    public interface IQuyenRepository : IRepository<Quyen>
    {
        Quyen GetsByTen(string tenquyen);
        Quyen GetsByMoTa(string mota);
    }
}
