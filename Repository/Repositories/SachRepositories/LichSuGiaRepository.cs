using Model.Entities.Sach;
using Model.IRepositories.ISachRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.SachRepositories
{
    public class LichSuGiaRepository : EFRepository<LichSuGia>, ILichSuGiaRepository
    {
        public LichSuGiaRepository(DatabaseContext context) : base(context) { }
    }
}
