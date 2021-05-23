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
    public partial class frmPhanLoai_Them : Form
    {
        public frmPhanLoai_Them()
        {
            InitializeComponent();
        }

        public bool KiemTra()
        {
            if (txtMaLoai.Text == "" || txtTenLoai.Text == "")
            {
                MessageBox.Show("Thông tin không được trống!");
                return false;
            }
            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {
            if (PhanLoai_BUS.KiemTraTrungKhoaChinh(txtMaLoai.Text))
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (PhanLoai_BUS.ThemPhanLoai(txtMaLoai.Text, txtTenLoai.Text) != 0)
                {
                    MessageBox.Show("Thêm phân loại thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi đã xảy ra");
                }
            }
        }
    }
}
