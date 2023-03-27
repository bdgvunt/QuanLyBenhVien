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

namespace QuanLyBenhVien.Forms
{
    public partial class fVienPhi : Form
    {
        LuotKham LuotKhamHT;
        BenhNhan BenhNhanHT;

        public fVienPhi()
        {
            InitializeComponent();
        }

        private void fVienPhi_Load(object sender, EventArgs e)
        {
            dgvChuaThanhToan.AutoGenerateColumns = false;
            dgvVienPhi.AutoGenerateColumns = false;
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            if (tabControl1.SelectedTab == tpgChuaThanhToan)
            {
                LoadDSChuaThanhToan();
            }
            else
            {
                LoadDSDaThanhToan();
            }
        }

        private void LoadDSChuaThanhToan()
        {
            // ko lay cac truong hop da hoan tat kham

            DataView dv = new DataView(LuotKhamCommon.Select_DSTheoNgay(dtpNgay.Value));
            dv.RowFilter = "MaTinhTrangKham <> 6";

            dgvChuaThanhToan.DataSource = dv;
        }
        private void LoadDSDaThanhToan()
        {
            // ko lay cac truong hop da hoan tat kham
            dgvDaThanhToan.DataSource = ChungTuCommon.Select_DSTheoNgay(dtpNgay.Value);
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void dgvChuaThanhToan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvChuaThanhToan.Rows.Count > 0)
                {
                    LuotKhamHT = new LuotKham((decimal.Parse(dgvChuaThanhToan.Rows[dgvChuaThanhToan.CurrentCell.RowIndex].Cells["cId"].Value.ToString())));
                    BenhNhanHT = new BenhNhan(LuotKhamHT.MaBenhNhan);
                    lbHoTen.Text = BenhNhanHT.TenBenhNhan;
                    lbDiaChi.Text = BenhNhanHT.DiaChi;
                    //   lbGioiTinh.Text = BenhNhanHT.GioiTinh;
                    lbNgaySinh.Text = BenhNhanHT.NgaySinh.ToString("dd/MM/yyyy");

                    LayThongTinVienPhi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LayThongTinVienPhi()
        {
            DataTable dt = LuotKhamCommon.Select_ThongTinVienPhi(LuotKhamHT.Id);
            if (dt.Rows.Count > 0)
            {
                dgvVienPhi.DataSource = dt;
                long Tong = (long)(decimal)dt.Compute("Sum(ThanhTien)", "");
                lbTongTien.Text = Tong.ToString(); // dt.Compute("Sum(ThanhTien)", "").ToString();
                ReadNumber reader = new ReadNumber();
                lbBangChu.Text = reader.reader(Tong) + " đồng";
            }
            else dgvVienPhi.DataSource = null;

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // tao chung tu 

                decimal ChungTuId = ChungTuCommon.Insert(LuotKhamHT.Id, Common.NhanVienHT.Id, Common.NhanVienHT.Id, DateTime.Now, DateTime.Now, "", 1);

                // tao cac chi tiet chung tu tu dgv 
                DataTable dt = (DataTable)dgvVienPhi.DataSource;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    decimal ChiTietChungTuId = ChiTietChungTuCommon.Insert(ChungTuId, (decimal)dt.Rows[i]["Id"], (decimal)dt.Rows[i]["Loai"], (decimal)dt.Rows[i]["ThanhTien"], 1);
                    if ((decimal)dt.Rows[i]["Loai"] == 1) // chidinh
                        ChiDinhCommon.Update_MaChiTietChungTu((decimal)dt.Rows[i]["Id"], ChiTietChungTuId);
                    else DonThuocCommon.Update_MaChiTietChungTu((decimal)dt.Rows[i]["Id"], ChiTietChungTuId);
                }

                // kiem tra neu da ket thuc kham, hoac xuat vien, hoac nhap vien thi Hoan Tat Kham
                if (LuotKhamHT.MaTinhTrangKham > 2) LuotKhamHT.MaTinhTrangKham = 6;


                MessageBox.Show("Đã thanh toán thành công");

                LoadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
      
        private void LayThongTinChungTu()
        {
            try
            {
                ChungTu ChungTuHT = new ChungTu((decimal.Parse(dgvDaThanhToan.Rows[dgvDaThanhToan.CurrentCell.RowIndex].Cells["cChungTuId"].Value.ToString())));

                DataTable dt = ChiTietChungTuCommon.Select_ChungTuId(ChungTuHT.Id);
                dgvVienPhi.DataSource = dt;

                long Tong = (long)(decimal)dt.Compute("Sum(ThanhTien)", "");
                lbTongTien.Text = Tong.ToString(); // dt.Compute("Sum(ThanhTien)", "").ToString();
                ReadNumber reader = new ReadNumber();
                lbBangChu.Text = reader.reader(Tong) + " đồng";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void dgvDaThanhToan_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvDaThanhToan.Rows.Count > 0)
                {
                    LuotKhamHT = new LuotKham((decimal.Parse(dgvDaThanhToan.Rows[dgvDaThanhToan.CurrentCell.RowIndex].Cells["cId1"].Value.ToString())));
                    BenhNhanHT = new BenhNhan(LuotKhamHT.MaBenhNhan);


                    lbHoTen.Text = BenhNhanHT.TenBenhNhan;
                    lbDiaChi.Text = BenhNhanHT.DiaChi;
                    //   lbGioiTinh.Text = BenhNhanHT.GioiTinh;
                    lbNgaySinh.Text = BenhNhanHT.NgaySinh.ToString("dd/MM/yyyy");

                    LayThongTinChungTu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btXoaThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa chứng từ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                ChungTu ChungTuHT = new ChungTu((decimal.Parse(dgvDaThanhToan.Rows[dgvDaThanhToan.CurrentCell.RowIndex].Cells["cChungTuId"].Value.ToString())));

                DataTable dt = ChiTietChungTuCommon.Select_field("MaChungTu", new object[] { ChungTuHT.Id });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ChiTietChungTu CTCTHT = new ChiTietChungTu((decimal) dt.Rows[i]["Id"]);
                    if (CTCTHT.Loai == 1) ChiDinhCommon.Update_MaChiTietChungTu(CTCTHT.MaChiDinh, null);
                    else DonThuocCommon.Update_MaChiTietChungTu (CTCTHT.MaChiDinh, null);
                    CTCTHT.TrangThaiId = 0;

                   
                }
                ChungTuHT.TrangThaiId = 0;

                MessageBox.Show("Đã xóa chứng từ");

                LoadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
