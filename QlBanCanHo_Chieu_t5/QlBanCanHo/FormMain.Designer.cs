
namespace QlBanCanHo
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_KhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_qlCanHo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QlNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_qlBoPhan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_qlTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQL = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssQuyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_DangNhap,
            this.btn_KhachHang,
            this.btn_qlCanHo,
            this.btn_QlNhanVien,
            this.btn_qlBoPhan,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btn_qlTaiKhoan,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.rbQL,
            this.rbNV,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 193);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Caption = "Đăng nhập";
            this.btn_DangNhap.Id = 1;
            this.btn_DangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.Image")));
            this.btn_DangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.LargeImage")));
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangNhap_ItemClick);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.Caption = "Quản Lý Khách Hàng";
            this.btn_KhachHang.Id = 2;
            this.btn_KhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.ImageOptions.Image")));
            this.btn_KhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.ImageOptions.LargeImage")));
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_KhachHang_ItemClick);
            // 
            // btn_qlCanHo
            // 
            this.btn_qlCanHo.Caption = "Quản Lý Căn Hộ";
            this.btn_qlCanHo.Id = 3;
            this.btn_qlCanHo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlCanHo.ImageOptions.Image")));
            this.btn_qlCanHo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_qlCanHo.ImageOptions.LargeImage")));
            this.btn_qlCanHo.Name = "btn_qlCanHo";
            this.btn_qlCanHo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_qlCanHo_ItemClick);
            // 
            // btn_QlNhanVien
            // 
            this.btn_QlNhanVien.Caption = "Quản Lý Nhân Viên";
            this.btn_QlNhanVien.Id = 4;
            this.btn_QlNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QlNhanVien.ImageOptions.Image")));
            this.btn_QlNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QlNhanVien.ImageOptions.LargeImage")));
            this.btn_QlNhanVien.Name = "btn_QlNhanVien";
            this.btn_QlNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QlNhanVien_ItemClick);
            // 
            // btn_qlBoPhan
            // 
            this.btn_qlBoPhan.Caption = "Quản Lý Bộ Phận";
            this.btn_qlBoPhan.Id = 5;
            this.btn_qlBoPhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlBoPhan.ImageOptions.Image")));
            this.btn_qlBoPhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_qlBoPhan.ImageOptions.LargeImage")));
            this.btn_qlBoPhan.Name = "btn_qlBoPhan";
            this.btn_qlBoPhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_qlBoPhan_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Quản lý Loại Căn Hộ";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thoát";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btn_qlTaiKhoan
            // 
            this.btn_qlTaiKhoan.Caption = "Quản lý Tài Khoản";
            this.btn_qlTaiKhoan.Id = 8;
            this.btn_qlTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlTaiKhoan.ImageOptions.Image")));
            this.btn_qlTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_qlTaiKhoan.ImageOptions.LargeImage")));
            this.btn_qlTaiKhoan.Name = "btn_qlTaiKhoan";
            this.btn_qlTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_qlTaiKhoan_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thống kê căn hộ";
            this.barButtonItem3.Id = 9;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbQL
            // 
            this.rbQL.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbQL.Name = "rbQL";
            this.rbQL.Text = "Quản lý";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_QlNhanVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_qlBoPhan);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_qlTaiKhoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rbNV
            // 
            this.rbNV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbNV.Name = "rbNV";
            this.rbNV.Text = "Nhân Viên";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_KhachHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_qlCanHo);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Thống kê";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTen,
            this.tssQuyen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(884, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssTen
            // 
            this.tssTen.Name = "tssTen";
            this.tssTen.Size = new System.Drawing.Size(32, 20);
            this.tssTen.Text = "Ten";
            this.tssTen.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tssQuyen
            // 
            this.tssQuyen.Name = "tssQuyen";
            this.tssQuyen.Size = new System.Drawing.Size(51, 20);
            this.tssQuyen.Text = "Quyen";
            this.tssQuyen.Click += new System.EventHandler(this.tssQuyen_Click);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Giao Dịch";
            this.barButtonItem4.Id = 10;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_DangNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_KhachHang;
        private DevExpress.XtraBars.BarButtonItem btn_qlCanHo;
        private DevExpress.XtraBars.BarButtonItem btn_QlNhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_qlBoPhan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tssQuyen;
        public System.Windows.Forms.ToolStripStatusLabel tssTen;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbNV;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbQL;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_qlTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}

