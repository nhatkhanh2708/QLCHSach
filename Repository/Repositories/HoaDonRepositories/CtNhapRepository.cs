using Model.Entities;
using Model.IRepositories;

namespace Repository.Repositories.HoaDonRepositories
{
    public class CTNhapRepository: EFRepository<ChiTietNhap>, ICtNhapRepository
    {
        public CTNhapRepository(DatabaseContext context) : base(context) { }
    }
}
