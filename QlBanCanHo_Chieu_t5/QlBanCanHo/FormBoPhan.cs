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
    public partial class FormBoPhan : Form
    {
        public FormBoPhan()
        {
            InitializeComponent();
        }

        private void bOPHANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOPHANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBanCanHoDataSet);

        }

        private void FormBoPhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.BOPHAN' table. You can move, or remove it, as needed.
            this.bOPHANTableAdapter.Fill(this.qLBanCanHoDataSet.BOPHAN);

        }

        private void bttSave_Click(object sender, EventArgs e)
        {

        }

        private void bttCancel_Click(object sender, EventArgs e)
        {

        }

        private void barbttThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barbttXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barbttSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
