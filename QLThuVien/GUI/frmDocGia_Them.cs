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
    public partial class frmDocGia_Them : Form
    {
        public frmDocGia_Them()
        {
            InitializeComponent();
        }

        public bool KiemTra()
        {
            if(txtMaDocGia.Text == "" || txtHoTen.Text == "" || txtDienThoai.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "")
            {
                return false;
            }
            return true;
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            if(DocGia_BUS.KiemTraMaDocGia(txtMaDocGia.Text))
            {
                lblThongBao.Visible = false;
                btnThem.Enabled = true;
            }
            else
            {
                lblThongBao.Visible = true;
                btnThem.Enabled = false;
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
                if (DocGia_BUS.ThemDocGia(txtMaDocGia.Text, txtHoTen.Text, DateTime.Parse(dtpNgaySinh.Text), rdbNam.Checked ? "Nam" : "Nữ", txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text) != 0)
                {
                    MessageBox.Show("Thêm độc giả mới thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Thông tin không đươc trống!");
            }    
        }
    }
}
