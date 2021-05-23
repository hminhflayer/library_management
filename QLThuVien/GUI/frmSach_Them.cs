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
    public partial class frmSach_Them : Form
    {
        public frmSach_Them()
        {
            InitializeComponent();
        }

        public void LoadTinhTrang()
        {
            cmbTinhTrang.DataSource = TinhTrang_BUS.DanhSachTinhTrang();
            cmbTinhTrang.DisplayMember = "sTenTinhTrang";
            cmbTinhTrang.ValueMember = "sMaTinhTrang";
        }

        public void LoadTheLoai()
        {
            cmbTheLoai.DataSource = PhanLoai_BUS.DanhSachPhanLoai();
            cmbTheLoai.DisplayMember = "sTenLoai";
            cmbTheLoai.ValueMember = "sMaLoai";
        }

        public bool KiemTra()
        {
            if(txtMaSach.Text == "" || txtTenSach.Text == "" || txtXuatBan.Text == "" || txtTacGia.Text == "" || txtViTri.Text == "")
            {
                return false;
            }
            return true;
        }

        private void frmSach_Them_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            LoadTinhTrang();
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            if(Sach_BUS.KiemTraTrungKhoaChinh(txtMaSach.Text) && txtMaSach.Text != "")
            {
                lblThongBao.Visible = true;
                btnThem.Enabled = false;
            }
            else
            {
                lblThongBao.Visible = false;
                btnThem.Enabled = true;
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KiemTra())
            {
                if(Sach_BUS.ThemSach(txtMaSach.Text, cmbTheLoai.SelectedValue.ToString(), txtTenSach.Text, txtTacGia.Text, txtXuatBan.Text, txtViTri.Text, cmbTinhTrang.SelectedValue.ToString()) != 0)
                {
                    MessageBox.Show("Thêm sách mới thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }    
            }
            else
            {
                MessageBox.Show("Thông tin sách không được để trống");
                txtTenSach.Focus();
            }
        }
    }
}
