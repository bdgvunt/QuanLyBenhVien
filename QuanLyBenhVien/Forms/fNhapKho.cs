using QuanLyBenhVien.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien.Forms
{
    public partial class fNhapKho : Form
    {
        decimal PhieuNhapId;
        PhieuNhap PhieuNhapHT;
        public fNhapKho()
        {
            InitializeComponent();
        }

        private void LoadDSPhieu()
        {
            dgvDanhSachPhieu.DataSource = PhieuNhapCommon.PhieuNhap_Select_Ngay(dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void btNhapDanhSach_Click(object sender, EventArgs e)
        {
            // tao phieu nhap
            PhieuNhapId = PhieuNhapCommon.Insert(Common.NhanVienHT.Id, 1, tbNhaCungCap.Text, DateTime.Now, tbMaHoaDon.Text, tbGhiChu.Text, 1, 1);
            MessageBox.Show("Nhap thanh cong");
            LoadDS();
        }

        private void fNhapKho_Load(object sender, EventArgs e)
        {
            clMaThuoc.DataSource = ThuocCommon.Select();
            clMaThuoc.DisplayMember = "TenThuoc";
            clMaThuoc.ValueMember = "Id";

            dgvChiTietPhieuNhap.AutoGenerateColumns = false;
            LoadDSPhieu();
        }
        private void LoadDS()
        {
            dgvChiTietPhieuNhap.DataSource = ChiTietPhieuNhapCommon.Select_field("MaPhieuNhap", new object[] { PhieuNhapId });
        }       
        private void dgvChiTietPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (PhieuNhapId == null)
                {
                    MessageBox.Show("Chưa Nhập Phiếu");
                    return;
                }
                PhieuNhapHT = new PhieuNhap(PhieuNhapId);
                if(PhieuNhapHT.TinhTrangId == 2)
                {
                    MessageBox.Show("Phiếu này đã nhập không thể chỉnh sửa");
                    return;
                }
                string TenCot = dgvChiTietPhieuNhap.Columns[e.ColumnIndex].Name;
               
                if (dgvChiTietPhieuNhap.CurrentRow != null)
                    if (dgvChiTietPhieuNhap.CurrentRow.Cells["cId"].Value.ToString() == "")  // chua co gia tri Id tuc la dong moi
                    {
                        if (TenCot == "clMaThuoc")
                        {
                            // Nếu thêm tên thì mình tạo dòng mới luôn và refresh lại ds
                            decimal ChitietPhieuNhapId = ChiTietPhieuNhapCommon.Insert(PhieuNhapId, 1, "", DateTime.Now, 1, 1, 1, 1);
                            LoadDS();
                        }
                    }
                    else  // voi dong cu thi update thong tin nếu phiếu nhập ID > 0
                    {

                        if (TenCot == "clMaThuoc")
                        {
                            ChiTietPhieuNhap HT = new ChiTietPhieuNhap((decimal)dgvChiTietPhieuNhap.CurrentRow.Cells["cId"].Value);
                            HT.MaThuoc = (decimal)dgvChiTietPhieuNhap.CurrentRow.Cells["clMaThuoc"].Value;
                        }
                        if (TenCot == "clSoLo")
                        {
                            ChiTietPhieuNhap HT = new ChiTietPhieuNhap((decimal)dgvChiTietPhieuNhap.CurrentRow.Cells["cId"].Value);
                            HT.SoLo = dgvChiTietPhieuNhap.CurrentRow.Cells["clSoLo"].Value.ToString();
                        }

                        if (TenCot == "clHanDung")
                        {
                            ChiTietPhieuNhap HT = new ChiTietPhieuNhap((decimal)dgvChiTietPhieuNhap.CurrentRow.Cells["cId"].Value);
                            HT.HanDung = (DateTime)dgvChiTietPhieuNhap.CurrentRow.Cells["clHanDung"].Value;
                        }
                        if (TenCot == "clSoLuong")
                        {
                            ChiTietPhieuNhap HT = new ChiTietPhieuNhap((decimal)dgvChiTietPhieuNhap.CurrentRow.Cells["cId"].Value);
                            HT.SoLuong = (decimal)dgvChiTietPhieuNhap.CurrentRow.Cells["clSoLuong"].Value;
                        }
                        if (TenCot == "clDonGia")
                        {
                            ChiTietPhieuNhap HT = new ChiTietPhieuNhap((decimal)dgvChiTietPhieuNhap.CurrentRow.Cells["cId"].Value);
                            HT.DonGia = (decimal)dgvChiTietPhieuNhap.CurrentRow.Cells["clDonGia"].Value;
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDSPhieu();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDSPhieu();
        }

        private void dgvDanhSachPhieu_SelectionChanged(object sender, EventArgs e)
        {
             PhieuNhapHT = new PhieuNhap((decimal.Parse(dgvDanhSachPhieu.Rows[dgvDanhSachPhieu.CurrentCell.RowIndex].Cells["cId1"].Value.ToString())));
            tbMaHoaDon.Text = PhieuNhapHT.MaHoaDon;
            tbNhaCungCap.Text = PhieuNhapHT.NhaCungCap;
            tbGhiChu.Text = PhieuNhapHT.GhiChu;
            dtpNgayLapPhieu.Value = PhieuNhapHT.NgayLap;
            PhieuNhapId = PhieuNhapHT.Id;
            LoadDS();

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            PhieuNhapHT.MaHoaDon = tbMaHoaDon.Text;
            PhieuNhapHT.NhaCungCap = tbNhaCungCap.Text;
            PhieuNhapHT.GhiChu = tbGhiChu.Text;
            PhieuNhapHT.NgayLap = dtpNgayLapPhieu.Value;
            
            
        }

        private void btNhapKho_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvChiTietPhieuNhap.DataSource;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhoThuocCommon.Insert((decimal)dt.Rows[i]["MaThuoc"], 1, dt.Rows[i]["SoLo"].ToString(), (DateTime)dt.Rows[i]["HanDung"], DateTime.Now, (decimal)dt.Rows[i]["Id"], 1, (decimal)dt.Rows[i]["SoLuong"], 1, 1);


            }
            PhieuNhapHT.TinhTrangId = 2;
            // đã nhập
        }
    }
}
