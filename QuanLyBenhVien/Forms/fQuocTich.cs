using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.Forms
{
    public partial class fQuocTich : Form
    {
        public fQuocTich()
        {
            InitializeComponent();
        }

        private void fQuocTich_Load(object sender, EventArgs e)
        {
            //cDichVuId.DataSource = DichVuCommon.Select();
            //cDichVuId.DisplayMember = "TenDichVu";
            //cDichVuId.ValueMember = "Id";

            LoadDS();
            dgv.AutoGenerateColumns = false;
        }
        private void LoadDS()
        {
            dgv.DataSource = QuocTichCommon.Select();

        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string TenCot = dgv.Columns[e.ColumnIndex].Name;
                if (dgv.CurrentRow != null)
                    if (dgv.CurrentRow.Cells["cId"].Value.ToString() == "")  // chua co gia tri Id tuc la dong moi
                    {
                        if (TenCot == "cTenQuocTich")
                        {
                            // Nếu thêm tên thì mình tạo dòng mới luôn và refresh lại ds
                            QuocTichCommon.Insert(dgv.CurrentRow.Cells["cTenQuocTich"].Value.ToString(), "",  1);
                            LoadDS();
                        }
                    }
                    else  // voi dong cu thi update thong tin
                    {
                        if (TenCot == "cTenQuocTich")
                        {
                            QuocTich HT = new QuocTich((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TenQuocTich = dgv.CurrentRow.Cells["cTenQuocTich"].Value.ToString();
                        }
                        if (TenCot == "cGhiChu")
                        {
                            QuocTich HT = new QuocTich((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.GhiChu = dgv.CurrentRow.Cells["cGhiChu"].Value.ToString();
                        }

                        if (TenCot == "cTinhTrangId")
                        {
                            QuocTich HT = new QuocTich((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TrangThaiId = (decimal)dgv.CurrentRow.Cells["cTrangThaiId"].Value;
                        }

                        
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
