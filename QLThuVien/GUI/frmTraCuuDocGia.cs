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
    public partial class frmTraCuuDocGia : Form
    {
        public frmTraCuuDocGia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDocGia.DataSource = DocGia_BUS.TimKiemDocGia(txtTenDG.Text);
        }
    }
}
