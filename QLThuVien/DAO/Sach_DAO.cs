using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class Sach_DAO
    {
        public static List<Sach_DTO> DanhSachSach()
        {
            string query = "SELECT * FROM TBL_SACH";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if(dt.Rows.Count == 0)
            {
                return null;
            }

            List<Sach_DTO> lstSach = new List<Sach_DTO>();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Sach_DTO sach = new Sach_DTO();
                sach.SMaSach = dt.Rows[i]["MaSach"].ToString();
                sach.SMaLoai = dt.Rows[i]["MaLoai"].ToString();
                sach.STenSach = dt.Rows[i]["TenSach"].ToString();
                sach.STacGia = dt.Rows[i]["TacGia"].ToString();
                sach.SXuatBan = dt.Rows[i]["XuatBan"].ToString();
                sach.SNoiLuu = dt.Rows[i]["NoiLuu"].ToString();
                sach.STrangThai = (bool)(dt.Rows[i]["TrangThai"]);
                sach.SMaTinhTrang = dt.Rows[i]["MaTinhTrang"].ToString();

                lstSach.Add(sach);
            }

            return lstSach;
        }

        public static List<Sach_DTO> SachSanCo()
        {
            string query = "SELECT * FROM TBL_SACH WHERE TrangThai = 1";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Sach_DTO> lstSach = new List<Sach_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Sach_DTO sach = new Sach_DTO();
                sach.SMaSach = dt.Rows[i]["MaSach"].ToString();
                sach.SMaLoai = dt.Rows[i]["MaLoai"].ToString();
                sach.STenSach = dt.Rows[i]["TenSach"].ToString();
                sach.STacGia = dt.Rows[i]["TacGia"].ToString();
                sach.SXuatBan = dt.Rows[i]["XuatBan"].ToString();
                sach.SNoiLuu = dt.Rows[i]["NoiLuu"].ToString();
                sach.STrangThai = (bool)(dt.Rows[i]["TrangThai"]);
                sach.SMaTinhTrang = dt.Rows[i]["MaTinhTrang"].ToString();

                lstSach.Add(sach);
            }

            return lstSach;
        }

        public static bool KiemTraTrungKhoaChinh(string _maSach)
        {
            string query = "SELECT *FROM TBL_SACH WHERE MaSach = @MaSach ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { _maSach });

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static int ThemSach(string _maSach, string _maLoai, string _tenSach, string _tacGia, string _xuatBan, string _noiLuu, string _maTinhTrang)
        {
            string query = "INSERT INTO TBL_SACH VALUES( @MaSach , @MaLoai , @TenSach , @TacGia , @XuatBan , @NoiLuu , 1 , @MaTinhTrang )";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maSach , _maLoai , _tenSach , _tacGia , _xuatBan , _noiLuu , _maTinhTrang });
            return kq;
        }

        public static int XoaSach(string _maSach)
        {
            string query = "DELETE FROM TBL_SACH WHERE MaSach = @MaSach";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maSach });

            return kq;
        }

        public static int SuaSach(string _maSach, string _maLoai, string _tenSach, string _tacGia, string _xuatBan, string _noiLuu, string _maTinhTrang, int _trangThai)
        {
            string query = "UPDATE TBL_SACH SET MaLoai = @MaLoai , TenSach = @TenSach , TacGia = @TacGia , XuatBan = @XuatBan , NoiLuu = @NoiLuu , MaTinhTrang = @MaTinhTrang , TrangThai = @TrangThai WHERE MaSach = @MaSach";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maLoai , _tenSach , _tacGia , _xuatBan , _noiLuu , _maTinhTrang , _trangThai , _maSach });

            return kq;
        }

        public static List<Sach_DTO> TimKiemSach(string _ten)
        {
            string query = "SELECT * FROM TBL_SACH TenSach WHERE TenSach like N'%"+_ten+"%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Sach_DTO> lstSach = new List<Sach_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Sach_DTO sach = new Sach_DTO();
                sach.SMaSach = dt.Rows[i]["MaSach"].ToString();
                sach.SMaLoai = dt.Rows[i]["MaLoai"].ToString();
                sach.STenSach = dt.Rows[i]["TenSach"].ToString();
                sach.STacGia = dt.Rows[i]["TacGia"].ToString();
                sach.SXuatBan = dt.Rows[i]["XuatBan"].ToString();
                sach.SNoiLuu = dt.Rows[i]["NoiLuu"].ToString();
                sach.STrangThai = (bool)(dt.Rows[i]["TrangThai"]);
                sach.SMaTinhTrang = dt.Rows[i]["MaTinhTrang"].ToString();

                lstSach.Add(sach);
            }

            return lstSach;
        }
    }
}
