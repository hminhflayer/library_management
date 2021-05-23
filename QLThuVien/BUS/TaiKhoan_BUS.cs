using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public static TaiKhoan_DTO Login(string _tenDangNhap, string _matKhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = GetMd5Hash(md5Hash, _matKhau);
            return TaiKhoan_DAO.Login(_tenDangNhap, matkhauMH);
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static List<TaiKhoan_DTO> DanhSachTaiKhoan()
        {
            return TaiKhoan_DAO.DanhSachTaiKhoan();
        }

        public static int ThemTaiKhoan(string _tenDangNhap, string _matKhau, string _tenNguoiDung, string _maQuyen, string _maNhanVien)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = GetMd5Hash(md5Hash, _matKhau);
            return TaiKhoan_DAO.ThemTaiKhoan(_tenDangNhap, matkhauMH, _tenNguoiDung, _maQuyen, _maNhanVien);
        }

        public static int XoaTaiKhoan(string _tenDangNhap)
        {
            return TaiKhoan_DAO.XoaTaiKhoan(_tenDangNhap);
        }

        public static int SuaTaiKhoan(string _tenDangNhap, string _tenNguoiDung, string _maQuyen)
        {
            return TaiKhoan_DAO.SuaTaiKhoan(_tenDangNhap, _tenNguoiDung, _maQuyen);
        }

        public static int CapLaiMatKhau(string _tenDangNhap)
        {
            return TaiKhoan_DAO.CapLaiMatKhau(_tenDangNhap);
        }

        public static List<TaiKhoan_DTO> TimKiem(string _tenDangNhap)
        {
            return TaiKhoan_DAO.TimKiem(_tenDangNhap);
        }

        public static bool KiemTraTrungDuLieu(string _tenDangNhap)
        {
            return TaiKhoan_DAO.KiemTraTrungDuLieu(_tenDangNhap);
        }

        public static bool DoiMatKhau(string _tenDangNhap, string _matKhau, string _matKhauMoi)
        {
            return TaiKhoan_DAO.DoiMatKhau(_tenDangNhap, _matKhau, _matKhauMoi);
        }
    }
}
