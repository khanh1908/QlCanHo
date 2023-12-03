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
    public partial class FormNhanVien : Form
    {
        string flag= "";
        int vitri =0  ;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBanCanHoDataSet);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.BOPHAN' table. You can move, or remove it, as needed.
            this.bOPHANTableAdapter.Fill(this.qLBanCanHoDataSet.BOPHAN);
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.qLBanCanHoDataSet.TaiKhoan);
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLBanCanHoDataSet.NHANVIEN);

        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {

                try
                {
                    nHANVIENBindingSource.EndEdit();
                    nHANVIENBindingSource.ResetCurrentItem();
                    
                    
                    string query = "EXEC sp_CreateEmployee '" + maBPComboBox.SelectedValue.ToString().Trim() 
                        + "'" + ",'" + hoVaTenTextEdit.Text.ToString().Trim() + "'"
                        + ",'" + gioiTinhComboBox.Text.ToString() +"'" 
                        + ",'"+ ngaySinhDateEdit.DateTime.ToString("yyyy-MM-dd")
                        +"','"+ ngayVaoLamDateEdit.DateTime.ToString("yyyy-MM-dd")
                        + "','"+ cCCDTextEdit.Text + "'"
                        +",'"+ diaChiCuTruTextEdit.Text + "'"
                        +",'"+ soDTTextEdit.Text + "'"
                        +",'"+ emailNVTextEdit.Text +"'"
                        + ",'"+ taiKhoanTextEdit.Text + "'"
                        +",'"+matKhauTextEdit.Text+ "'";
                    Console.WriteLine(query);
                    Program.myReader = Program.execSqlDataReader(query);
                    if (Program.myReader == null)
                        return;
                    Program.myReader.Read();
                    
                    int so = Program.myReader.GetInt32(0);
                    Program.myReader.Close();

                    switch (so)
                    {
                        case 0:
                            MessageBox.Show("Tài khoản đã tồn tại.\n" , "", MessageBoxButtons.OK);
                            break;
                        case 1:
                            MessageBox.Show("Căn cước công dân đã tồn tại.\n", "", MessageBoxButtons.OK);
                            break;
                        case 2:
                            MessageBox.Show("Email đã tồn tại.\n", "", MessageBoxButtons.OK);
                            break;
                        case 3:
                            MessageBox.Show("Số điện thoại đã tồn tại.\n", "", MessageBoxButtons.OK);
                            break;
                        case 4:
                            MessageBox.Show("Tạo thành công.\n", "", MessageBoxButtons.OK);
                            taiKhoanLabel.Visible = matKhauLabel.Visible = false;
                            break;
                        
                    }

                }
                catch (Exception ex)
                {
                    nHANVIENBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi thêm khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (flag == "edit")
            {
                try
                {
                    nHANVIENBindingSource.EndEdit();
                    nHANVIENBindingSource.ResetCurrentItem();
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
                    this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHANVIENTableAdapter.Update(this.qLBanCanHoDataSet.NHANVIEN);
                }
                catch (Exception ex)
                {
                    nHANVIENBindingSource.RemoveCurrent();
                    MessageBox.Show("Lỗi chỉnh sửa khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (flag.Equals("add"))
                barbttSua.Enabled = barbttXoa.Enabled = true;
            else
                barbttThem.Enabled = barbttXoa.Enabled = true;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            if (flag.Equals("add"))
            {
                taiKhoanLabel.Visible = matKhauLabel.Visible = false;
                barbttSua.Enabled = barbttXoa.Enabled = true;
            }
            else
                barbttThem.Enabled = barbttXoa.Enabled = true;
            nHANVIENBindingSource.CancelEdit();
            nHANVIENBindingSource.Position = vitri;
        }

        private void barbttThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nHANVIENBindingSource.Position;
            barbttSua.Enabled = barbttXoa.Enabled = false;
            bttCancel.Enabled = bttSave.Enabled = true;
            nHANVIENBindingSource.AddNew();
            matKhauTextEdit.Visible = taiKhoanTextEdit.Visible = taiKhoanLabel.Visible= matKhauLabel.Visible=  true;
            flag = "add";
        }

        private void barbttXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    nHANVIENBindingSource.RemoveCurrent();
                    this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHANVIENTableAdapter.Update(this.qLBanCanHoDataSet.NHANVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Bạn hãy xóa lại.\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nHANVIENTableAdapter.Fill(this.qLBanCanHoDataSet.NHANVIEN);

                    return;
                }
            }
            if (nHANVIENBindingSource.Count == 0)
                barbttXoa.Enabled = false;
        }

        private void barbttSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nHANVIENBindingSource.Position;
            barbttThem.Enabled = barbttXoa.Enabled = false;
            bttCancel.Enabled = bttSave.Enabled = true;
            flag = "edit";
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            if(textEdit1.Text != "")
            {

            }
        }
    }
}
