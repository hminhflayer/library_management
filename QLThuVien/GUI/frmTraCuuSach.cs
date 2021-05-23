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
    public partial class frmTraCuuSach : Form
    {
        public frmTraCuuSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvSach.DataSource = Sach_BUS.TimKiemSach(txtTenDG.Text);

            dgvSach.Columns["SMaSach"].Visible = false;
            dgvSach.Columns["SMaLoai"].Visible = false;
            dgvSach.Columns["SXuatBan"].Visible = false;
            dgvSach.Columns["sMaTinhTrang"].Visible = false;

            dgvSach.Columns["STenSach"].HeaderText = "Tên sách";

            dgvSach.Columns["STacGia"].HeaderText = "Tác giả";
            dgvSach.Columns["SNoiLuu"].HeaderText = "Nơi lưu";
            dgvSach.Columns["STrangThai"].HeaderText = "Trạng thái";
        }
    }
}
