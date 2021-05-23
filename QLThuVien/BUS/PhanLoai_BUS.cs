using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class PhanLoai_BUS
    {
        public static List<PhanLoai_DTO> DanhSachPhanLoai()
        {
            return PhanLoai_DAO.DanhSachPhanLoai();
        }

        public static int ThemPhanLoai(string _maLoai, string _tenLoai)
        {
            return PhanLoai_DAO.ThemPhanLoai(_maLoai, _tenLoai);
        }

        public static int XoaPhanLoai(string _maLoai)
        {
            return PhanLoai_DAO.XoaPhanLoai(_maLoai);
        }

        public static int SuaPhanLoai(string _maLoai, string _tenLoai)
        {
            return PhanLoai_DAO.SuaPhanLoai(_maLoai, _tenLoai);
        }

        public static bool KiemTraTrungKhoaChinh(string _maLoai)
        {
            return PhanLoai_DAO.KiemTraTrungKhoaChinh(_maLoai);
        }
    }
}
