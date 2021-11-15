using Model.Entities;
using Model.IRepositories.ITaiKhoanRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.TaiKhoanRepositories
{
    public class QuyenRepository : EFRepository<Quyen>, IQuyenRepository
    {
        public QuyenRepository(DatabaseContext context) : base(context) { }
    }
}
