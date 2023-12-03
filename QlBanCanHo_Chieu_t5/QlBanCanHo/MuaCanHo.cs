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
    public partial class MuaCanHo : Form
    {
        public MuaCanHo()
        {
            InitializeComponent();
        }

        private void giaoDichBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.giaoDichBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLBanCanHoDataSet);

        }

        private void MuaCanHo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.HoaDonDienTu' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.CTGiaoDich' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.ChungTuBanGiao' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLBanCanHoDataSet.GiaoDich' table. You can move, or remove it, as needed.
            this.hoaDonDienTuTableAdapter.Fill(this.qLBanCanHoDataSet.HoaDonDienTu);
            this.chungTuBanGiaoTableAdapter.Fill(this.qLBanCanHoDataSet.ChungTuBanGiao);
            this.giaoDichTableAdapter.Fill(this.qLBanCanHoDataSet.GiaoDich);
            this.cTGiaoDichTableAdapter.Fill(this.qLBanCanHoDataSet.CTGiaoDich);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
