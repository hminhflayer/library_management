using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmTimTK : Form
    {
        public frmTimTK()
        {
            InitializeComponent();
        }

        public void LoadDanhSachTaiKhoan()
        {
            dgvDanhSachTaiKhoan.DataSource = TaiKhoan_BUS.DanhSachTaiKhoan();
            dgvDanhSachTaiKhoan.Columns[0].HeaderText = "Tên đăng nhập";
            dgvDanhSachTaiKhoan.Columns[1].Visible = false;
            dgvDanhSachTaiKhoan.Columns[2].HeaderText = "Tên người dùng";
            dgvDanhSachTaiKhoan.Columns[3].Visible = false;
            dgvDanhSachTaiKhoan.Columns[4].Visible = false;

            dgvDanhSachTaiKhoan.Rows[0].Selected = true;

        }

        public void TimKiemTaiKhoan(string _tenDangNhap)
        {
            dgvDanhSachTaiKhoan.DataSource = TaiKhoan_BUS.TimKiem(_tenDangNhap);
            dgvDanhSachTaiKhoan.Columns[0].HeaderText = "Tên đăng nhập";
            dgvDanhSachTaiKhoan.Columns[1].Visible = false;
            dgvDanhSachTaiKhoan.Columns[2].HeaderText = "Tên người dùng";
            dgvDanhSachTaiKhoan.Columns[3].Visible = false;
            dgvDanhSachTaiKhoan.Columns[4].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "")
            {
                TimKiemTaiKhoan(txtTenDangNhap.Text);
            }
            else
            {
                LoadDanhSachTaiKhoan();
            }
        }
    }
}
