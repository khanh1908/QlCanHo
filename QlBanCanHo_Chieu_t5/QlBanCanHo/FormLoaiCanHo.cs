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
    public partial class FormLoaiCanHo : Form
    {
        string flag = "";
        int vitri = 0;
        public FormLoaiCanHo()
        {

            InitializeComponent();
            maLoaiCHTextEdit.Enabled = false;
        }

        private void loaiCanHoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loaiCanHoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBanCanHoDataSet);

        }

        private void FormLoaiCanHo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.LoaiCanHo' table. You can move, or remove it, as needed.
            this.loaiCanHoTableAdapter.Fill(this.qLBanCanHoDataSet.LoaiCanHo);

        }

        private void barbttThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = loaiCanHoBindingSource.Position;
            barbttSua.Enabled = barbttXoa.Enabled = false;
            bttCancel.Enabled = bttSave.Enabled = true;
            loaiCanHoBindingSource.AddNew();

            flag = "add";
        }

        private void barbttXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa loại căn hộ này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    loaiCanHoBindingSource.RemoveCurrent();
                    this.loaiCanHoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.loaiCanHoTableAdapter.Update(this.qLBanCanHoDataSet.LoaiCanHo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa loại căn hộ. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.loaiCanHoTableAdapter.Fill(this.qLBanCanHoDataSet.LoaiCanHo);

                    return;
                }
            }
            if (loaiCanHoBindingSource.Count == 0)
                barbttXoa.Enabled = false;
        }

        private void barbttSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = loaiCanHoBindingSource.Position;
            barbttThem.Enabled = barbttXoa.Enabled = false;
            bttCancel.Enabled = bttSave.Enabled = true;
            flag = "edit";
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            if (flag.Equals("add"))
            {

                barbttSua.Enabled = barbttXoa.Enabled = true;
            }
            else
                barbttThem.Enabled = barbttXoa.Enabled = true;
            bttCancel.Enabled = bttSave.Enabled = false;
            loaiCanHoBindingSource.CancelEdit();
            loaiCanHoBindingSource.Position = vitri;
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {

                try
                {
                    loaiCanHoBindingSource.EndEdit();
                    loaiCanHoBindingSource.ResetCurrentItem();



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
                    this.loaiCanHoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.loaiCanHoTableAdapter.Update(this.qLBanCanHoDataSet.LoaiCanHo);

                }
                catch (Exception ex)
                {
                    loaiCanHoBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm loại căn hộ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (flag == "edit")
            {
                try
                {
                    loaiCanHoBindingSource.EndEdit();
                    loaiCanHoBindingSource.ResetCurrentItem();
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
                    this.loaiCanHoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.loaiCanHoTableAdapter.Update(this.qLBanCanHoDataSet.LoaiCanHo);
                }
                catch (Exception ex)
                {
                    loaiCanHoBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa loại căn hộ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (flag.Equals("add"))
                barbttSua.Enabled = barbttXoa.Enabled = true;
            else
                barbttThem.Enabled = barbttXoa.Enabled = true;
            bttCancel.Enabled = bttSave.Enabled = false;
        }
    }
}
