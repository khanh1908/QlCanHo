using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlBanCanHo
{
    public partial class FormTaiKhoan : Form
    {
        string flag = "";
        int vitri = 0;
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBanCanHoDataSet);

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.qLBanCanHoDataSet.TaiKhoan);

        }

        private void barbttSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = taiKhoanBindingSource.Position;
            barbttXoa.Enabled = false;
            bttCancel.Enabled = bttSave.Enabled = true;
            flag = "edit";
        }

        private void barbttXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa tài khoản này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    taiKhoanBindingSource.RemoveCurrent();
                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.taiKhoanTableAdapter.Update(this.qLBanCanHoDataSet.TaiKhoan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tài khoản. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.taiKhoanTableAdapter.Fill(this.qLBanCanHoDataSet.TaiKhoan);

                    return;
                }
            }
            if ( taiKhoanBindingSource.Count == 0)
                barbttXoa.Enabled = false;
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            try
            {
                taiKhoanBindingSource.EndEdit();
                taiKhoanBindingSource.ResetCurrentItem();
                //string queryUpdate = "EXEC UpdateKhachHang '"
                //                + cmndcu + "', '"
                //                + txtCMND.Text + "', N'"
                //                + txtHo.Text + "', N'"
                //                + txtTen.Text + "', N'"
                //                + txtDiaChi.Text + "', N'"
                //                + cbxPhai.SelectedText.ToString() + "', '"
                //                + deNgayCap.Text + "', '"
                //                + txtSDT.Text + "'";
                //Program.execSqlNonQuery(queryUpdate);
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Update(this.qLBanCanHoDataSet.TaiKhoan);
            }
            catch (Exception ex)
            {
                taiKhoanBindingSource.RemoveCurrent();
                MessageBox.Show("Lỗi chỉnh sửa loại căn hộ.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            if (flag.Equals("edit"))
            {

                barbttXoa.Enabled = true;
            }
            else
                 barbttSua.Enabled = true;
            bttCancel.Enabled = bttSave.Enabled = false;
            taiKhoanBindingSource.CancelEdit();
            taiKhoanBindingSource.Position = vitri;
        }
    }
}
