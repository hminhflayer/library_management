using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TaiKhoan_DAO
    {
        public static TaiKhoan_DTO Login(string _TenDangNhap, string _MatKhau)
        {
            string query = string.Format(@"select * from TBL_TAIKHOAN where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau");

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {_TenDangNhap,_MatKhau});

            if(dt.Rows.Count == 0)
            {
                return null;
            }    

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.STenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
            tk.SMatKhau = dt.Rows[0]["MatKhau"].ToString();
            tk.STenNguoiDung = dt.Rows[0]["TenNguoiDung"].ToString();
            tk.SMaQuyen = dt.Rows[0]["MaQuyen"].ToString();

            return tk;
        }

        public static List<TaiKhoan_DTO> DanhSachTaiKhoan()
        {
            string query = string.Format(@"SELECT * FROM TBL_TAIKHOAN");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<TaiKhoan_DTO> tk = new List<TaiKhoan_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO taiKhoan = new TaiKhoan_DTO();
                taiKhoan.STenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                taiKhoan.SMatKhau = dt.Rows[i]["MatKhau"].ToString();
                taiKhoan.STenNguoiDung = dt.Rows[i]["TenNguoiDung"].ToString();
                taiKhoan.SMaQuyen = dt.Rows[i]["MaQuyen"].ToString();
                taiKhoan.SMaNhanVien = dt.Rows[i]["MaNhanVien"].ToString();
                
                tk.Add(taiKhoan);
            }
            return tk;
        }

        public static int ThemTaiKhoan(string _tenDangNhap, string _matKhau, string _tenNguoiDung, string _maQuyen, string _maNhanVien)
        {
            string query = "INSERT INTO TBL_TAIKHOAN VALUES( @TenDangNhap , @MatKhau , @TenNguoiDung , @MaQuyen , @MaNhanVien )";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _tenDangNhap, _matKhau, _tenNguoiDung, _maQuyen, _maNhanVien });
            return kq;
        }

        public static int XoaTaiKhoan(string _tenDangNhap)
        {
            string query = "DELETE FROM TBL_TAIKHOAN WHERE TenDangNhap = @TenDangNhap";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _tenDangNhap });
            return kq;
        }

        public static int SuaTaiKhoan(string _tenDangNhap , string _tenNguoiDung, string _maQuyen)
        {
            string query = "UPDATE TBL_TAIKHOAN SET TenNguoiDung = @TenNguoiDung , MaQuyen = @MaQuyen WHERE TenDangNhap = @TenDangNhap";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _tenNguoiDung, _maQuyen, _tenDangNhap});
            return kq;
        }

        public static int CapLaiMatKhau(string _tenDangNhap)
        {
            string query = "UPDATE TBL_TAIKHOAN SET MatKhau = 'c4ca4238a0b923820dcc509a6f75849b' WHERE TenDangNhap = @TenDangNhap";

            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _tenDangNhap });
            return kq;
        }

        public static List<TaiKhoan_DTO> TimKiem(string _tenDangNhap)
        {
            string query = string.Format(@"SELECT * FROM TBL_TAIKHOAN WHERE TenDangNhap = @TenDangNhap");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { _tenDangNhap});

            List<TaiKhoan_DTO> tk = new List<TaiKhoan_DTO>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO taiKhoan = new TaiKhoan_DTO();
                taiKhoan.STenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                taiKhoan.SMatKhau = dt.Rows[i]["MatKhau"].ToString();
                taiKhoan.STenNguoiDung = dt.Rows[i]["TenNguoiDung"].ToString();
                taiKhoan.SMaQuyen = dt.Rows[i]["MaQuyen"].ToString();
                taiKhoan.SMaNhanVien = dt.Rows[i]["MaNhanVien"].ToString();

                tk.Add(taiKhoan);
            }
            return tk;
        }

        public static bool KiemTraTrungDuLieu(string _tenDangNhap)
        {
            string query = string.Format(@"SELECT * FROM TBL_TAIKHOAN WHERE TenDangNhap = @TenDangNhap");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { _tenDangNhap });

            if(dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public static bool DoiMatKhau(string _tenDangNhap, string _matKhau, string _matKhauMoi)
        {
            string query = "SELECT * FROM TBL_TAIKHOAN WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau ";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { _tenDangNhap , _matKhau });
            
            if(dt.Rows.Count > 0)
            {
                string queryUp = "UPDATE TBL_TAIKHOAN SET MatKhau = @MatKhauMoi WHERE TenDangNhap = @TenDangNhap ";

                int kq = DataProvider.Instance.ExecuteNonQuery(queryUp, new object[] { _matKhauMoi, _tenDangNhap });
                return (kq>0)?true:false;
            }    

            return false;
        }
    }
}
