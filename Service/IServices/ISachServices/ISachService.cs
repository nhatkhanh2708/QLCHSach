using Service.DTOs;
using System.Collections.Generic;

namespace Service.IServices
{
    public interface ISachService : IService<SachDTO>
    {
        public int AddSach(SachDTO s);
        public void UpdateStatus(int id);
        public IEnumerable<SachDTO> GetsByName_NccId(string sach, int nccId);
        public IEnumerable<SachDTO> GetsByName(string sach);
        public void UpdateSoLuong(int sachId, int soluong);
    }
}
