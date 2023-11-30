using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_LoaiDichVu
    {
        DAL_LoaiDichVu dal;

        public BLL_LoaiDichVu()
        {
            dal = new DAL_LoaiDichVu();
        }

        public async Task<List<DTO_LoaiDichVu>> GetLoaiDichVu()
        {
            return await dal.GetLoaiDichVuFormAPI();
        }

        public async Task<bool> AddLoaiDichVu(DTO_LoaiDichVu dto)
        {
            bool success = await dal.AddLoaiDichVuToAPI(dto);
            return success;
        }

        public async Task<bool> DeleteLoaiDichVu(string maloaidichvu)
        {
            bool ketqua = await dal.DeleteItemFromAPI(maloaidichvu);
            return ketqua;
        }

        public async Task<bool> UpdateLoaiDichVu(DTO_LoaiDichVu dto)
        {
            bool ketqua = await dal.UpdateItemInAPI(dto);
            return ketqua;
        }

        public async Task<bool> FindLoaiDichVu(string ma)
        {
            return await dal.FindItemInAPI(ma);
        }
    }
}
