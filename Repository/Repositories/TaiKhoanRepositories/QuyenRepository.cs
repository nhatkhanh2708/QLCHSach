using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories
{
    public class QuyenRepository : EFRepository<Quyen>, IQuyenRepository
    {
        public QuyenRepository(DatabaseContext context) : base(context) { }
    }
}
