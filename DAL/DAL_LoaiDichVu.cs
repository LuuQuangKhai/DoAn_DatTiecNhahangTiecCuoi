using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using DTO;

namespace DAL
{

    public class DAL_LoaiDichVu
    {
        private HttpClient httpClient;

        public DAL_LoaiDichVu()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7267/");
        }


        public async Task<List<DTO_LoaiDichVu>> GetLoaiDichVuFormAPI()
        {
            List<DTO_LoaiDichVu> loaiDichVu = null;

            HttpResponseMessage response = await httpClient.GetAsync("/api/loai-dich-vu/get-all");
            if (response.IsSuccessStatusCode)
            {
                WrapperDTO_LoaiDichVu wrapper = await response.Content.ReadAsAsync<WrapperDTO_LoaiDichVu>();
                loaiDichVu = wrapper.Data;
            }

            return loaiDichVu;
        }

        public async Task<bool> AddLoaiDichVuToAPI(DTO_LoaiDichVu newItem)
        {
            try
            {
                string json = JsonConvert.SerializeObject(newItem);
                HttpContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await httpClient.PostAsync("/api/loai-dich-vu/add", content);
                response.EnsureSuccessStatusCode(); // Đảm bảo yêu cầu thành công

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine($"Lỗi trong quá trình thêm LoaiDichVu: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteItemFromAPI(string itemId)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"api/loai-dich-vu/delete/{itemId}");
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

        public async Task<bool> UpdateItemInAPI(DTO_LoaiDichVu dto)
        {
            string json = JsonConvert.SerializeObject(dto);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await httpClient.PutAsync($"api/loai-dich-vu/update/{dto.MaLoaiDichVu}", content);
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
                HttpResponseMessage response = await httpClient.GetAsync($"/api/loai-dich-vu/get-single/{ma}");
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
