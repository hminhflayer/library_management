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
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }
        public void LoadDSDocGia()
        {
            dgvDSDocGia.DataSource = DocGia_BUS.DanhSachDocGia();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            LoadDSDocGia();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(DocGia_BUS.XoaDocGia(txtMaDocGia.Text) != 0)
            {
                MessageBox.Show("Đã xoá thành công");
                LoadDSDocGia();
            }    
            else
            {
                MessageBox.Show("Có lỗi xảy ra");
            }    
        }

        public bool KiemTra()
        {
            if (txtMaDocGia.Text == "" || txtHoTen.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "")
            {
                return false;
            }
            return true;
        }

        private void dgvDSDocGia_Click(object sender, EventArgs e)
        {
            if(dgvDSDocGia.SelectedRows.Count > 0)
            {
                txtMaDocGia.Text = dgvDSDocGia.SelectedRows[0].Cells["SMaDocGia"].Value.ToString();
                txtHoTen.Text = dgvDSDocGia.SelectedRows[0].Cells["SHoTen"].Value.ToString();
                dtpNgaySinh.Text = dgvDSDocGia.SelectedRows[0].Cells["SNgaySinh"].Value.ToString();
                txtDiaChi.Text = dgvDSDocGia.SelectedRows[0].Cells["SDiaChi"].Value.ToString();
                txtDienThoai.Text = dgvDSDocGia.SelectedRows[0].Cells["SDienThoai"].Value.ToString();
                txtEmail.Text = dgvDSDocGia.SelectedRows[0].Cells["SEmail"].Value.ToString();
                txtDaMuon.Text = dgvDSDocGia.SelectedRows[0].Cells["SDaMuon"].Value.ToString();
                txtDangMuon.Text = dgvDSDocGia.SelectedRows[0].Cells["SDangMuon"].Value.ToString();
                if(dgvDSDocGia.SelectedRows[0].Cells["SMaDocGia"].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (DocGia_BUS.SuaDocGia(txtMaDocGia.Text, txtHoTen.Text, DateTime.Parse(dtpNgaySinh.Text), rdbNam.Checked ? "Nam" : "Nữ", txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text) != 0)
                {
                    MessageBox.Show("Sửa độc giả thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
        }
    }
}
