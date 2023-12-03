using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QlBanCanHo
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            this.rbNV.Visible = false;
            this.rbQL.Visible = false;
            this.IsMdiContainer = true;
        }
        public Form checkExist(Type ftype)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btn_DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form form = checkExist(typeof(FormLogin)) as FormLogin;
            if (form != null)
                form.Activate();
            else
            {
                FormLogin formLogin = new FormLogin();
                formLogin.MdiParent = this.MdiParent;
                formLogin.Show();
            }
           
        }

        private void btn_KhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormKhachHang formkhachhang = new FormKhachHang();
            formkhachhang.MdiParent = this;
            formkhachhang.Show();
        }

        private void btn_QlNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNhanVien formnhanvien = new FormNhanVien();
            formnhanvien.MdiParent = this;
            formnhanvien.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tssQuyen_Click(object sender, EventArgs e)
        {

        }

        private void btn_qlBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBoPhan formbophan = new FormBoPhan();
            formbophan.MdiParent = this;
            formbophan.Show();
        }

        private void btn_qlCanHo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormQLCanHo formqlcanho = new FormQLCanHo();
            formqlcanho.MdiParent = this;
            formqlcanho.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLoaiCanHo formloaicanho = new FormLoaiCanHo();
            formloaicanho.MdiParent = this;
            formloaicanho.Show();
        }

        private void btn_qlTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTaiKhoan formtk = new FormTaiKhoan();
            formtk.MdiParent = this;
            formtk.Show();
        }
        //btt thoat
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongKeCanHo thongkecanho = new ThongKeCanHo();
            ReportPrintTool print = new ReportPrintTool(thongkecanho);
            thongkecanho.ShowPreviewDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MuaCanHo muacanho = new MuaCanHo();
            muacanho.MdiParent = this;
            muacanho.Show();
        }
    }
}
