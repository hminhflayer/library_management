using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach_DTO
    {
        private string sMaSach;
        private string sMaLoai;
        private string sTenSach;
        private string sTacGia;
        private string sXuatBan;
        private string sNoiLuu;
        private bool sTrangThai;
        private string sMaTinhTrang;

        public string SMaSach { get => sMaSach; set => sMaSach = value; }
        public string SMaLoai { get => sMaLoai; set => sMaLoai = value; }
        public string STenSach { get => sTenSach; set => sTenSach = value; }
        public string STacGia { get => sTacGia; set => sTacGia = value; }
        public string SXuatBan { get => sXuatBan; set => sXuatBan = value; }
        public string SNoiLuu { get => sNoiLuu; set => sNoiLuu = value; }
        public bool STrangThai { get => sTrangThai; set => sTrangThai = value; }
        public string SMaTinhTrang { get => sMaTinhTrang; set => sMaTinhTrang = value; }
    }
}
