using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TinhTrang_BUS
    {
        public static List<TinhTrang_DTO> DanhSachTinhTrang()
        {
            return TinhTrang_DAO.DanhSachTinhTrang();
        }
    }
}
