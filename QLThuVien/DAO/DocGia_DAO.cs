using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DocGia_DAO
    {
        public static List<DocGia_DTO> DanhSachDocGia()
        {
            string query = "SELECT * FROM TBL_DOCGIA";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if(dt.Rows.Count == 0)
            {
                return null;
            }

            List<DocGia_DTO> docGia = new List<DocGia_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DocGia_DTO dg = new DocGia_DTO();
                dg.SMaDocGia = dt.Rows[i]["MaDocGia"].ToString();
                dg.SHoTen    = dt.Rows[i]["HoTen"].ToString();
                dg.SNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                dg.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                dg.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                dg.SDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                dg.SEmail = dt.Rows[i]["Email"].ToString();
                dg.SDaMuon = int.Parse(dt.Rows[i]["DaMuon"].ToString());
                dg.SDangMuon = int.Parse(dt.Rows[i]["DangMuon"].ToString());

                docGia.Add(dg);
            }

            return docGia;
        }

        public static List<DocGia_DTO> DocGiaThoaDieuKien()
        {
            string query = "SELECT * FROM TBL_DOCGIA WHERE DangMuon < 4";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<DocGia_DTO> docGia = new List<DocGia_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DocGia_DTO dg = new DocGia_DTO();
                dg.SMaDocGia = dt.Rows[i]["MaDocGia"].ToString();
                dg.SHoTen = dt.Rows[i]["HoTen"].ToString();
                dg.SNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                dg.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                dg.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                dg.SDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                dg.SEmail = dt.Rows[i]["Email"].ToString();
                dg.SDaMuon = int.Parse(dt.Rows[i]["DaMuon"].ToString());
                dg.SDangMuon = int.Parse(dt.Rows[i]["DangMuon"].ToString());

                docGia.Add(dg);
            }

            return docGia;
        }

        public static bool KiemTraMaDocGia(string _maDocGia)
        {
            string query = "SELECT * FROM TBL_DOCGIA WHERE MaDocGia = @MaDocGia ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { _maDocGia });

            if(dt.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

        public static int ThemDocGia(string _maDocGia, string _hoTen, DateTime _ngaySinh, string _gioiTinh, string _diaChi, string _dienThoai, string _email)
        {
            string query = "INSERT INTO TBL_DOCGIA VALUES( @MaDocGia , @HoTen , @NgaySinh , @GioiTinh , @DiaChi , @DienThoai , @Email , 0 , 0 )";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maDocGia, _hoTen, _ngaySinh, _gioiTinh, _diaChi, _dienThoai, _email });
            return kq;
        }

        public static int XoaDocGia(string _maDocGia)
        {
            string query = "DELETE FROM TBL_DOCGIA WHERE MaDocGia = @MaDocGia";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _maDocGia });
            return kq;
        }

        public static int SuaDocGia(string _maDocGia, string _hoTen, DateTime _ngaySinh, string _gioiTinh, string _diaChi, string _dienThoai, string _email)
        {
            string query = "UPDATE TBL_DOCGIA SET HoTen = @HoTen , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , DiaChi = @DiaChi , SoDienThoai = @SoDienThoai , Email = @Email WHERE MaDocGIa = @MaDocGia ";
            int kq = DataProvider.Instance.ExecuteNonQuery(query, new object[] { _hoTen, _ngaySinh, _gioiTinh, _diaChi, _dienThoai, _email, _maDocGia });
            return kq;
        }

        public static List<DocGia_DTO> TimKiemDocGia(string _ten)
        {
            string query = "SELECT * FROM TBL_DOCGIA WHERE HoTen Like N'%"+_ten+"%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<DocGia_DTO> docGia = new List<DocGia_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DocGia_DTO dg = new DocGia_DTO();
                dg.SMaDocGia = dt.Rows[i]["MaDocGia"].ToString();
                dg.SHoTen = dt.Rows[i]["HoTen"].ToString();
                dg.SNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                dg.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                dg.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                dg.SDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                dg.SEmail = dt.Rows[i]["Email"].ToString();
                dg.SDaMuon = int.Parse(dt.Rows[i]["DaMuon"].ToString());
                dg.SDangMuon = int.Parse(dt.Rows[i]["DangMuon"].ToString());

                docGia.Add(dg);
            }

            return docGia;
        }
    }
}
