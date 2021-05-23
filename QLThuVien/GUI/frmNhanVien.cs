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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void LoadDanhSachNhanVien()
        {
            dgvNhanVien.DataSource = NhanVien_BUS.DanhSachNhanVien();
            if(dgvNhanVien.Rows.Count > 0)
            {
                dgvNhanVien.Rows[0].Selected = true;
                Event_Click();
            }    
            
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Họ tên";
            dgvNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[3].HeaderText = "Giới tính";

            
        }

        public void Event_Click()
        {
            txtMaNhanVien.Text = dgvNhanVien.SelectedRows[0].Cells["sMaNhanVien"].Value.ToString();
            txtHoTen.Text = dgvNhanVien.SelectedRows[0].Cells["sHoTen"].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.SelectedRows[0].Cells["sNgaySinh"].Value.ToString();

            string gt = dgvNhanVien.SelectedRows[0].Cells["sGioiTinh"].Value.ToString();
            if(gt == "Nam")
            {
                rdbNam.Checked = true;
            }    
            else
            {
                rdbNu.Checked = true;
            }    
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if(dgvNhanVien.SelectedRows.Count > 0)
            {
                Event_Click();
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(NhanVien_BUS.XoaNhanVien(txtMaNhanVien.Text) != 0)
            {
                MessageBox.Show("Xoá thành công!");
                LoadDanhSachNhanVien();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text != "")
            {
                if(NhanVien_BUS.SuaNhanVien(txtMaNhanVien.Text, txtHoTen.Text, DateTime.Parse(dtpNgaySinh.Text),(rdbNam.Checked == true)?"Nam":"Nữ") != 0)
                {
                    MessageBox.Show("Đã sửa thành công");
                    LoadDanhSachNhanVien();
                }    
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }    
            }
        }
    }
}
