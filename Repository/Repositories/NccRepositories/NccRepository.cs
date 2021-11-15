using Model.Entities;
using Model.IRepositories.INccRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.NccRepositories
{
    public class NccRepository : EFRepository<NhaCungCap>, INccRepository
    {
        public NccRepository(DatabaseContext context) : base(context) { }
    }
}
