using Model.Entities;
using Model.IRepositories.ISachRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.SachRepositories
{
    public class SachTacGiaRepository : EFRepository<SachTacGia>, ISachTacGiaRepository
    {
        public SachTacGiaRepository(DatabaseContext context) : base(context) { }
    }
}
