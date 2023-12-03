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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string mlogin = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            if (Program.Connect() == 0)
                return;
            string query = "EXEC SP_DangNhap '" + mlogin + "'"+",'"+password+"'";
            Program.myReader = Program.execSqlDataReader(query);
            if (Program.myReader == null)
                return;
            Program.myReader.Read();
            try
            {
                Program.ten = Program.myReader.GetString(0);
                Program.quyen = Program.myReader.GetString(1);
            }
            catch
            {
                MessageBox.Show("Sai Tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Console.WriteLine(Program.ten + " " + Program.quyen);
           Program.formMain.tssQuyen.Text = "Quyen: "+ Program.quyen;

            Program.formMain.tssTen.Text = "Ten: " + Program.ten;
            Program.formMain.rbNV.Visible = true;
            if (Program.quyen.Equals("QL"))
                Program.formMain.rbQL.Visible = true;
            Program.myReader.Close();
            Program.conn.Close();
            Close();



        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
