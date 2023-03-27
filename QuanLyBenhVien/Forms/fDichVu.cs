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
    public partial class fDichVu : Form
    {
        public fDichVu()
        {
            InitializeComponent();
        }

        private void fDichVu_Load(object sender, EventArgs e)
        {
            //cDichVuId.DataSource = DichVuCommon.Select();
            //cDichVuId.DisplayMember = "TenDichVu";
            //cDichVuId.ValueMember = "Id";

            LoadDS();
            dgv.AutoGenerateColumns = false;
        }
        private void LoadDS()
        {
            dgv.DataSource = DichVuCommon.Select();

        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string TenCot = dgv.Columns[e.ColumnIndex].Name;
                if (dgv.CurrentRow != null)
                    if (dgv.CurrentRow.Cells["cId"].Value.ToString() == "")  // chua co gia tri Id tuc la dong moi
                    {
                        if (TenCot == "cTenDichVu")
                        {
                            // Nếu thêm tên thì mình tạo dòng mới luôn và refresh lại ds
                            DichVuCommon.Insert(dgv.CurrentRow.Cells["cTenDichVu"].Value.ToString(), " ", 1);
                            LoadDS();
                        }
                    }
                    else  // voi dong cu thi update thong tin
                    {
                        if (TenCot == "cTenDichVu")
                        {
                            DichVu HT = new DichVu((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TenDichVu = dgv.CurrentRow.Cells["cTen"].Value.ToString();
                        }
                        if (TenCot == "cLoaiDichVu")
                        {
                            DichVu HT = new DichVu((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.LoaiDichVu = dgv.CurrentRow.Cells["cGhiChu"].Value.ToString();
                        }

                        if (TenCot == "cTrangThaiId")
                        {
                            DichVu HT = new DichVu((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TrangThaiId = (decimal)dgv.CurrentRow.Cells["cTrangThaiId"].Value;
                        }

                        //if (TenCot == "cDichVuId")
                        //{
                        //    DichVu HT = new DichVu((decimal)dgv.CurrentRow.Cells["cId"].Value);
                        //    HT.DichVuId = (decimal) dgv.CurrentRow.Cells["cDichVuId"].Value;
                        //}
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
