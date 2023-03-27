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
    public partial class fNhanVien : Form
    {
        public fNhanVien()
        {
            InitializeComponent();
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            //cDichVuId.DataSource = DichVuCommon.Select();
            //cDichVuId.DisplayMember = "TenDichVu";
            //cDichVuId.ValueMember = "Id";

            LoadDS();
            dgv.AutoGenerateColumns = false;
        }
        private void LoadDS()
        {
            dgv.DataSource = NhanVienCommon.Select();

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
                            NhanVienCommon.Insert(dgv.CurrentRow.Cells["cTenNhanVien"].Value.ToString(), ""," "," " ,1, ""," ", 1);
                            LoadDS();
                        }
                    }
                    else  // voi dong cu thi update thong tin
                    {
                        if (TenCot == "cTenNhanVien")
                        {
                            NhanVien HT = new NhanVien((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.TenNhanVien = dgv.CurrentRow.Cells["cTenNhanVien"].Value.ToString();
                        }
                        if (TenCot == "cChuyenMon")
                        {
                            NhanVien HT = new NhanVien((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.ChuyenMon = dgv.CurrentRow.Cells["cChuyenMon"].Value.ToString();
                        }
                        if (TenCot == "cKhoa")
                        {
                            NhanVien HT = new NhanVien((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.Khoa = dgv.CurrentRow.Cells["cKhoa"].Value.ToString();
                        }
                        if (TenCot == "cChucVu")
                        {
                            NhanVien HT = new NhanVien((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.Chucvu = dgv.CurrentRow.Cells["cChucVu"].Value.ToString();
                        }
                        if (TenCot == "cMaHanhNghe")
                        {
                            NhanVien HT = new NhanVien((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.MaHanhNghe = (decimal)dgv.CurrentRow.Cells["cMaHanhNghe"].Value;
                        }
                        if (TenCot == "cUserName")
                        {
                            NhanVien HT = new NhanVien((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.Username = dgv.CurrentRow.Cells["cUserName"].Value.ToString();
                        }
                        if (TenCot == "cPassWord")
                        {
                            NhanVien HT = new NhanVien((decimal)dgv.CurrentRow.Cells["cId"].Value);
                            HT.Password = dgv.CurrentRow.Cells["cPassWord"].Value.ToString();
                        }
                        if (TenCot == "cTinhTrangId")
                        {
                            NhanVien HT = new NhanVien((decimal)dgv.CurrentRow.Cells["cId"].Value);
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
