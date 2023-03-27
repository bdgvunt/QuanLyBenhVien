using QuanLyBenhVien.cs;
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
   
    public partial class fXuatKho : Form
    {
        decimal PhieuXuatId;
        PhieuXuat PhieuXuatHT;
        public fXuatKho()
        {
            InitializeComponent();
        }

        private void fXuatKho_Load(object sender, EventArgs e)
        {
            clMaThuoc.DataSource = KhoThuocCommon.Select();
            clMaThuoc.DisplayMember = "MaThuoc";
            clMaThuoc.ValueMember = "Id";
            dgvChiTietPhieuXuat.AutoGenerateColumns = false;
            LoadDSPhieu();

        }
        private void LoadDSPhieu()
        {
            dgvDanhSachPhieuXuat.DataSource = PhieuXuatCommon.PhieuXuat_Select_Ngay(dtpNgayLapPhieu.Value);
        }

        private void btTaoPhieuXuat_Click(object sender, EventArgs e)
        {
            //tao phieu xuat
            PhieuXuatId = PhieuXuatCommon.Insert(Common.NhanVienHT.Id, DateTime.Now, DateTime.Now, Common.NhanVienHT.Id, tbGhiChu.Text, 1, 1);
            MessageBox.Show("Nhập Thành Công");
            LoadDS();

        }
        private void LoadDS()
        {
            dgvChiTietPhieuXuat.DataSource = ChiTietPhieuNhapCommon.Select_field("MaPhieuXuat", new object[] { PhieuXuatId });
        }

        private void dgvChiTietPhieuXuat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (PhieuXuatId == null)
                {
                    MessageBox.Show("Chưa Nhập Phiếu");
                    return;
                }
                PhieuXuatHT = new PhieuXuat(PhieuXuatId);
                //if (PhieuXuatId.TinhTrangId == 2)
                //{
                //    MessageBox.Show("Phiếu này đã nhập không thể chỉnh sửa");
                //    return;
                //}
                string TenCot = dgvChiTietPhieuXuat.Columns[e.ColumnIndex].Name;

                if (dgvChiTietPhieuXuat.CurrentRow != null)
                    if (dgvChiTietPhieuXuat.CurrentRow.Cells["cId"].Value.ToString() == "")  // chua co gia tri Id tuc la dong moi
                    {
                        if (TenCot == "clMaThuoc")
                        {
                            // Nếu thêm tên thì mình tạo dòng mới luôn và refresh lại ds
                            decimal ChitietPhieuXuatId = ChiTietPhieuXuatCommon.Insert(PhieuXuatId, 1, 1, 1);
                            LoadDS();
                        }
                    }
                    else  // voi dong cu thi update thong tin nếu phiếu nhập ID > 0
                    {

                        if (TenCot == "clMaKhoThuoc")
                        {
                            ChiTietPhieuXuat HT = new ChiTietPhieuXuat((decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["cId"].Value);
                            HT.MaKhoThuoc = (decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["clMaKhoThuoc"].Value;
                        }
                    
                        if (TenCot == "clSoLuong")
                        {
                            ChiTietPhieuXuat HT = new ChiTietPhieuXuat((decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["cId"].Value);
                            HT.SoLuong = (decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["clSoLuong"].Value;
                        }
                        if (TenCot == "clTrangThaiId")
                        {
                            ChiTietPhieuXuat HT = new ChiTietPhieuXuat((decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["cId"].Value);
                            HT.TrangThaiId = (decimal)dgvChiTietPhieuXuat.CurrentRow.Cells["clTrangThaiId"].Value;
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
