using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVien_DAO
    {
        public static List<NhanVien_DTO> DanhSachNhanVien()
        {
            string query = "SELECT * FROM TBL_NHANVIEN";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<NhanVien_DTO> nhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNhanVien = dt.Rows[i]["MaNhanVien"].ToString();
                nv.SHoTen = dt.Rows[i]["HoTen"].ToString();
                nv.SNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();

                nhanVien.Add(nv);
            }    
            
            return nhanVien;
        }

        public static List<NhanVien_DTO> DanhSachNhanVienChuaCoTaiKhoan()
        {
            string query = "SELECT * FROM TBL_NHANVIEN WHERE MaNhanVien NOT IN (SELECT MaNhanVien FROM TBL_TAIKHOAN)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<NhanVien_DTO> nhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNhanVien = dt.Rows[i]["MaNhanVien"].ToString();
                nv.SHoTen = dt.Rows[i]["HoTen"].ToString();

                nv.SNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();

                nhanVien.Add(nv);
            }

            return nhanVien;
        }

        public static List<NhanVien_DTO> DanhSachNhanVienDaCoTaiKhoan()
        {
            string query = "SELECT * FROM TBL_NHANVIEN n, TBL_TAIKHOAN t WHERE n.MaNhanVien = t.MaNhanVien";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            List<NhanVien_DTO> nhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNhanVien = dt.Rows[i]["MaNhanVien"].ToString();
                nv.SHoTen = dt.Rows[i]["HoTen"].ToString();
                nv.SNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();

                nhanVien.Add(nv);
            }

            return nhanVien;
        }

        public static bool KiemTraTrungKhoaChinh(string _maNhanVien)
        {
            string query = "SELECT *FROM TBL_NHANVIEN WHERE MaNhanVien = @MaNhanVien ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { _maNhanVien });

            if(dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static int ThemNhanVien(string _maNhanVien, string _hoTen, DateTime _ngaySinh, string _gioiTinh)
        {
            string query = "INSERT INTO TBL_NHANVIEN VALUES( @MaNhanVien , @HoTen , @NgaySinh , @GioiTinh )";
            int kq = DataProvider.Instance.ExecuteNonQuery(query,new object[] { _maNhanVien, _hoTen, _ngaySinh, _gioiTinh });
            return kq;
        }

        public static int XoaNhanVien(string _maNhanVien)
        {
            string query = "DELETE FROM TBL_NHANVIEN WHERE MaNhanVien = @MaNhanVien";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maNhanVien });
            return kq;
        }

        public static int SuaNhanVien(string _maNhanVien, string _hoTen, DateTime _ngaySinh, string _gioiTinh)
        {
            string query = "UPDATE TBL_NHANVIEN SET HoTen = @HoTen , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh WHERE MaNhanVien = @MaNhanVien ";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _hoTen, _ngaySinh, _gioiTinh, _maNhanVien });
            return kq;
        }
    }
}
