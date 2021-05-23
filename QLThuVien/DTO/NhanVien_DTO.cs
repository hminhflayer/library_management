using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string sMaNhanVien;
        private string sHoTen;
        private DateTime sNgaySinh;
        private string sGioiTinh;

        public string SMaNhanVien { get => sMaNhanVien; set => sMaNhanVien = value; }
        public string SHoTen { get => sHoTen; set => sHoTen = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public DateTime SNgaySinh { get => sNgaySinh; set => sNgaySinh = value; }
    }
}
