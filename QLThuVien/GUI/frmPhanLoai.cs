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

namespace GUI
{
    public partial class frmPhanLoai : Form
    {
        public frmPhanLoai()
        {
            InitializeComponent();
        }

        public void LoadDanhSachPhanLoai()
        {
            dgvPhanLoai.DataSource = PhanLoai_BUS.DanhSachPhanLoai();
            dgvPhanLoai.Columns["sMaLoai"].HeaderText = "Mã loại";
            dgvPhanLoai.Columns["sTenLoai"].HeaderText = "Tên loại";

            if(dgvPhanLoai.Rows.Count == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }  
            else
            {
                dgvPhanLoai.SelectedRows[0].Selected = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }    
        }

        public bool KiemTra()
        {
            if(txtMaLoai.Text == "" || txtTenLoai.Text == "")
            {
                MessageBox.Show("Thông tin không được trống!");
                return false;
            }
            return true;
        }    

        private void frmQuanLyPhanLoai_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhanLoai();
        }

        private void dgvPhanLoai_Click(object sender, EventArgs e)
        {
            if(dgvPhanLoai.SelectedRows.Count > 0)
            {
                txtMaLoai.Text = dgvPhanLoai.SelectedRows[0].Cells["sMaLoai"].Value.ToString();
                txtTenLoai.Text = dgvPhanLoai.SelectedRows[0].Cells["sTenLoai"].Value.ToString();
            }        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(PhanLoai_BUS.XoaPhanLoai(txtMaLoai.Text) != 0)
            {
                MessageBox.Show("Xoá thành công!");
                LoadDanhSachPhanLoai();
            }
            else
            {
                MessageBox.Show("Có lỗi đã xảy ra.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (PhanLoai_BUS.SuaPhanLoai(txtMaLoai.Text,txtTenLoai.Text) != 0)
            {
                MessageBox.Show("Sửa thành công!");
                LoadDanhSachPhanLoai();
            }
            else
            {
                MessageBox.Show("Có lỗi đã xảy ra.");
            }
        }
    }
}
