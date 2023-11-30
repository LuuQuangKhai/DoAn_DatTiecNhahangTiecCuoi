using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiDichVu
    {
        public string MaLoaiDichVu { get; set; }
        public string TenLoaiDichVu { get; set; }
    }

    public class WrapperDTO_LoaiDichVu
    {
        public List<DTO_LoaiDichVu> Data { get; set; }
    }
}
