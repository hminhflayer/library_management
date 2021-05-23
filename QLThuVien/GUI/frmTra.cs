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
    public partial class frmTra : Form
    {
        public frmTra()
        {
            InitializeComponent();
        }
        public void LoadDocGia()
        {
            cmbDocGia.DataSource = DocGia_BUS.DanhSachDocGia();
            cmbDocGia.DisplayMember = "SHoTen";
            cmbDocGia.ValueMember = "SMaDocGia";
        }

        public void LoadSach()
        {
            cmbSach.DataSource = Sach_BUS.DanhSachSach();
            cmbSach.DisplayMember = "STenSach";
            cmbSach.ValueMember = "SMaSach";

        }

        public void LoadDanhSachMuon()
        {
            dgvMuon.DataSource = MuonTra_BUS.DanhSachMuonTra();
        }
        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            LoadSach();
            LoadDanhSachMuon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MuonTra_BUS.TraSach(cmbDocGia.SelectedValue.ToString() , cmbSach.SelectedValue.ToString()) != 0)
            {
                MessageBox.Show("Độc giả "+cmbDocGia.Text+" đã trả lại sách "+cmbSach.Text);
                LoadDanhSachMuon();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xử lí");
            }    
        }

        private void dgvMuon_Click(object sender, EventArgs e)
        {
            if(dgvMuon.SelectedRows.Count > 0)
            {
                cmbDocGia.SelectedValue = dgvMuon.SelectedRows[0].Cells["sMaDocGia"].Value;
                cmbSach.SelectedValue = dgvMuon.SelectedRows[0].Cells["SMaSach"].Value;
            }    
        }
    }
}
