using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private string sTenDangNhap;
        private string sMatKhau;
        private string sTenNguoiDung;
        private string sMaQuyen;
        private string sMaNhanVien;

        public string STenDangNhap { get => sTenDangNhap; set => sTenDangNhap = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
        public string STenNguoiDung { get => sTenNguoiDung; set => sTenNguoiDung = value; }
        public string SMaQuyen { get => sMaQuyen; set => sMaQuyen = value; }
        public string SMaNhanVien { get => sMaNhanVien; set => sMaNhanVien = value; }
    }
}
