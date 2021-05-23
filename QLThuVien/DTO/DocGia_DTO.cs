using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia_DTO
    {
        private string sMaDocGia;
        private string sHoTen;
        private DateTime sNgaySinh;
        private string sGioiTinh;
        private string sDiaChi;
        private string sDienThoai;
        private string sEmail;
        private int sDaMuon;
        private int sDangMuon;

        public string SMaDocGia { get => sMaDocGia; set => sMaDocGia = value; }
        public string SHoTen { get => sHoTen; set => sHoTen = value; }
        public DateTime SNgaySinh { get => sNgaySinh; set => sNgaySinh = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SDienThoai { get => sDienThoai; set => sDienThoai = value; }
        public string SEmail { get => sEmail; set => sEmail = value; }
        public int SDaMuon { get => sDaMuon; set => sDaMuon = value; }
        public int SDangMuon { get => sDangMuon; set => sDangMuon = value; }
    }
}
