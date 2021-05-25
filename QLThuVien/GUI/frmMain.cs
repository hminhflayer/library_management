using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using BUS;
using DTO;
using System.IO;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Properties
        bool status = false;

        TaiKhoan_DTO tk;

        frmLogin login;

        frmDoiMatKhau frmDoiMatKhau;

        frmTaiKhoan frmQLTaiKhoan;
        frmTaiKhoan_Them frmTaiKhoan_Them;

        frmNhanVien nhanVien;
        frmNhanVien_Them nhanVien_them;

        frmSach sach;
        frmSach_Them sach_Them;

        frmPhanLoai phanLoai;
        frmPhanLoai_Them phanLoai_Them;

        frmDocGia docGia;
        frmDocGia_Them docGia_Them;

        frmMuon muon;
        frmTra tra;

        frmTraCuuDocGia traCuuDocGia;
        frmTraCuuSach traCuuSach;
        frmTimTK tracuuTK;

        rpSach1 rpSach;
        rpMuon rp;

        #endregion


        #region Methods

        #endregion

        #region Events

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnDSNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.Show();
                nhanVien.MdiParent = this;
            }
        }

        private void btnThemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nhanVien_them == null || nhanVien_them.IsDisposed)
            {
                nhanVien_them = new frmNhanVien_Them();
                nhanVien_them.Show();
                nhanVien_them.Closed += new EventHandler(NhanVienThem_Closed);
                nhanVien_them.MdiParent = this;
            }
        }

        private void NhanVienThem_Closed(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                return;
            }
            else
            {
                nhanVien.LoadDanhSachNhanVien();
            }

        }

        private void btnDSTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmQLTaiKhoan == null || frmQLTaiKhoan.IsDisposed)
            {
                frmQLTaiKhoan = new frmTaiKhoan();
                frmQLTaiKhoan.Show();
                frmQLTaiKhoan.MdiParent = this;
            }
        }

        private void btnThemTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmTaiKhoan_Them == null || frmTaiKhoan_Them.IsDisposed)
            {
                frmTaiKhoan_Them = new frmTaiKhoan_Them();
                frmTaiKhoan_Them.Show();
                frmTaiKhoan_Them.Closed += new EventHandler(TaiKhoanThem_Closed);
                frmTaiKhoan_Them.MdiParent = this;
            }
        }

        private void TaiKhoanThem_Closed(object sender, EventArgs e)
        {

            if (frmQLTaiKhoan == null || frmQLTaiKhoan.IsDisposed)
            {
                return;
            }
            else
            {
                frmQLTaiKhoan.LoadDanhSachTaiKhoan();
            }
        }


        private void btnDSTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (phanLoai == null || phanLoai.IsDisposed)
            {
                phanLoai = new frmPhanLoai();
                phanLoai.Show();
                phanLoai.MdiParent = this;
            }
        }

        private void btnThemTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (phanLoai_Them == null || phanLoai_Them.IsDisposed)
            {
                phanLoai_Them = new frmPhanLoai_Them();
                phanLoai_Them.Show();
                phanLoai_Them.Closed += new EventHandler(TheLoaiThem_Closed);
                phanLoai_Them.MdiParent = this;
            }
        }


        private void TheLoaiThem_Closed(object sender, EventArgs e)
        {
            if (phanLoai == null || phanLoai.IsDisposed)
            {
                return;
            }
            else
            {
                phanLoai.LoadDanhSachPhanLoai();
            }

        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDoiMatKhau == null || frmDoiMatKhau.IsDisposed)
            {
                frmDoiMatKhau = new frmDoiMatKhau(tk.STenDangNhap);
                frmDoiMatKhau.Show();
                frmDoiMatKhau.MdiParent = this;
            }
        }

        private void btnThemSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sach_Them == null || sach_Them.IsDisposed)
            {
                sach_Them = new frmSach_Them();
                sach_Them.Show();
                sach_Them.Closed += new EventHandler(ThemSach_Closed);
                sach_Them.MdiParent = this;
            }
        }

        private void btnDSSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sach == null || sach.IsDisposed)
            {
                sach = new frmSach();
                sach.Show();
                sach.MdiParent = this;
            }
        }

        private void ThemSach_Closed(object sender, EventArgs e)
        {
            if (sach == null || sach.IsDisposed)
            {
                return;
            }
            else
            {
                sach.LoadSach();
            }
        }


        #endregion

        private void btnDSDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (docGia == null || docGia.IsDisposed)
            {
                docGia = new frmDocGia();
                docGia.Show();
                docGia.MdiParent = this;
            }
        }

        private void btnThemDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (docGia_Them == null || docGia_Them.IsDisposed)
            {
                docGia_Them = new frmDocGia_Them();
                docGia_Them.Show();
                docGia_Them.Closed += new EventHandler(ThemDocGia_Closed);
                docGia_Them.MdiParent = this;
            }
        }

        private void ThemDocGia_Closed(object sender, EventArgs e)
        {
            if (docGia == null || docGia.IsDisposed)
            {
                return;
            }
            else
            {
                docGia.LoadDSDocGia();
            }
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                tk = TaiKhoan_BUS.Login(login.txtTenDangNhap.Text, login.txtMatKhau.Text);
                if (tk != null)
                {
                    status = true;
                    txtName.Caption = "Tên: "+tk.STenNguoiDung;
                    txtTimeLog.Caption = "Đăng nhập lúc : "+DateTime.Now.ToString();

                    rbpgThongTin.Visible = status;

                    rbpgDangXuat.Visible = status;
                    rbpDangNhap.Visible = !status;

                    if(tk.SMaQuyen == "ADMIN")
                    {
                        rbpQuanLy.Visible = status;
                        rbpThongKe.Visible = status;
                        rbpNghiepVu.Visible = status;
                        btnTCDocGia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        btnTimTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                        rbpgNhanVien.Visible = status;
                        rbpgSach.Visible = status;
                        rbpgTheLoai.Visible = status;
                        rbpgDocGia.Visible = status;
                        rbpgTaiKhoan.Visible = status;
                        rbpThongKe.Visible = status;
                        rbpDuLieu.Visible = status;
                    }    
                    else if (tk.SMaQuyen == "BQL")
                    {
                        rbpQuanLy.Visible = status;
                        rbpThongKe.Visible = status;
                        rbpNghiepVu.Visible = status;
                        btnTCDocGia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                        btnTimTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                        rbpgNhanVien.Visible = status;
                        rbpgSach.Visible = !status;
                        rbpgTheLoai.Visible = !status;
                        rbpgDocGia.Visible = !status;
                        rbpgTaiKhoan.Visible = status;
                        rbpThongKe.Visible = status;
                        rbpDuLieu.Visible = status;

                    }    
                    else if( tk.SMaQuyen == "KT")
                    {
                        rbpQuanLy.Visible = status;
                        rbpgSach.Visible = status;
                        rbpgTheLoai.Visible = status;

                        rbpgNhanVien.Visible = !status;
                        rbpgDocGia.Visible = !status;
                        rbpgTaiKhoan.Visible = !status;
                        rbpThongKe.Visible = !status;
                    }    
                    else
                    {
                        btnTCDocGia.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        rbpQuanLy.Visible = status;
                        rbpgDocGia.Visible = status;
                        rbpNghiepVu.Visible = status;

                        rbpgNhanVien.Visible = !status;
                        rbpgSach.Visible = !status;
                        rbpgTheLoai.Visible = !status;
                        rbpgDocGia.Visible = status;
                        rbpgTaiKhoan.Visible = !status;
                        rbpThongKe.Visible = !status;
                    }    
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }    
            }    
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = false;
            foreach (Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
            rbpgThongTin.Visible = status;

            rbpgDangXuat.Visible = status;
            rbpDangNhap.Visible = !status;
            rbpQuanLy.Visible = status;
            rbpThongKe.Visible = status;
            rbpNghiepVu.Visible = status;
            rbpDuLieu.Visible = status;
            btnTCDocGia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnTimTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void btnMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (muon == null || muon.IsDisposed)
            {
                muon = new frmMuon();
                muon.Show();
                muon.Closed += new EventHandler(Muon_Closed);
                muon.MdiParent = this;
            }
        }

        private void Muon_Closed(object sender, EventArgs e)
        {
            if (tra == null || tra.IsDisposed)
            {
                return;
            }
            else
            {
                tra.LoadDanhSachMuon();
            }
        }

        private void btnTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tra == null || tra.IsDisposed)
            {
                tra = new frmTra();
                tra.Show();
                tra.MdiParent = this;
            }
        }

        private void btnTCSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (traCuuSach == null || traCuuSach.IsDisposed)
            {
                traCuuSach = new frmTraCuuSach();
                traCuuSach.Show();
                traCuuSach.MdiParent = this;
            }
        }

        private void btnTCDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (traCuuDocGia == null || traCuuDocGia.IsDisposed)
            {
                traCuuDocGia = new frmTraCuuDocGia();
                traCuuDocGia.Show();
                traCuuDocGia.MdiParent = this;
            }
        }

        private void btnThongKeSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rpSach == null || rpSach.IsDisposed)
            {
                rpSach = new rpSach1();
                ReportPrintTool designTool = new ReportPrintTool(rpSach);
                designTool.ShowPreview();
            }
        }

        private void btnTimTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tracuuTK == null || tracuuTK.IsDisposed)
            {
                tracuuTK = new frmTimTK();
                tracuuTK.Show();
                tracuuTK.MdiParent = this;
            }
        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool bBackUpStatus = true;

            Cursor.Current = Cursors.WaitCursor;

            if (Directory.Exists(@"D:\library_management\QLThuVien\Database"))
            {
                if (File.Exists(@"D:\library_management\QLThuVien\Database\qlthuvien.bak"))
                {
                    if (MessageBox.Show(@"Bạn có muốn ghi đè lại dữ liệu?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(@"D:\library_management\QLThuVien\Database\qlthuvien.bak");
                    }
                    else
                        bBackUpStatus = false;
                }
            }
            else
                Directory.CreateDirectory(@"D:\library_management\QLThuVien\Database");

            if (bBackUpStatus)
            {
                if(Data_BUS.BackupData() != 0)
                {
                    MessageBox.Show("Sao lưu dữ liệu thành công!", "Back", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                if (File.Exists(@"D:\library_management\QLThuVien\Database\qlthuvien.bak"))
                {
                    if (MessageBox.Show("Bạn có muốn khôi phục dữ liệu?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if(Data_BUS.RestoreData() != 0)
                        {
                            MessageBox.Show("Đã khôi phục dữ liệu thành công!", "Restoration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                    MessageBox.Show(@"Khôi phục dữ liệu bị lỗi ( có thể bạn sai đường dẫn)", "Restoration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnTKMuonTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (rp == null || rp.IsDisposed)
            {
                rp = new rpMuon();
                ReportPrintTool designTool = new ReportPrintTool(rp);
                designTool.ShowPreview();
            }
        }

        private void btnHelp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Help.ShowHelp(this, "LibraryHelp.chm");
        }
    }
}
