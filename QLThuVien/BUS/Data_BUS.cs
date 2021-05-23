using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class Data_BUS
    {
        public static int BackupData()
        {
            string query = @"backup database DB_QUANLYTHUVIEN to disk ='D:\QLThuVien\Database\qlthuvien.bak' with init,stats=10";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public static int RestoreData()
        {
            string query = @"use master restore database DB_QUANLYTHUVIEN from disk ='D:\QLThuVien\Database\qlthuvien.bak'";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
