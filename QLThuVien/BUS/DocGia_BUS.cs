using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DocGia_BUS
    {
        public static int ThemDocGia(string _maDocGia, string _hoTen, DateTime _ngaySinh, string _gioiTinh, string _diaChi, string _dienThoai, string _email)
        {
            return DocGia_DAO.ThemDocGia(_maDocGia, _hoTen, _ngaySinh, _gioiTinh, _diaChi, _dienThoai, _email);
        }

        public static int SuaDocGia(string _maDocGia, string _hoTen, DateTime _ngaySinh, string _gioiTinh, string _diaChi, string _dienThoai, string _email)
        {
            return DocGia_DAO.SuaDocGia(_maDocGia, _hoTen, _ngaySinh, _gioiTinh, _diaChi, _dienThoai, _email);
        }

        public static int XoaDocGia(string _maDocGia)
        {
            return DocGia_DAO.XoaDocGia(_maDocGia);
        }

        public static List<DocGia_DTO> DanhSachDocGia()
        {
            return DocGia_DAO.DanhSachDocGia();
        }

        public static List<DocGia_DTO> DocGiaThoaDieuKien()
        {
            return DocGia_DAO.DocGiaThoaDieuKien();
        }

        public static List<DocGia_DTO> TimKiemDocGia(string _ten)
        {
            return DocGia_DAO.TimKiemDocGia(_ten);
        }

        public static bool KiemTraMaDocGia(string _maDocGia)
        {
            return DocGia_DAO.KiemTraMaDocGia(_maDocGia);
        }
    }
}
