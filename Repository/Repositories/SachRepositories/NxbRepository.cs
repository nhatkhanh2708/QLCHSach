﻿using Model.Entities;
using Model.IRepositories.ISachRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.SachRepositories
{
    public class NxbRepository : EFRepository<NhaXuatBan>, INxbRepository
    {
        public NxbRepository(DatabaseContext context) : base(context) { }

        public IEnumerable<NhaXuatBan> GetsByTenNXB(string tenNXB)
        {
            return _context.NhaXuatBans.Where(q => q.TenNxb.StartsWith(tenNXB)).ToList();
        }
    }
}
