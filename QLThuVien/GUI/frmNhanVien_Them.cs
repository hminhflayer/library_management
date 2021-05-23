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
    public partial class frmNhanVien_Them : Form
    {
        public frmNhanVien_Them()
        {
            InitializeComponent();
        }

        public bool KiemTra()
        {
            if(txtMaNhanVien.Text == "" || txtHoTen.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            if(NhanVien_BUS.KiemTraTrungKhoaChinh(txtMaNhanVien.Text))
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
                if(NhanVien_BUS.ThemNhanVien(txtMaNhanVien.Text, txtHoTen.Text, DateTime.Parse(dtpNgaySinh.Text), (rdbNam.Checked == true)?"Nam":"Nữ") != 0)
                {
                    MessageBox.Show("Thêm thành công!");
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
