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
    public partial class fDonViTinh : Form
    {
        public fDonViTinh()
        {
            InitializeComponent();
        }

        private void fDonViTinh_Load(object sender, EventArgs e)
        {
            //cDichVuId.DataSource = DichVuCommon.Select();
            //cDichVuId.DisplayMember = "TenDichVu";
            //cDichVuId.ValueMember = "Id";

            LoadDS();
            dgv.AutoGenerateColumns = false;
        }
        private void LoadDS()
        {
            dgv.DataSource = DonViTinhCommon.Select();

        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string TenCot = dgv.Columns[e.ColumnIndex].Name;
                if (dgv.CurrentRow != null)
                    if (dgv.CurrentRow.Cells["cId"].Value.ToString() == "")  // chua co gia tri Id tuc la dong moi
                    {
                        if (TenCot == "cTenDonViTinh")
                        {
                            // Nếu thêm tên thì mình tạo dòng mới luôn và refresh lại ds
                            DonViTinhCommon.Insert(dgv.CurrentRow.Cells["cTenDonViTinh"].Value.ToString(), "", 1, 1);
                            LoadDS();
                        }
                    }
                    else  // voi dong cu thi update thong tin
                    {
                        if (TenCot == "cTenDonViTinh")
                        {
                            DonViTinh HT = new DonViTinh((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TenDonViTinh = dgv.CurrentRow.Cells["cTenDonViTinh"].Value.ToString();
                        }
                        if (TenCot == "cGhiChu")
                        {
                            DonViTinh HT = new DonViTinh((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.GhiChu = dgv.CurrentRow.Cells["cGhiChu"].Value.ToString();
                        }

                        if (TenCot == "cTinhTrangId")
                        {
                            DonViTinh HT = new DonViTinh((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TinhTrangId = (decimal)dgv.CurrentRow.Cells["cTinhTrangId"].Value;
                        }

                        if (TenCot == "cTrangThaiId")
                        {
                            DonViTinh HT = new DonViTinh((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TrangThaiId = (decimal) dgv.CurrentRow.Cells["cTrangThaiId"].Value;
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
