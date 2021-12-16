using Model.Entities;
using System.Collections.Generic;

namespace Model.IRepositories
{
    public interface ISachRepository : IRepository<Sach>
    {
        public int Add_ReturnId(Sach entity);
        public IEnumerable<Sach> GetsByName_NccId(string sach, int nccId);
        public IEnumerable<Sach> GetsByName(string sach);
    }
}
