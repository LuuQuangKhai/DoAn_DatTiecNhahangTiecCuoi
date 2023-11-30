using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DichVu
    {
        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public string HinhAnh { get; set; }
        public string MaLoaiDichVu { get; set; }
    }

    public class WrapperDTO_DichVu
    {
        public List<DTO_DichVu> Data { get; set; }
    }
}
