using AutoMapper;
using Model.Entities;
using Service.DTOs;

namespace Service.Mapping
{
    public class Entity2DTOMapper : Profile
    {
        public Entity2DTOMapper()
        {
            CreateMap<ChiTietNhap, CtNhapDTO>();
            CreateMap<ChiTietXuat, CtXuatDTO>();
            CreateMap<HoaDonNhap, HdNhapDTO>();
            CreateMap<HoaDonXuat, HdXuatDTO>();
            CreateMap<NhaCungCap, NccDTO>();
            CreateMap<NhanVien, NhanVienDTO>();
            CreateMap<NhaXuatBan, NhaXuatBanDTO>();
            CreateMap<Sach, SachDTO>();
            CreateMap<SachTacGia, SachTacGiaDTO>();
            CreateMap<SachTheLoai, SachTheLoaiDTO>();
            CreateMap<TacGia, TacGiaDTO>();
            CreateMap<TheLoai, TheLoaiDTO>();
            CreateMap<Quyen, QuyenDTO>();
            CreateMap<TaiKhoan, TaiKhoanDTO>();
        }
    }
}
