using QuanLyBenhVien.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class fKhamBenh : Form
    {
        KhamChuyenKhoa KhamChuyenKhoaHT;
        ChiDinh ChiDinhHT;
        LuotKham LuotKhamHT;
        BenhNhan BenhNhanHT;
        PhongKham PhongKhamHT;
        public fKhamBenh()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                //decimal BenhNhanId;
                KhamChuyenKhoaHT = new KhamChuyenKhoa((decimal.Parse(dgvDanhSach.Rows[dgvDanhSach.CurrentCell.RowIndex].Cells["cId"].Value.ToString())));
                LuotKhamHT = new LuotKham(KhamChuyenKhoaHT.MaLuotKham);
                BenhNhanHT = new BenhNhan(LuotKhamHT.MaBenhNhan);

                tbHoTen1.Text = BenhNhanHT.TenBenhNhan;
                // them cac truong khac cua BenhNhan
                tbDienthoai.Text = BenhNhanHT.SoDienThoai;
                tbCanNang.Text = LuotKhamHT.CanNang;
                // tbDiachi1.Text = LuotKhamHT.DiaChi;
                // them cac truong khac cua LuotKham




                tbHoTen1.Text = BenhNhanHT.TenBenhNhan;
                tbDiachi1.Text = BenhNhanHT.DiaChi;
                tbDienthoai.Text = BenhNhanHT.SoDienThoai;

                // khi bs chon benh nhan thi chuyen tinh trang sang dang kham 

                KhamChuyenKhoaHT.MaTinhTrangKham = 2;


                ReloadDonThuoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lay danh sach benh nhan dang cho o phong kham




            //  dgvDanhSach.DataSource = ....;


        }


        private void fKhamBenh_Load_1(object sender, EventArgs e)
        {
            cbbPhongKham.DataSource = PhongKhamCommon.Select();
            cbbPhongKham.DisplayMember = "TenPhongKham";
            cbbPhongKham.ValueMember = "Id";

            dtpNgayKham.Value = DateTime.Now;

            LoadDSKhamBenh();
            dgvDichVu.DataSource = DichVuCommon.Select();

            // 
            dgvPhongKham.DataSource = PhongKhamCommon.Select();
            dgvLoaiKham.DataSource = LoaiKhamCommon.Select();

            dgvPhongKham2.DataSource = PhongKhamCommon.Select();
            dgvLoaiKham2.DataSource = LoaiKhamCommon.Select();

            // 
            clTenThuongMai.DataSource = ThuocCommon.Select();
            clTenThuongMai.DisplayMember = "TenThuoc";
            clTenThuongMai.ValueMember = "Id";
            // clTenThuongMai

            dgvDonThuoc.AutoGenerateColumns = false;
        }

        private decimal TinhTrangKham()
        {
            if (rbChoKham.Checked) return 1;
            if (rbDangKham.Checked) return 2;
            if (rbDaKham.Checked) return 3;
            return 4;

        }

        private void LoadDSKhamBenh()
        {
            try
            {
                dgvDanhSach.DataSource = LuotKhamCommon.Select_DSTheoNgayPhongKhamTinhTrangKham(dtpNgayKham.Value, (decimal)cbbPhongKham.SelectedValue, TinhTrangKham());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void rbDangKham_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDangKham.Checked) LoadDSKhamBenh();
        }

        private void rbChoKham_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChoKham.Checked) LoadDSKhamBenh();
        }

        private void rbDaKham_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDaKham.Checked) LoadDSKhamBenh();
        }

        private void rbNhapVien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNhapVien.Checked) LoadDSKhamBenh();
        }

        private void tbCanNang_TextChanged(object sender, EventArgs e)
        {
            LuotKhamHT.CanNang = tbCanNang.Text;
        }
        // tuong tu cho cac DHST khac
        private void tbChieuCao_TextChanged(object sender, EventArgs e)
        {
            LuotKhamHT.ChieuCao = tbChieuCao.Text;
        }
        private void tbHuyetap_TextChanged(object sender, EventArgs e)
        {
            LuotKhamHT.Huyetap = tbHuyetap.Text;
        }

        private void dgvDichVu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (KhamChuyenKhoaHT == null)
            {
                MessageBox.Show("Bạn chưa chọn bệnh nhân");
                return;
            }
            // tao phieu chi dinh

            decimal PhieuChiDinhId = PhieuChiDinhCommon.Insert(KhamChuyenKhoaHT.Id, Common.NhanVienHT.Id, DateTime.Now, "", 1);
            //tao chi dinh
            decimal ChiDinhId = ChiDinhCommon.Insert(PhieuChiDinhId, decimal.Parse(dgvDichVu.Rows[dgvDichVu.CurrentCell.RowIndex].Cells["dgvDichVu_cId"].Value.ToString()), Common.NhanVienHT.Id,null, 0, DateTime.Now, null, null, 1, 20000, "", 1, 1);

            ReloadDSChiDinh();

        }

        private void ReloadDSChiDinh()
        {
            dgvChiDinh.DataSource = ChiDinhCommon.Select_LuotKham(KhamChuyenKhoaHT.MaLuotKham);
        }

        private void dgvChiDinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            ChiDinhHT = new ChiDinh((decimal.Parse(dgvChiDinh.Rows[dgvChiDinh.CurrentCell.RowIndex].Cells["dgvChiDinh_cId"].Value.ToString())));
            ChiDinhHT = new ChiDinh(ChiDinhHT.Id);
            ChiDinhHT.TrangThaiId = 0;
            ReloadDSChiDinh();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  rbDangKham.Checked = true;
            // KhamChuyenKhoaHT.TrangThaiId = 2;
        }

        private void btChuyenphong_Click(object sender, EventArgs e)
        {
            try
            {
                KhamChuyenKhoaHT.MaPhongKham = decimal.Parse(dgvPhongKham.Rows[dgvPhongKham.CurrentCell.RowIndex].Cells["dgvPhongKham_cId"].Value.ToString());
                KhamChuyenKhoaHT.MaLoaiKham = decimal.Parse(dgvLoaiKham.Rows[dgvLoaiKham.CurrentCell.RowIndex].Cells["dgvLoaiKham_cId"].Value.ToString());

                // khi chuyen sang phong khac thi Tinh trang se chuyen thanh Cho Kham
                KhamChuyenKhoaHT.MaTinhTrangKham = 1;

                MessageBox.Show("Đã chuyển phòng khám");
                LoadDSKhamBenh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ReloadDonThuoc()
        {
            dgvDonThuoc.DataSource = DonThuocCommon.Select_MaKhamChuyenKhoa(KhamChuyenKhoaHT.Id);
        }

        private void dgvDonThuoc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                               
                string TenCot = dgvDonThuoc.Columns[e.ColumnIndex].Name;
                if (dgvDonThuoc.CurrentRow != null)
                    if (dgvDonThuoc.CurrentRow.Cells["dgvDonThuoc_cId"].Value.ToString() == "")  // chua co gia tri Id tuc la dong moi
                    {
                        if (TenCot == "clTenThuongMai")
                        {
                            // select KhoThuoc 
                            decimal ThuocId = decimal.Parse(dgvDonThuoc.CurrentRow.Cells["clTenThuongMai"].Value.ToString());
                            DataTable dKhoThuoc = KhoThuocCommon.Select_field("MaThuoc", new object[] { ThuocId });
                            for (int i = 0; i < dKhoThuoc.Rows.Count; i++)
                            {
                                if (decimal.Parse(dKhoThuoc.Rows[i]["SoLuong"].ToString()) > 0)
                                {
                                    KhoThuoc KhoThuocHT = new KhoThuoc((decimal)dKhoThuoc.Rows[i]["Id"]);
                                    DonThuocCommon.Insert((decimal)dKhoThuoc.Rows[i]["Id"], KhamChuyenKhoaHT.Id, null, 0, 0, 0, 0, 1, 1, 1000, "", DateTime.Now, null, null, 1);
                                    // tru kho 
                                    KhoThuocHT.SoLuong = KhoThuocHT.SoLuong - 1;

                                    ReloadDonThuoc();
                                }
                            }

                            //  MessageBox.Show("New Row");
                        }
                    }
                    else
                    {
                        if (TenCot == "clSang")
                        {
                            DonThuoc DonThuocHT = new DonThuoc((decimal)dgvDonThuoc.CurrentRow.Cells["dgvDonThuoc_cId"].Value);
                            DonThuocHT.Sang = (decimal)dgvDonThuoc.CurrentRow.Cells["clSang"].Value;
                        }
                        if (TenCot == "clTrua")
                        {
                            DonThuoc DonThuocHT = new DonThuoc((decimal)dgvDonThuoc.CurrentRow.Cells["dgvDonThuoc_cId"].Value);
                            DonThuocHT.Trua = (decimal)dgvDonThuoc.CurrentRow.Cells["clTrua"].Value;
                        }
                        if (TenCot == "clChieu")
                        {
                            DonThuoc DonThuocHT = new DonThuoc((decimal)dgvDonThuoc.CurrentRow.Cells["dgvDonThuoc_cId"].Value);
                            DonThuocHT.Chieu = (decimal)dgvDonThuoc.CurrentRow.Cells["clChieu"].Value;
                        }
                        if (TenCot == "clToi")
                        {
                            DonThuoc DonThuocHT = new DonThuoc((decimal)dgvDonThuoc.CurrentRow.Cells["dgvDonThuoc_cId"].Value);
                            DonThuocHT.Toi = (decimal)dgvDonThuoc.CurrentRow.Cells["clToi"].Value;
                        }
                        if (TenCot == "clNgay")
                        {
                            DonThuoc DonThuocHT = new DonThuoc((decimal)dgvDonThuoc.CurrentRow.Cells["dgvDonThuoc_cId"].Value);
                            DonThuocHT.NgayDung = (decimal)dgvDonThuoc.CurrentRow.Cells["clNgay"].Value;
                        }
                        if (TenCot == "clSoLuong")
                        {
                            DonThuoc DonThuocHT = new DonThuoc((decimal)dgvDonThuoc.CurrentRow.Cells["dgvDonThuoc_cId"].Value);
                            DonThuocHT.Soluong = (decimal)dgvDonThuoc.CurrentRow.Cells["clSoLuong"].Value;
                            // cap nhat lai so luong ton kho 
                            KhoThuoc KhoThuocHT = new KhoThuoc(DonThuocHT.MaKhoThuoc);
                            KhoThuocHT.SoLuong = KhoThuocHT.SoLuong + DonThuocHT.Soluong - (decimal)dgvDonThuoc.CurrentRow.Cells["clSoLuong"].Value;
                        }
                        if (TenCot == "clTenThuongMai")
                        {
                            // truong hop doi thuoc thi se xoa don thuoc cu va them thuoc moi 

                            DonThuoc DonThuocHT = new DonThuoc((decimal)dgvDonThuoc.CurrentRow.Cells["dgvDonThuoc_cId"].Value);
                            DonThuocHT.TrangThaiId = 0;

                            decimal ThuocId = decimal.Parse(dgvDonThuoc.CurrentRow.Cells["clTenThuongMai"].Value.ToString());
                            DataTable dKhoThuoc = KhoThuocCommon.Select_field("MaThuoc", new object[] { ThuocId });
                            for (int i = 0; i < dKhoThuoc.Rows.Count; i++)
                            {
                                if (decimal.Parse(dKhoThuoc.Rows[i]["SoLuong"].ToString()) > 0)
                                {
                                    KhoThuoc KhoThuocHT = new KhoThuoc((decimal)dKhoThuoc.Rows[i]["Id"]);
                                    DonThuocCommon.Insert((decimal)dKhoThuoc.Rows[i]["Id"], KhamChuyenKhoaHT.Id, null, 0, 0, 0, 0, 1, 1, 1000, "", DateTime.Now, null, null, 1);
                                    // tru kho 
                                    KhoThuocHT.SoLuong = KhoThuocHT.SoLuong - 1;

                                    ReloadDonThuoc();
                                }
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDonThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DonThuoc DonThuocHT = new DonThuoc((decimal)dgvDonThuoc.CurrentRow.Cells["dgvDonThuoc_cId"].Value);
                KhoThuoc KhoThuocHT = new KhoThuoc(DonThuocHT.MaKhoThuoc);
                // tra sl ve kho
                KhoThuocHT.SoLuong = KhoThuocHT.SoLuong + DonThuocHT.Soluong;
                DonThuocHT.TrangThaiId = 0;



                ReloadDonThuoc();

                //  MessageBox.Show("Xóa thuốc");
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void dtpNgayKham_ValueChanged(object sender, EventArgs e)
        {
            LoadDSKhamBenh();
        }

        
    }
}
