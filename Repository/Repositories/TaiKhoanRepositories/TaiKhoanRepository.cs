using Model.Entities;
using Model.IRepositories.ITaiKhoanRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.TaiKhoanRepositories
{
    public class TaiKhoanRepository : EFRepository<TaiKhoan>, ITaiKhoanRepository
    {
        public TaiKhoanRepository(DatabaseContext context) : base(context) { }
    }
}
