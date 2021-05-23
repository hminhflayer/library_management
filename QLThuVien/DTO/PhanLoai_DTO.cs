using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanLoai_DTO
    {
        private string sMaLoai;
        private string sTenLoai;

        public string SMaLoai { get => sMaLoai; set => sMaLoai = value; }
        public string STenLoai { get => sTenLoai; set => sTenLoai = value; }
    }
}
