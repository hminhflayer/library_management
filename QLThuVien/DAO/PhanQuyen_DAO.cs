using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhanQuyen_DAO
    {
        public static List<PhanQuyen_DTO> DanhSachPhanQuyen()
        {
            string query = string.Format(@"SELECT * FROM TBL_PHANQUYEN");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<PhanQuyen_DTO> phanQuyen = new List<PhanQuyen_DTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                PhanQuyen_DTO pq = new PhanQuyen_DTO();
                pq.SMaQuyen = dt.Rows[i]["MaQuyen"].ToString();
                pq.STenQuyen = dt.Rows[i]["TenQuyen"].ToString();

                phanQuyen.Add(pq);
            }

            return phanQuyen;
        }
    }
}
