using AutoMapper;
using Model.Entities;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

        }


        //Mapping Nxb
      /*  #region
        public NhaXuatBanDTO MappingDTO(this NhaXuatBan entity)
        {
            
            return new NhaXuatBanDTO
            {
                Id = entity.Id,
                TenNxb = entity.TenNxb,
                VietTat = entity.VietTat
            };
        }
        public NhaXuatBan MappingEntity(this NhaXuatBanDTO dto)
        {
            return new NhaXuatBan
            {
                Id = dto.Id,
                TenNxb = dto.TenNxb,
                VietTat = dto.VietTat
            };
        }
        public void MappingEntity(this NhaXuatBanDTO dto, NhaXuatBan entity)
        {
            entity.Id = dto.Id;
            entity.TenNxb = dto.TenNxb;
            entity.VietTat = dto.VietTat;
        }
        public IEnumerable<NhaXuatBanDTO> MappingDTOs(this IEnumerable<NhaXuatBan> entities)
        {
            foreach(var entity in entities)
            {
                //yield return entity.MappingDTO();
            }
        }
        #endregion
      */
        //
    }
}
