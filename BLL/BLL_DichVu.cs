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

        public async Task<List<DTO_DichVu>> GetAll()
        {
            return await dal.GetItemFormAPI();
        }

        public async Task<bool> Add(DTO_DichVu dto)
        {
            bool ketqua = await dal.AddItemToAPI(dto);
            return ketqua;
        }

        public async Task<bool> Delete(string ma)
        {
            bool ketqua = await dal.DeleteItemFromAPI(ma);
            return ketqua;
        }

        public async Task<bool> Update(DTO_DichVu dto)
        {
            bool ketqua = await dal.UpdateItemInAPI(dto);
            return ketqua;
        }

        public async Task<bool> Find(string ma)
        {
            return await dal.FindItemInAPI(ma);
        }
    }
}
