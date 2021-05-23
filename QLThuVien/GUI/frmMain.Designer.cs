
namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDSNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.txtTimeLog = new DevExpress.XtraBars.BarStaticItem();
            this.btnThemTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.txtName = new DevExpress.XtraBars.BarHeaderItem();
            this.btnTCDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnTCSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTra = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKeSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpDangNhap = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgThongTin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgDangXuat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgSach = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgDocGia = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgTheLoai = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgTinhTrang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpDuLieu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.timeSpanChartRangeControlClient1 = new DevExpress.XtraEditors.TimeSpanChartRangeControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDSNhanVien,
            this.btnThemNhanVien,
            this.btnDSSach,
            this.btnThemSach,
            this.btnDSDocGia,
            this.btnThemDocGia,
            this.btnDSTheLoai,
            this.btnDSTaiKhoan,
            this.btnThemTaiKhoan,
            this.txtTimeLog,
            this.btnThemTheLoai,
            this.btnDoiMatKhau,
            this.btnLogin,
            this.btnDangXuat,
            this.txtName,
            this.btnTCDocGia,
            this.btnTCSach,
            this.btnTra,
            this.btnMuon,
            this.btnThongKeSach,
            this.btnTimTK,
            this.btnTKDocGia,
            this.btnBackup,
            this.btnRestore});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 27;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1,
            this.rbpQuanLy,
            this.rbpThongKe,
            this.rbpNghiepVu,
            this.rbpDuLieu});
            this.ribbonControl1.Size = new System.Drawing.Size(817, 158);
            // 
            // btnDSNhanVien
            // 
            this.btnDSNhanVien.Caption = "Danh sách nhân viên";
            this.btnDSNhanVien.Id = 1;
            this.btnDSNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSNhanVien.ImageOptions.Image")));
            this.btnDSNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSNhanVien.ImageOptions.LargeImage")));
            this.btnDSNhanVien.Name = "btnDSNhanVien";
            this.btnDSNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSNhanVien_ItemClick);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Caption = "Thêm nhân viên";
            this.btnThemNhanVien.Id = 2;
            this.btnThemNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhanVien.ImageOptions.Image")));
            this.btnThemNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemNhanVien.ImageOptions.LargeImage")));
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNhanVien_ItemClick);
            // 
            // btnDSSach
            // 
            this.btnDSSach.Caption = "Danh sách sách";
            this.btnDSSach.Id = 3;
            this.btnDSSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSSach.ImageOptions.Image")));
            this.btnDSSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSSach.ImageOptions.LargeImage")));
            this.btnDSSach.Name = "btnDSSach";
            this.btnDSSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSSach_ItemClick);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Caption = "Thêm sách";
            this.btnThemSach.Id = 4;
            this.btnThemSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.ImageOptions.Image")));
            this.btnThemSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemSach.ImageOptions.LargeImage")));
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemSach_ItemClick);
            // 
            // btnDSDocGia
            // 
            this.btnDSDocGia.Caption = "Danh sách độc giả";
            this.btnDSDocGia.Id = 5;
            this.btnDSDocGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSDocGia.ImageOptions.Image")));
            this.btnDSDocGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSDocGia.ImageOptions.LargeImage")));
            this.btnDSDocGia.Name = "btnDSDocGia";
            this.btnDSDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDocGia_ItemClick);
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Caption = "Thêm độc giả";
            this.btnThemDocGia.Id = 6;
            this.btnThemDocGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDocGia.ImageOptions.Image")));
            this.btnThemDocGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemDocGia.ImageOptions.LargeImage")));
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemDocGia_ItemClick);
            // 
            // btnDSTheLoai
            // 
            this.btnDSTheLoai.Caption = "Danh sách thể loại";
            this.btnDSTheLoai.Id = 7;
            this.btnDSTheLoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSTheLoai.ImageOptions.Image")));
            this.btnDSTheLoai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSTheLoai.ImageOptions.LargeImage")));
            this.btnDSTheLoai.Name = "btnDSTheLoai";
            this.btnDSTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSTheLoai_ItemClick);
            // 
            // btnDSTaiKhoan
            // 
            this.btnDSTaiKhoan.Caption = "Danh sách tài khoản";
            this.btnDSTaiKhoan.Id = 9;
            this.btnDSTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSTaiKhoan.ImageOptions.Image")));
            this.btnDSTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSTaiKhoan.ImageOptions.LargeImage")));
            this.btnDSTaiKhoan.Name = "btnDSTaiKhoan";
            this.btnDSTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSTaiKhoan_ItemClick);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Caption = "Thêm tài khoản";
            this.btnThemTaiKhoan.Id = 10;
            this.btnThemTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTaiKhoan.ImageOptions.Image")));
            this.btnThemTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemTaiKhoan.ImageOptions.LargeImage")));
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemTaiKhoan_ItemClick);
            // 
            // txtTimeLog
            // 
            this.txtTimeLog.Caption = "Thời Gian:";
            this.txtTimeLog.Id = 11;
            this.txtTimeLog.Name = "txtTimeLog";
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Caption = "Thêm thể loại";
            this.btnThemTheLoai.Id = 12;
            this.btnThemTheLoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTheLoai.ImageOptions.Image")));
            this.btnThemTheLoai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemTheLoai.ImageOptions.LargeImage")));
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemTheLoai_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 13;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng Nhập";
            this.btnLogin.Id = 14;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 15;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // txtName
            // 
            this.txtName.Caption = "Tên:";
            this.txtName.Id = 16;
            this.txtName.Name = "txtName";
            // 
            // btnTCDocGia
            // 
            this.btnTCDocGia.Caption = "Độc giả";
            this.btnTCDocGia.Id = 17;
            this.btnTCDocGia.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTCDocGia.ImageOptions.SvgImage")));
            this.btnTCDocGia.Name = "btnTCDocGia";
            this.btnTCDocGia.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnTCDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTCDocGia_ItemClick);
            // 
            // btnTCSach
            // 
            this.btnTCSach.Caption = "Sách";
            this.btnTCSach.Id = 18;
            this.btnTCSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTCSach.ImageOptions.SvgImage")));
            this.btnTCSach.Name = "btnTCSach";
            this.btnTCSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTCSach_ItemClick);
            // 
            // btnTra
            // 
            this.btnTra.Caption = "Trả";
            this.btnTra.Id = 19;
            this.btnTra.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTra.ImageOptions.SvgImage")));
            this.btnTra.Name = "btnTra";
            this.btnTra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTra_ItemClick);
            // 
            // btnMuon
            // 
            this.btnMuon.Caption = "Mượn";
            this.btnMuon.Id = 20;
            this.btnMuon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMuon.ImageOptions.SvgImage")));
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMuon_ItemClick);
            // 
            // btnThongKeSach
            // 
            this.btnThongKeSach.Caption = "Thống kê sách";
            this.btnThongKeSach.Id = 21;
            this.btnThongKeSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKeSach.ImageOptions.SvgImage")));
            this.btnThongKeSach.Name = "btnThongKeSach";
            this.btnThongKeSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKeSach_ItemClick);
            // 
            // btnTimTK
            // 
            this.btnTimTK.Caption = "Tài Khoản";
            this.btnTimTK.Id = 22;
            this.btnTimTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTK.ImageOptions.Image")));
            this.btnTimTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTimTK.ImageOptions.LargeImage")));
            this.btnTimTK.Name = "btnTimTK";
            this.btnTimTK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnTimTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimTK_ItemClick);
            // 
            // btnTKDocGia
            // 
            this.btnTKDocGia.Caption = "Thống kê độc giả";
            this.btnTKDocGia.Id = 24;
            this.btnTKDocGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTKDocGia.ImageOptions.LargeImage")));
            this.btnTKDocGia.Name = "btnTKDocGia";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu dữ liệu";
            this.btnBackup.Id = 25;
            this.btnBackup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnBackup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.LargeImage")));
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Khôi phục dữ liệu";
            this.btnRestore.Id = 26;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tra cứu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTCDocGia);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTCSach);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTimTK);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tra cứu";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpDangNhap,
            this.rbpgThongTin,
            this.rbpgDangXuat});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tài khoản";
            // 
            // rbpDangNhap
            // 
            this.rbpDangNhap.ItemLinks.Add(this.btnLogin);
            this.rbpDangNhap.Name = "rbpDangNhap";
            this.rbpDangNhap.Text = "Đăng nhập";
            // 
            // rbpgThongTin
            // 
            this.rbpgThongTin.ItemLinks.Add(this.txtName);
            this.rbpgThongTin.ItemLinks.Add(this.txtTimeLog);
            this.rbpgThongTin.ItemLinks.Add(this.btnDoiMatKhau);
            this.rbpgThongTin.Name = "rbpgThongTin";
            this.rbpgThongTin.Text = "Thông tin tài khoản";
            this.rbpgThongTin.Visible = false;
            // 
            // rbpgDangXuat
            // 
            this.rbpgDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbpgDangXuat.ImageOptions.Image")));
            this.rbpgDangXuat.ItemLinks.Add(this.btnDangXuat);
            this.rbpgDangXuat.Name = "rbpgDangXuat";
            this.rbpgDangXuat.Text = "Đăng xuất ";
            this.rbpgDangXuat.Visible = false;
            // 
            // rbpQuanLy
            // 
            this.rbpQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgNhanVien,
            this.rbpgSach,
            this.rbpgDocGia,
            this.rbpgTheLoai,
            this.rbpgTaiKhoan});
            this.rbpQuanLy.Name = "rbpQuanLy";
            this.rbpQuanLy.Text = "Quản lý";
            this.rbpQuanLy.Visible = false;
            // 
            // rbpgNhanVien
            // 
            this.rbpgNhanVien.ItemLinks.Add(this.btnDSNhanVien);
            this.rbpgNhanVien.ItemLinks.Add(this.btnThemNhanVien);
            this.rbpgNhanVien.Name = "rbpgNhanVien";
            this.rbpgNhanVien.Text = "Nhân viên";
            // 
            // rbpgSach
            // 
            this.rbpgSach.ItemLinks.Add(this.btnDSSach);
            this.rbpgSach.ItemLinks.Add(this.btnThemSach);
            this.rbpgSach.Name = "rbpgSach";
            this.rbpgSach.Text = "Sách";
            // 
            // rbpgDocGia
            // 
            this.rbpgDocGia.ItemLinks.Add(this.btnDSDocGia);
            this.rbpgDocGia.ItemLinks.Add(this.btnThemDocGia);
            this.rbpgDocGia.Name = "rbpgDocGia";
            this.rbpgDocGia.Text = "Độc Giả";
            // 
            // rbpgTheLoai
            // 
            this.rbpgTheLoai.ItemLinks.Add(this.btnDSTheLoai);
            this.rbpgTheLoai.ItemLinks.Add(this.btnThemTheLoai);
            this.rbpgTheLoai.Name = "rbpgTheLoai";
            this.rbpgTheLoai.Text = "Thể Loại sách";
            // 
            // rbpgTaiKhoan
            // 
            this.rbpgTaiKhoan.ItemLinks.Add(this.btnDSTaiKhoan);
            this.rbpgTaiKhoan.ItemLinks.Add(this.btnThemTaiKhoan);
            this.rbpgTaiKhoan.Name = "rbpgTaiKhoan";
            this.rbpgTaiKhoan.Text = "Tài Khoản";
            // 
            // rbpThongKe
            // 
            this.rbpThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgTinhTrang});
            this.rbpThongKe.Name = "rbpThongKe";
            this.rbpThongKe.Text = "Thống kê";
            this.rbpThongKe.Visible = false;
            // 
            // rbpgTinhTrang
            // 
            this.rbpgTinhTrang.ItemLinks.Add(this.btnThongKeSach);
            this.rbpgTinhTrang.ItemLinks.Add(this.btnTKDocGia);
            this.rbpgTinhTrang.Name = "rbpgTinhTrang";
            this.rbpgTinhTrang.Text = "Thống kê";
            // 
            // rbpNghiepVu
            // 
            this.rbpNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbpNghiepVu.Name = "rbpNghiepVu";
            this.rbpNghiepVu.Text = "Nghiệp vụ";
            this.rbpNghiepVu.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTra);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMuon);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Mượn/Trả sách";
            // 
            // rbpDuLieu
            // 
            this.rbpDuLieu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpDuLieu.Name = "rbpDuLieu";
            this.rbpDuLieu.Text = "Dữ liệu";
            this.rbpDuLieu.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thao tác trên dữ liệu";
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 550);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THƯ VIỆN";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgDocGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgTheLoai;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgTinhTrang;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnDSNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnThemNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnDSSach;
        private DevExpress.XtraBars.BarButtonItem btnThemSach;
        private DevExpress.XtraBars.BarButtonItem btnDSDocGia;
        private DevExpress.XtraBars.BarButtonItem btnThemDocGia;
        private DevExpress.XtraBars.BarButtonItem btnDSTheLoai;
        private DevExpress.XtraBars.BarButtonItem btnDSTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnThemTaiKhoan;
        private DevExpress.XtraBars.BarStaticItem txtTimeLog;
        private DevExpress.XtraBars.BarButtonItem btnThemTheLoai;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarHeaderItem txtName;
        private DevExpress.XtraBars.BarButtonItem btnTCDocGia;
        private DevExpress.XtraBars.BarButtonItem btnTCSach;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnTra;
        private DevExpress.XtraBars.BarButtonItem btnMuon;
        private DevExpress.XtraBars.BarButtonItem btnThongKeSach;
        private DevExpress.XtraBars.BarButtonItem btnTimTK;
        private DevExpress.XtraBars.BarButtonItem btnTKDocGia;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpDuLieu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.TimeSpanChartRangeControlClient timeSpanChartRangeControlClient1;
    }
}

