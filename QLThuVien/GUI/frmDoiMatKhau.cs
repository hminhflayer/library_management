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
    public partial class frmDoiMatKhau : Form
    {
        private string tenDangNhap;

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }

        public frmDoiMatKhau(string _tenDangNhap)
        {
            TenDangNhap = _tenDangNhap;
            InitializeComponent();
        }

        private bool KiemTra()
        {
            if(txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtXacNhan.Text == "" || txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu không hợp lệ");
                return false;
            }    
            else
            {    
                return true;
            }
            return false;
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if(KiemTra())
            {
                if(TaiKhoan_BUS.DoiMatKhau(TenDangNhap, txtMatKhauCu.Text, txtMatKhauMoi.Text))
                {
                    MessageBox.Show("Đã đổi mật khẩu thành công!");
                    this.Close();
                }    
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }    
            }    
        }

        private void ckbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHienThi.Checked == true)
            {
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtXacNhan.UseSystemPasswordChar = false;
            }    
            else
            {
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtXacNhan.UseSystemPasswordChar = true;
            }    
        }
    }
}
