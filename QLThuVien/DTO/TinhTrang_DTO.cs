using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhTrang_DTO
    {
        private string sMaTinhTrang;
        private string sTenTinhTrang;

        public string SMaTinhTrang { get => sMaTinhTrang; set => sMaTinhTrang = value; }
        public string STenTinhTrang { get => sTenTinhTrang; set => sTenTinhTrang = value; }
    }
}
