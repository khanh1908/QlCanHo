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
    public partial class FormKhachHang : Form
    {
        string flag = "";
        int vitri = 0;
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.qLBanCanHoDataSet.TaiKhoan);
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLBanCanHoDataSet.KHACHHANG);

        }
        //btt save
        private void button1_Click(object sender, EventArgs e)
        {
            if (tenKHTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống !", "", MessageBoxButtons.OK);
                tenKHTextEdit.Focus();
                return;
            }

            if (diaChiKHTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được để trống !", "", MessageBoxButtons.OK);
                diaChiKHTextEdit.Focus();
                return;
            }

            if (maSoThueTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã số thuế không được để trống !", "", MessageBoxButtons.OK);
                maSoThueTextEdit.Focus();
                return;
            }

            if (tKNganHangTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản ngân hàng không được để trống!", "", MessageBoxButtons.OK);
                tKNganHangTextEdit.Focus();
                return;
            }
            if (soDTKHTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không đúng định dạng.\nHãy chắc chắn sdt có 10 chữ số và bắt đầu với 0 !", "", MessageBoxButtons.OK);
                soDTKHTextEdit.Focus();
                return;
            }
            if (emailKHTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Email không được để trống!", "", MessageBoxButtons.OK);
                emailKHTextEdit.Focus();
                return;
            }

            if (flag == "add")
            {
    
                try
                {
                    kHACHHANGBindingSource.EndEdit();
                    kHACHHANGBindingSource.ResetCurrentItem();
                    //string queryInsert = "EXEC InsertKhachHang '"
                    //                + txtCMND.Text + "', N'"
                    //                + txtHo.Text + "', N'"
                    //                + txtTen.Text + "', N'"
                    //                + txtDiaChi.Text + "', N'"
                    //                + cbxPhai.SelectedText.ToString() + "', '"
                    //                + deNgayCap.Text + "', '"
                    //                + txtSDT.Text + "', '"
                    //                + txtMaCN.Text + "'";
                    //Program.execSqlNonQuery(queryInsert);
                    this.kHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHACHHANGTableAdapter.Update(this.qLBanCanHoDataSet.KHACHHANG);
                }
                catch (Exception ex)
                {
                    kHACHHANGBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (flag == "edit")
            {
                try
                {
                    kHACHHANGBindingSource.EndEdit();
                    kHACHHANGBindingSource.ResetCurrentItem();
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
                    this.kHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHACHHANGTableAdapter.Update(this.qLBanCanHoDataSet.KHACHHANG);
                }
                catch (Exception ex)
                {
                    kHACHHANGBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (flag.Equals("add"))
                barbttSua.Enabled = barbttXoa.Enabled = true;
            else
                barbttThem.Enabled = barbttXoa.Enabled = true;

        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            if(flag.Equals("add"))
                barbttSua.Enabled = barbttXoa.Enabled = true;
            else
                barbttThem.Enabled = barbttXoa.Enabled = true;
            kHACHHANGBindingSource.CancelEdit();
            kHACHHANGBindingSource.Position = vitri;
        }
        //btt them
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = kHACHHANGBindingSource.Position;
            barbttSua.Enabled = barbttXoa.Enabled = false;
            bttCancel.Enabled = bttSave.Enabled = true;
            kHACHHANGBindingSource.AddNew();

            flag = "add";

        }

        private void barbttSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = kHACHHANGBindingSource.Position;
            barbttThem.Enabled = barbttXoa.Enabled = false;
            bttCancel.Enabled = bttSave.Enabled = true;
            flag = "edit";
            
        }

        private void barbttXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          



            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    kHACHHANGBindingSource.RemoveCurrent();
                    this.kHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHACHHANGTableAdapter.Update(this.qLBanCanHoDataSet.KHACHHANG);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.kHACHHANGTableAdapter.Fill(this.qLBanCanHoDataSet.KHACHHANG);
                   
                    return;
                }
            }
            if (kHACHHANGBindingSource.Count == 0)
                barbttXoa.Enabled = false;
        }


    }
}
