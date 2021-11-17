using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories.NccRepositories
{
    public class NccRepository : EFRepository<NhaCungCap>, INccRepository
    {
        public NccRepository(DatabaseContext context) : base(context) { }
    }
}
