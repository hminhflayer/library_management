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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        public void LoadSach()
        {
            dgvDanhSachSach.DataSource = Sach_BUS.DanhSachSach();
        }

        public void LoadPhanLoai()
        {
            cmbTheLoai.DataSource = PhanLoai_BUS.DanhSachPhanLoai();
            cmbTheLoai.DisplayMember = "sTenLoai";
            cmbTheLoai.ValueMember = "sMaLoai";
        }

        public void LoadTinhTrang()
        {
            cmbTinhTrang.DataSource = TinhTrang_BUS.DanhSachTinhTrang();
            cmbTinhTrang.DisplayMember = "sTenTinhTrang";
            cmbTinhTrang.ValueMember = "sMaTinhTrang";
        }

        public bool KiemTra()
        {
            if(txtTenSach.Text == "" || txtXuatBan.Text == "" || txtTacGia.Text == "" || txtViTri.Text == "")
            {
                return false;
            }
            return true;
        }

        public void XoaText()
        {
            txtMaSach.Clear();
            txtTacGia.Clear();
            txtTenSach.Clear();
            txtViTri.Clear();
            txtXuatBan.Clear();
            txtTenSach.Focus();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            LoadPhanLoai();
            LoadSach();
            LoadTinhTrang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(KiemTra())
            {
               if(Sach_BUS.SuaSach(txtMaSach.Text, cmbTheLoai.SelectedValue.ToString(), txtTenSach.Text, txtTacGia.Text, txtXuatBan.Text, txtViTri.Text, cmbTinhTrang.SelectedValue.ToString(), rdbSanCo.Checked==true?1:0 ) != 0)
                {
                    MessageBox.Show("Đã sửa thành công!");
                    LoadSach();
                }
               else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }    
            }
        }

        private void dgvDanhSachSach_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachSach.SelectedRows.Count > 0)
            {
                txtMaSach.Text = dgvDanhSachSach.SelectedRows[0].Cells["sMaSach"].Value.ToString();
                cmbTheLoai.SelectedValue = dgvDanhSachSach.SelectedRows[0].Cells["sMaLoai"].Value.ToString();
                txtTenSach.Text = dgvDanhSachSach.SelectedRows[0].Cells["sTenSach"].Value.ToString();
                txtXuatBan.Text = dgvDanhSachSach.SelectedRows[0].Cells["sXuatBan"].Value.ToString();
                txtTacGia.Text = dgvDanhSachSach.SelectedRows[0].Cells["sTacGia"].Value.ToString();
                txtViTri.Text = dgvDanhSachSach.SelectedRows[0].Cells["sNoiLuu"].Value.ToString();
                cmbTinhTrang.SelectedValue = dgvDanhSachSach.SelectedRows[0].Cells["sMaTinhTrang"].Value.ToString();
                if(cmbTinhTrang.SelectedValue.ToString() == "SKCMUON")
                {
                    rdbSanCo.Checked = true;
                    rdbDaMuon.Enabled = false;
                    rdbSanCo.Enabled = false;
                }    
                else
                {
                    rdbDaMuon.Enabled = true;
                    rdbSanCo.Enabled = true;
                    if ((bool)dgvDanhSachSach.SelectedRows[0].Cells["sTrangThai"].Value == true)
                    {
                        rdbSanCo.Checked = true;
                    }
                    else
                    {
                        rdbDaMuon.Checked = true;
                    }
                }
            }
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (Sach_BUS.XoaSach(txtMaSach.Text) != 0)
                {
                    MessageBox.Show("Đã xoá thành công!");
                    LoadSach();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
        }

        private void cmbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTinhTrang.SelectedValue.ToString() == "SKCMUON")
            {
                rdbSanCo.Checked = true;
                rdbDaMuon.Enabled = false;
                rdbSanCo.Enabled = false;
            }
            else
            {
                rdbDaMuon.Enabled = true;
                rdbSanCo.Enabled = true;               
            }
        }
    }
}
