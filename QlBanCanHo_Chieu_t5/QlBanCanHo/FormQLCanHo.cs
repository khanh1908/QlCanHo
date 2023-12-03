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
    public partial class FormQLCanHo : Form
    {
        string flag = "";
        int vitri = 0;
        public FormQLCanHo()
        {
            InitializeComponent();
        }

        private void canHoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.canHoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBanCanHoDataSet);

        }

        private void FormQLCanHo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.LoaiCanHo' table. You can move, or remove it, as needed.
            this.loaiCanHoTableAdapter.Fill(this.qLBanCanHoDataSet.LoaiCanHo);
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.CTGiaoDich' table. You can move, or remove it, as needed.
            this.cTGiaoDichTableAdapter.Fill(this.qLBanCanHoDataSet.CTGiaoDich);
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.CanHoTon' table. You can move, or remove it, as needed.
            this.canHoTonTableAdapter.Fill(this.qLBanCanHoDataSet.CanHoTon);
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.CanHo' table. You can move, or remove it, as needed.
            this.canHoTableAdapter.Fill(this.qLBanCanHoDataSet.CanHo);

        }

        private void canHoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void barbttThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = canHoBindingSource.Position;
            barbttSua.Enabled = barbttXoa.Enabled = false;
            bttCancel.Enabled = bttSave.Enabled = true;
            canHoBindingSource.AddNew();

            flag = "add";
        }

        private void barbttXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa loại căn hộ này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    canHoBindingSource.RemoveCurrent();
                    this.canHoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.canHoTableAdapter.Update(this.qLBanCanHoDataSet.CanHo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa loại căn hộ. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.canHoTableAdapter.Fill(this.qLBanCanHoDataSet.CanHo);

                    return;
                }
            }
            if (loaiCanHoBindingSource.Count == 0)
                barbttXoa.Enabled = false;
        }

        private void barbttSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = canHoBindingSource.Position;
            barbttThem.Enabled = barbttXoa.Enabled = false;
            bttCancel.Enabled = bttSave.Enabled = true;
            flag = "edit";
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {

                try
                {
                    canHoBindingSource.EndEdit();
                    canHoBindingSource.ResetCurrentItem();



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
                    this.canHoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.canHoTableAdapter.Update(this.qLBanCanHoDataSet.CanHo);

                }
                catch (Exception ex)
                {
                    canHoBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm loại căn hộ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (flag == "edit")
            {
                try
                {
                    canHoBindingSource.EndEdit();
                    canHoBindingSource.ResetCurrentItem();
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
                    this.canHoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.canHoTableAdapter.Update(this.qLBanCanHoDataSet.CanHo);
                }
                catch (Exception ex)
                {
                    canHoBindingSource.RemoveCurrent();
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

        private void bttCancel_Click(object sender, EventArgs e)
        {

            if (flag.Equals("add"))
            {

                barbttSua.Enabled = barbttXoa.Enabled = true;
            }
            else
                barbttThem.Enabled = barbttXoa.Enabled = true;
            bttCancel.Enabled = bttSave.Enabled = false;
            canHoBindingSource.CancelEdit();
            canHoBindingSource.Position = vitri;
        }
    }
}
