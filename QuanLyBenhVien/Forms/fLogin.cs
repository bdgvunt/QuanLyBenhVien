using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhVien.cs;

namespace QuanLyBenhVien
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = NhanVienCommon.Select_field("Username", new object[] { txbUserName.Text });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Password"].ToString() == txbPassWord.Text)
                    {
                        Common.NhanVienHT = new NhanVien((decimal)dt.Rows[i]["Id"]);
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Đăng nhập không thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }     
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát không ?","Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}    
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
