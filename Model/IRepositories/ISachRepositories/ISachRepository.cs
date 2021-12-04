using Model.Entities;

namespace Model.IRepositories
{
    public interface ISachRepository : IRepository<Sach>
    {
        public int Add_ReturnId(Sach entity);
    }
}
