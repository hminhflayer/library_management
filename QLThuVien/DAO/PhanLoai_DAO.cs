using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhanLoai_DAO
    {
        public static List<PhanLoai_DTO> DanhSachPhanLoai()
        {
            string query = "SELECT * FROM TBL_PHANLOAI";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<PhanLoai_DTO> phanLoai = new List<PhanLoai_DTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                PhanLoai_DTO pl = new PhanLoai_DTO();
                pl.SMaLoai = dt.Rows[i]["MaLoai"].ToString();
                pl.STenLoai = dt.Rows[i]["TenLoai"].ToString();

                phanLoai.Add(pl);
            }

            return phanLoai;
        }

        public static int ThemPhanLoai(string _maLoai, string _tenLoai)
        {
            string query = "INSERT INTO TBL_PHANLOAI VALUES( @MaLoai , @TenLoai )";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maLoai, _tenLoai });
            return kq;
        }

        public static int XoaPhanLoai(string _maLoai)
        {
            string query = "DELETE FROM TBL_PHANLOAI WHERE MaLoai = @MaLoai";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maLoai });

            return kq;
        }

        public static int SuaPhanLoai(string _maLoai, string _tenLoai)
        {
            string query = "UPDATE TBL_PHANLOAI SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _tenLoai, _maLoai});

            return kq;
        }

        public static bool KiemTraTrungKhoaChinh(string _maLoai)
        {
            string query = "SELECT * FROM TBL_PHANLOAI WHERE MaLoai = @MaLoai ";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query,new object[] { _maLoai });

            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
