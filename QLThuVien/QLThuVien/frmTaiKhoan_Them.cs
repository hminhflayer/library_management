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
    public partial class frmTaiKhoan_Them : Form
    {
        public frmTaiKhoan_Them()
        {
            InitializeComponent();
        }

        public void LoadDanhSachQuyenHan()
        {
            cmbQuyenHan.DataSource = PhanQuyen_BUS.DanhSachPhanQuyen();
            cmbQuyenHan.DisplayMember = "sTenQuyen";
            cmbQuyenHan.ValueMember = "sMaQuyen";
        }

        public void LoadDanhSachNhanVienChuaCoTaiKhoan()
        {
            cmbNhanVien.DataSource = NhanVien_BUS.DanhSachNhanVienChuaCoTaiKhoan();

            if(cmbNhanVien.Items.Count > 0)
            {
                cmbNhanVien.DisplayMember = "sHoten";
                cmbNhanVien.ValueMember = "sMaNhanVien";
                lblThongBao.Visible = false;
            }    
            else
            {
                lblThongBao.Text = "Hiện không có nhân viên nào chưa có tài khoản.";
                lblThongBao.Visible = true;
                txtTenDangNhap.Enabled = false;
                txtTenNguoiDung.Enabled = false;
                txtMatKhau.Enabled = false;
                txtNhapLaiMatKhau.Enabled = false;
                btnThem.Enabled = false;
            }    
        }

        public bool KiemTra()
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtNhapLaiMatKhau.Text == "")
            {
                MessageBox.Show("Thông tin không được để trống!");
                return false;
            }
            if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                txtNhapLaiMatKhau.Focus();
                return false;
            }  
            if(txtTenNguoiDung.Text == "")
            {
                txtTenNguoiDung.Text = cmbNhanVien.SelectedValue.ToString();
            }    
            return true;
        }

        private void frmTaiKhoan_Them_Load(object sender, EventArgs e)
        {
            LoadDanhSachQuyenHan();
            LoadDanhSachNhanVienChuaCoTaiKhoan();
        }

        private void ckbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (TaiKhoan_BUS.ThemTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text, txtTenNguoiDung.Text, cmbQuyenHan.SelectedValue.ToString(), cmbNhanVien.SelectedValue.ToString()) != 0)
                {
                    MessageBox.Show("Thêm tài khoản mới thành công!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi đã xảy ra!");
                }
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (TaiKhoan_BUS.KiemTraTrungDuLieu(txtTenDangNhap.Text))
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Tên đăng nhập đã có người sử dụng!";
                btnThem.Enabled = false;
            }
            else
            {
                lblThongBao.Visible = false;
                btnThem.Enabled = true;
            }    
        }
    }
}
