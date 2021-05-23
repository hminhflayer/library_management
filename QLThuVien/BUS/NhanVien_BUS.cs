using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;


namespace BUS
{
    public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> DanhSachNhanVien()
        {
            return NhanVien_DAO.DanhSachNhanVien();
        }

        public static List<NhanVien_DTO> DanhSachNhanVienChuaCoTaiKhoan()
        {
            return NhanVien_DAO.DanhSachNhanVienChuaCoTaiKhoan();
        }

        public static List<NhanVien_DTO> DanhSachNhanVienDaCoTaiKhoan()
        {
            return NhanVien_DAO.DanhSachNhanVienDaCoTaiKhoan();
        }

        public static bool KiemTraTrungKhoaChinh(string _maNhanVien)
        {
            return NhanVien_DAO.KiemTraTrungKhoaChinh(_maNhanVien);
        }

        public static int ThemNhanVien(string _maNhanVien, string _hoTen, DateTime _ngaySinh, string _gioiTinh)
        {
            return NhanVien_DAO.ThemNhanVien(_maNhanVien, _hoTen, _ngaySinh, _gioiTinh );
        }

        public static int XoaNhanVien(string _maNhanVien)
        {
            return NhanVien_DAO.XoaNhanVien(_maNhanVien);
        }

        public static int SuaNhanVien(string _maNhanVien, string _hoTen, DateTime _ngaySinh, string _gioiTinh)
        {
            return NhanVien_DAO.SuaNhanVien(_maNhanVien, _hoTen, _ngaySinh, _gioiTinh);
        }
    }
}
