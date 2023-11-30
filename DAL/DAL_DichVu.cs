using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DTO;
using System.Net.Http.Headers;

namespace DAL
{
    public class DAL_DichVu
    {
        private HttpClient httpClient;

        public DAL_DichVu()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7267/");
        }


        public async Task<List<DTO_DichVu>> GetItemFormAPI()
        {
            List<DTO_DichVu> list = null;

            HttpResponseMessage response = await httpClient.GetAsync("/api/dich-vu/get-all");
            if (response.IsSuccessStatusCode)
            {
                WrapperDTO_DichVu wrapper = await response.Content.ReadAsAsync<WrapperDTO_DichVu>();
                list = wrapper.Data;
            }

            return list;
        }

        public async Task<bool> AddItemToAPI(DTO_DichVu newItem)
        {
            try
            {
                string json = JsonConvert.SerializeObject(newItem);
                HttpContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await httpClient.PostAsync("/api/dich-vu/add", content);
                response.EnsureSuccessStatusCode(); // Đảm bảo yêu cầu thành công

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                return false;
            }
        }

        public async Task<bool> DeleteItemFromAPI(string itemId)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"api/dich-vu/delete/{itemId}");
            if (response.IsSuccessStatusCode)
            {
                // Xử lý khi xóa dữ liệu thành công
                return true;
            }
            else
            {
                // Xử lý lỗi khi không xóa được dữ liệu từ API
                return false;
            }
        }

        public async Task<bool> UpdateItemInAPI(DTO_DichVu dto)
        {
            string json = JsonConvert.SerializeObject(dto);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await httpClient.PutAsync($"api/dich-vu/update/{dto.MaDichVu}", content);
            if (response.IsSuccessStatusCode)
            {
                // Xử lý khi cập nhật dữ liệu thành công
                return true;
            }
            else
            {
                // Xử lý lỗi khi không cập nhật được dữ liệu trong API
                return false;
            }
        }

        public async Task<bool> FindItemInAPI(string ma)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"/api/dich-vu/get-single/{ma}");
                response.EnsureSuccessStatusCode(); // Đảm bảo yêu cầu thành công

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                return false;
            }
        }
    }
}
