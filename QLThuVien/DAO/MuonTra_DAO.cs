using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class MuonTra_DAO
    {
        public static List<MuonTra_DTO> DanhSachMuonTra()
        {
            string query = "SELECT * FROM TBL_MUONTRA";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count <= 0)
            {
                return null;
            }

            List<MuonTra_DTO> muonTra = new List<MuonTra_DTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                MuonTra_DTO mt = new MuonTra_DTO();
                mt.SMaDocGia = dt.Rows[i]["MaDocGia"].ToString();
                mt.SMaSach = dt.Rows[i]["MaSach"].ToString();
                mt.SNgayMuon = (DateTime)dt.Rows[i]["NgayMuon"];
                mt.SNgayTra = (DateTime)dt.Rows[i]["NgayTra"];

                muonTra.Add(mt);
            }

            return muonTra;
        }

        public static int MuonSach(string _maDocGia, string _maSach, string _ngayMuon, string _ngayTra)
        {
            string query = "EXEC Muon @MaDocGia , @MaSach , @NgayMuon , @NgayTra ";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maDocGia , _maSach, _ngayMuon, _ngayTra });

            return kq;
        }

        public static int TraSach(string _maDocGia, string _maSach)
        {
            string query = "EXEC Tra @MaDocGia , @MaSach ";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maDocGia, _maSach});

            return kq;
        }
    }
}
