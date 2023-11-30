using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DichVu
    {
        DAL_DichVu dal;

        public BLL_DichVu()
        {
            dal = new DAL_DichVu();
        }

        public async Task<List<DTO_DichVu>> GetLoaiDichVu()
        {
            return await dal.GetItemFormAPI();
        }

        public async Task<bool> AddLoaiDichVu(DTO_DichVu dto)
        {
            bool ketqua = await dal.AddItemToAPI(dto);
            return ketqua;
        }

        public async Task<bool> DeleteLoaiDichVu(string ma)
        {
            bool ketqua = await dal.DeleteItemFromAPI(ma);
            return ketqua;
        }

        public async Task<bool> UpdateLoaiDichVu(DTO_DichVu dto)
        {
            bool ketqua = await dal.UpdateItemInAPI(dto);
            return ketqua;
        }
    }
}
