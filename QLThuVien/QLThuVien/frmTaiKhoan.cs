using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
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
            Event_Click();

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

        public void LoadDanhSachQuyenHan()
        {
            cmbQuyenHan.DataSource = PhanQuyen_BUS.DanhSachPhanQuyen();
            cmbQuyenHan.DisplayMember = "sTenQuyen";
            cmbQuyenHan.ValueMember = "sMaQuyen";
        }

        public void LoadDanhSachNhanVienDaCoTaiKhoan()
        {
            cmbNhanVien.DataSource = NhanVien_BUS.DanhSachNhanVienDaCoTaiKhoan();
            cmbNhanVien.DisplayMember = "sHoten";
            cmbNhanVien.ValueMember = "sMaNhanVien";
        }

        public bool KiemTra()
        {
            if(txtTenDangNhap.Text == "" || txtTenNguoiDung.Text == "" )
            {
                MessageBox.Show("Thông tin không được để trống!");
                return false;
            } 
            return true;
        }


        public void Event_Click()
        {
            txtTenDangNhap.Text = dgvDanhSachTaiKhoan.SelectedRows[0].Cells["sTenDangNhap"].Value.ToString();
            txtTenNguoiDung.Text = dgvDanhSachTaiKhoan.SelectedRows[0].Cells["sTenNguoiDung"].Value.ToString();
            cmbNhanVien.SelectedValue = dgvDanhSachTaiKhoan.SelectedRows[0].Cells["sMaNhanVien"].Value.ToString();
            cmbQuyenHan.SelectedValue = dgvDanhSachTaiKhoan.SelectedRows[0].Cells["sMaquyen"].Value.ToString();
        }

        public void clearText()
        {
            txtTenDangNhap.Clear();
            txtTenNguoiDung.Clear();

            txtTenDangNhap.Focus();
        }

        private void frmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoan();
            LoadDanhSachQuyenHan();
            LoadDanhSachNhanVienDaCoTaiKhoan();
        } 

        private void form_Closed(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(TaiKhoan_BUS.XoaTaiKhoan(txtTenDangNhap.Text) != 0)
            {
                MessageBox.Show("Xoá tài khoản thành công!");
                LoadDanhSachTaiKhoan();
                clearText();
            }
            else
            {
                MessageBox.Show("Có lỗi đã xảy ra!");
            }    
        }

        private void dgvDanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachTaiKhoan.SelectedRows.Count > 0)
            {
                Event_Click();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (TaiKhoan_BUS.SuaTaiKhoan(txtTenDangNhap.Text, txtTenNguoiDung.Text, cmbQuyenHan.SelectedValue.ToString()) != 0)
                {
                    MessageBox.Show("Đã Sửa thông tin tài khoản thành công!");
                    LoadDanhSachTaiKhoan();
                    clearText();
                }
                else
                {
                    MessageBox.Show("Có lỗi đã xảy ra!");
                }
            }
        }

        private void câpLaiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text != "")
            {
                TimKiemTaiKhoan(txtTenDangNhap.Text);
            }    
            else
            {
                LoadDanhSachTaiKhoan();
            }    
        }

        private void btnCapLai_Click(object sender, EventArgs e)
        {
            string TenDangNhap = dgvDanhSachTaiKhoan.SelectedRows[0].Cells["sTenDangNhap"].Value.ToString();
            if (TenDangNhap == "")
            {
                MessageBox.Show("Không thể nhận diện được người cần cấp lại mật khẩu");
            }
            else
            {
                if (TaiKhoan_BUS.CapLaiMatKhau(TenDangNhap) != 0)
                {
                    MessageBox.Show("/tĐã cấp lại mật khẩu cho tài khoản " + TenDangNhap + "\n Mật khẩu : 1 \n Vui lòng đổi mật khẩu khi đăng nhập vào tài khoản này!");
                }
                else
                {
                    MessageBox.Show("Có lỗi đã xảy ra!");
                }
            }
        }
    }
}
