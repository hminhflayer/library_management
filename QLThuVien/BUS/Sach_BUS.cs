using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class Sach_BUS
    {
        public static List<Sach_DTO> DanhSachSach()
        {
            return Sach_DAO.DanhSachSach();
        }

        public static List<Sach_DTO> TimKiemSach(string _ten)
        {
            return Sach_DAO.TimKiemSach(_ten);
        }

        public static List<Sach_DTO> SachSanCo()
        {
            return Sach_DAO.SachSanCo();
        }

        public static bool KiemTraTrungKhoaChinh(string _maSach)
        {
            return Sach_DAO.KiemTraTrungKhoaChinh(_maSach);
        }

        public static int ThemSach(string _maSach, string _maLoai, string _tenSach, string _tacGia, string _xuatBan, string _noiLuu, string _maTinhTrang)
        {
            return Sach_DAO.ThemSach(_maSach, _maLoai, _tenSach, _tacGia, _xuatBan, _noiLuu, _maTinhTrang);
        }

        public static int XoaSach(string _maSach)
        {
            return Sach_DAO.XoaSach(_maSach);
        }

        public static int SuaSach(string _maSach, string _maLoai, string _tenSach, string _tacGia, string _xuatBan, string _noiLuu, string _maTinhTrang, int _trangThai)
        {
            return Sach_DAO.SuaSach( _maSach, _maLoai, _tenSach, _tacGia, _xuatBan, _noiLuu, _maTinhTrang, _trangThai);
        }
    }
}
