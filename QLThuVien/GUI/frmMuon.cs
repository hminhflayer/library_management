using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmMuon : Form
    {
        public frmMuon()
        {
            InitializeComponent();
        }

        public void LoadDocGia()
        {
            cmbDocGia.DataSource = DocGia_BUS.DocGiaThoaDieuKien();
            cmbDocGia.DisplayMember = "sHoTen";
            cmbDocGia.ValueMember = "sMaDocGia";
        }

        public void LoadSach()
        {
            cmbSach.DataSource = Sach_BUS.SachSanCo();
            if (cmbSach.DataSource == null)
            {
                MessageBox.Show("Sách không còn đủ");
                btnThem.Enabled = false;
            }
            cmbSach.DisplayMember = "sTenSach";
            cmbSach.ValueMember = "sMaSach";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMuon_Load(object sender, EventArgs e)
        {
            dtpMuon.Value = DateTime.Now;
            LoadDocGia();
            LoadSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(MuonTra_BUS.MuonSach(cmbDocGia.SelectedValue.ToString() , cmbSach.SelectedValue.ToString() , dtpMuon.Text , dtpTra.Text) != 0)
            {
                MessageBox.Show("Độc giả "+cmbDocGia.Text+" đã mượn sách "+cmbSach.Text);
                this.Close();
            }    
            else
            {
                MessageBox.Show("Có lỗi khi xử lí");
            }    
        }
    }
}
