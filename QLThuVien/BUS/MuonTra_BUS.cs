using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class MuonTra_BUS
    {
        public static List<MuonTra_DTO> DanhSachMuonTra()
        {
            return MuonTra_DAO.DanhSachMuonTra();
        }

        public static int MuonSach(string _maDocGia, string _maSach, string _ngayMuon, string _ngayTra)
        {
            return MuonTra_DAO.MuonSach(_maDocGia, _maSach, _ngayMuon, _ngayTra);
        }

        public static int TraSach(string _maDocGia, string _maSach)
        {
            return MuonTra_DAO.TraSach(_maDocGia, _maSach);
        }
    }
}
