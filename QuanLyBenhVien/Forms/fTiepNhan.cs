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
    public partial class fTiepNhan : Form
    {

        LuotKham LuotKhamHT;
        BenhNhan BenhNhanHT;

        public fTiepNhan()
        {
            InitializeComponent();
        }

        private void fTiepNhan_Load(object sender, EventArgs e)
        {
            // lay thong tin ds quoc tich
            cbbQuocTich.DataSource = QuocTichCommon.Select();
            cbbQuocTich.DisplayMember = "TenQuocTich";
            cbbQuocTich.ValueMember = "Id";

            // lay thong tin ds loai kham
            cbbLoaiKham.DataSource = LoaiKhamCommon.Select();
            cbbLoaiKham.DisplayMember = "TenLoaiKham";
            cbbLoaiKham.ValueMember = "Id";

            // lay thong tin ds loai kham
            cbbPhongKham.DataSource = PhongKhamCommon.Select();
            cbbPhongKham.DisplayMember = "TenPhongKham";
            cbbPhongKham.ValueMember = "Id";


            // lay thong tin dan toc
            cbbDanToc.DataSource = DanTocCommon.Select();
            cbbDanToc.DisplayMember = "TenDanToc";
            cbbDanToc.ValueMember = "Id";

            //Load ds cac luot kham tiep nhan trong ngay hom nay
            LoadDSLuotKhamTrongNgay();
        }

        private void LoadDSLuotKhamTrongNgay()
        {
          //DataTable dt;

           dgvBenhNhan.DataSource = LuotKhamCommon.Select_DSTheoNgay(DateTime.Now);
        }

        private void acceptbutton_Click(object sender, EventArgs e)
        {


         
            if(tbBenhNhanname.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên");
                return;
            }
            if(tbDiaChi.Text == " ")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return;
            }
            if(tbSoDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            // tao benh nhan 

            // decimal Id =   BenhNhanCommon.Insert(1, tbBenhNhanname.Text, 1, dtpNgaySinh.Value, tbDiaChi.Text, tbSoDienThoai.Text,(decimal)cbbQuocTich.SelectedValue, 1, 1);

            decimal Id = BenhNhanCommon.Insert(1, tbBenhNhanname.Text, 1, dtpNgaySinh.Value, tbDiaChi.Text, tbSoDienThoai.Text, (decimal) cbbQuocTich.SelectedValue, 1, 1);


            // tao luot kham

           decimal LuotKhamId = LuotKhamCommon.Insert(Id, 1, DateTime.Now, "", "", "", "", "","","", DateTime.Now, Common.NhanVienHT.Id, "", 1);
            
            // tao kham chuyen khoa

            decimal KhamChuyenKhoaId = KhamChuyenKhoaCommon.Insert(LuotKhamId, (decimal) cbbPhongKham.SelectedValue , Common.NhanVienHT.Id  , (decimal) cbbLoaiKham.SelectedValue , 1, DateTime.Now, DateTime.Now, 1);
             

            // reload ds benh nhan 
            LoadDSLuotKhamTrongNgay();

        }

        private void resestbutton_Click(object sender, EventArgs e)
        {
            //BenhNhan bn = new BenhNhan((decimal) dgvBenhNhan.SelectedRows[0].Cells["Id"].Value);
            //bn.TenBenhNhan = tbBenhNhanname.Text;
            //bn.DiaChi = tbDiaChi.Text;
            //bn.NgaySinh = dtpNgaySinh.Value;




            //decimal BenhNhanId = (decimal)dgvBenhNhan.SelectedRows[0].Cells["Id"].Value;
            //BenhNhanCommon.Update_TenBenhNhan(BenhNhanId, tbBenhNhanname.Text);
           
            
            tbBenhNhanname.Text = "";
            tbDiaChi.Text = "";
            tbSoDienThoai.Text = "";
            tbUutien.Text = "";
            tbMaBHYT.Text = " ";
            tbNoiCapBHYT.Text= " ";
            tbMucHuongBHYT.Text = " ";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbChonPhongKham_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btSuaThongTin_Click(object sender, EventArgs e)
        {
           // DataTable dtLuotKham = LuotKhamCommon.Select_field("Id", new object [] { decimal.Parse( dgvBenhNhan.CurrentRow.Cells["Id"].Value.ToString()) });


            LuotKhamHT = new LuotKham((decimal.Parse(dgvBenhNhan.Rows[dgvBenhNhan.CurrentCell.RowIndex].Cells["Id"].Value.ToString())));
         //  LuotKham LuotKhamHT = new LuotKham(decimal.Parse(dgvBenhNhan.SelectedRows[0].Cells[0].Value.ToString()));

             BenhNhanHT = new BenhNhan(LuotKhamHT.MaBenhNhan);

            tbBenhNhanname.Text = BenhNhanHT.TenBenhNhan;
            tbDiaChi.Text = BenhNhanHT.DiaChi;
            //viete tuong tu

            MessageBox.Show("Đã sửa");

            LoadDSLuotKhamTrongNgay();

           

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (BenhNhanHT != null)
                {
                    BenhNhanHT.TenBenhNhan = tbBenhNhanname.Text;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            } 

            

        }
    }
}
