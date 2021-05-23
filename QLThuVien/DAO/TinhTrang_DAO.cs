using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TinhTrang_DAO
    {
        public static List<TinhTrang_DTO> DanhSachTinhTrang()
        {
            string query = "SELECT * FROM TBL_TINHTRANG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            List<TinhTrang_DTO> lstTinhTrang = new List<TinhTrang_DTO>();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                TinhTrang_DTO tt = new TinhTrang_DTO();
                tt.SMaTinhTrang = dt.Rows[i]["MaTinhTrang"].ToString();
                tt.STenTinhTrang = dt.Rows[i]["TenTinhTrang"].ToString();

                lstTinhTrang.Add(tt);
            }

            return lstTinhTrang;
        }
    }
}
