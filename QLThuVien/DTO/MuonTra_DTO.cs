using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MuonTra_DTO
    {
        private string sMaDocGia;
        private string sMaSach;
        private DateTime sNgayMuon;
        private DateTime sNgayTra;

        public string SMaDocGia { get => sMaDocGia; set => sMaDocGia = value; }
        public string SMaSach { get => sMaSach; set => sMaSach = value; }
        public DateTime SNgayMuon { get => sNgayMuon; set => sNgayMuon = value; }
        public DateTime SNgayTra { get => sNgayTra; set => sNgayTra = value; }
    }
}
