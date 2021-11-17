using AutoMapper;
using Model.Entities;
using Service.DTOs;

namespace Service.Mapping
{
    public class DTO2EntityMapper : Profile
    {
        public DTO2EntityMapper()
        {
            CreateMap<CtNhapDTO, ChiTietNhap>();
            CreateMap<CtXuatDTO, ChiTietXuat>();
            CreateMap<HdNhapDTO, HoaDonNhap>();
            CreateMap<HdXuatDTO, HoaDonXuat>();
            CreateMap<NccDTO, NhaCungCap>();
            CreateMap<NhanVienDTO, NhanVien>();
            CreateMap<NhaXuatBanDTO, NhaXuatBan>();
            CreateMap<SachDTO, Sach>();
            CreateMap<SachTacGiaDTO, SachTacGia>();
            CreateMap<SachTheLoaiDTO, SachTheLoai>();
            CreateMap<TacGiaDTO, TacGia>();
            CreateMap<TheLoaiDTO, TheLoai>();
            CreateMap<QuyenDTO, Quyen>();
            CreateMap<TaiKhoanDTO, TaiKhoan>();
        }
    }
}
