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
    public partial class fLoaiKham : Form
    {
        public fLoaiKham()
        {
            InitializeComponent();
        }

        private void fLoaiKham_Load(object sender, EventArgs e)
        {
            cDichVuId.DataSource = DichVuCommon.Select();
            cDichVuId.DisplayMember = "TenDichVu";
            cDichVuId.ValueMember = "Id";

            LoadDS();
            dgv.AutoGenerateColumns = false;
        }
        private void LoadDS()
        {
            dgv.DataSource = LoaiKhamCommon.Select();

        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string TenCot = dgv.Columns[e.ColumnIndex].Name;
                if (dgv.CurrentRow != null)
                    if (dgv.CurrentRow.Cells["cId"].Value.ToString() == "")  // chua co gia tri Id tuc la dong moi
                    {
                        if (TenCot == "cTen")
                        {
                            // Nếu thêm tên thì mình tạo dòng mới luôn và refresh lại ds
                            LoaiKhamCommon.Insert(dgv.CurrentRow.Cells["cTen"].Value.ToString(), "", 1, 1, 1);
                            LoadDS();
                        }
                    }
                    else  // voi dong cu thi update thong tin
                    {
                        if (TenCot == "cTen")
                        {
                            LoaiKham HT = new LoaiKham((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TenLoaiKham = dgv.CurrentRow.Cells["cTen"].Value.ToString();
                        }
                        if (TenCot == "cGhiChu")
                        {
                            LoaiKham HT = new LoaiKham((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.GhiChu = dgv.CurrentRow.Cells["cGhiChu"].Value.ToString();
                        }

                        if (TenCot == "cTinhTrangId")
                        {
                            LoaiKham HT = new LoaiKham((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TinhTrangId = (decimal)dgv.CurrentRow.Cells["cTinhTrangId"].Value;
                        }

                        if (TenCot == "cDichVuId")
                        {
                            LoaiKham HT = new LoaiKham((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.DichVuId = (decimal) dgv.CurrentRow.Cells["cDichVuId"].Value;
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
