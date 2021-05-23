using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyen_DTO
    {
        private string sMaQuyen;
        private string sTenQuyen;

        public string SMaQuyen { get => sMaQuyen; set => sMaQuyen = value; }
        public string STenQuyen { get => sTenQuyen; set => sTenQuyen = value; }
    }
}
