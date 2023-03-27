using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public class DonThuoc
    {
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
        private decimal Id_Static;
        private decimal MaKhoThuoc_Static;
        private decimal MaKhamChuyenKhoa_Static;
        private decimal? MaChiTietChungTu_Static;
        private decimal Sang_Static;
        private decimal Trua_Static;
        private decimal Chieu_Static;
        private decimal Toi_Static;
        private decimal Soluong_Static;
        private decimal NgayDung_Static;
        private decimal DonGia_Static;
        private string CachDung_Static;
        private DateTime NgayKe_Static;
        private DateTime? NgayPhat_Static;
        private decimal? NguoiPhat_Static;
        private decimal TrangThaiId_Static;

        public decimal Id
        {
            get
            {
                return this.Id_Static;
            }
        }


        public decimal MaKhoThuoc
        {
            get
            {
                return this.MaKhoThuoc_Static;
            }
            set
            {
                DonThuocCommon.Update_MaKhoThuoc(this.Id, value);
                this.MaKhoThuoc_Static = value;
            }
        }


        public decimal MaKhamChuyenKhoa
        {
            get
            {
                return this.MaKhamChuyenKhoa_Static;
            }
            set
            {
                DonThuocCommon.Update_MaKhamChuyenKhoa(this.Id, value);
                this.MaKhamChuyenKhoa_Static = value;
            }
        }

        public decimal? MaChiTietChungTu
        {
            get
            {
                return this.MaChiTietChungTu_Static;
            }
            set
            {
                ChiDinhCommon.Update_MaChiTietChungTu(this.Id, value);
                this.MaChiTietChungTu_Static = value;
            }
        }

        public decimal Sang
        {
            get
            {
                return this.Sang_Static;
            }
            set
            {
                DonThuocCommon.Update_Sang(this.Id, value);
                this.Sang_Static = value;
            }
        }


        public decimal Trua
        {
            get
            {
                return this.Trua_Static;
            }
            set
            {
                DonThuocCommon.Update_Trua(this.Id, value);
                this.Trua_Static = value;
            }
        }


        public decimal Chieu
        {
            get
            {
                return this.Chieu_Static;
            }
            set
            {
                DonThuocCommon.Update_Chieu(this.Id, value);
                this.Chieu_Static = value;
            }
        }


        public decimal Toi
        {
            get
            {
                return this.Toi_Static;
            }
            set
            {
                DonThuocCommon.Update_Toi(this.Id, value);
                this.Toi_Static = value;
            }
        }


        public decimal Soluong
        {
            get
            {
                return this.Soluong_Static;
            }
            set
            {
                DonThuocCommon.Update_Soluong(this.Id, value);
                this.Soluong_Static = value;
            }
        }


        public decimal NgayDung
        {
            get
            {
                return this.NgayDung_Static;
            }
            set
            {
                DonThuocCommon.Update_NgayDung(this.Id, value);
                this.NgayDung_Static = value;
            }
        }


        public decimal DonGia
        {
            get
            {
                return this.DonGia_Static;
            }
            set
            {
                DonThuocCommon.Update_DonGia(this.Id, value);
                this.DonGia_Static = value;
            }
        }


        public string CachDung
        {
            get
            {
                return this.CachDung_Static;
            }
            set
            {
                DonThuocCommon.Update_CachDung(this.Id, value);
                this.CachDung_Static = value;
            }
        }


        public DateTime NgayKe
        {
            get
            {
                return this.NgayKe_Static;
            }
            set
            {
                DonThuocCommon.Update_NgayKe(this.Id, value);
                this.NgayKe_Static = value;
            }
        }


        public DateTime? NgayPhat
        {
            get
            {
                return this.NgayPhat_Static;
            }
            set
            {
                DonThuocCommon.Update_NgayPhat(this.Id, value);
                this.NgayPhat_Static = value;
            }
        }


        public decimal? NguoiPhat
        {
            get
            {
                return this.NguoiPhat_Static;
            }
            set
            {
                DonThuocCommon.Update_NguoiPhat(this.Id, value);
                this.NguoiPhat_Static = value;
            }
        }


        public decimal TrangThaiId
        {
            get
            {
                return this.TrangThaiId_Static;
            }
            set
            {
                DonThuocCommon.Update_TrangThaiId(this.Id, value);
                this.TrangThaiId_Static = value;
            }
        }


        /// <summary> 
        /// Hàm khởi tạo ObjectDonThuoc
        /// </summary> 
        public DonThuoc(decimal Id)
        {
            DataTable Table = DonThuocCommon.Select_field("Id", new object[] { Id });
            if (Table.Rows.Count > 0)
            {
                BuildDonThuoc(Table.Rows[0]);
            }
            else
                throw new Exception("Không có DonThuoc!");
        }

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
        private void BuildDonThuoc(DataRow row)
        {
            this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]);
            this.MaKhoThuoc_Static = (decimal)FunctionCommon.GetDBValue(row["MaKhoThuoc"]);
            this.MaKhamChuyenKhoa_Static = (decimal)FunctionCommon.GetDBValue(row["MaKhamChuyenKhoa"]);
            this.MaChiTietChungTu_Static = (decimal?)FunctionCommon.GetDBValue(row["MaChiTietChungTu"]);
            this.Sang_Static = (decimal)FunctionCommon.GetDBValue(row["Sang"]);
            this.Trua_Static = (decimal)FunctionCommon.GetDBValue(row["Trua"]);
            this.Chieu_Static = (decimal)FunctionCommon.GetDBValue(row["Chieu"]);
            this.Toi_Static = (decimal)FunctionCommon.GetDBValue(row["Toi"]);
            this.Soluong_Static = (decimal)FunctionCommon.GetDBValue(row["Soluong"]);
            this.NgayDung_Static = (decimal)FunctionCommon.GetDBValue(row["NgayDung"]);
            this.DonGia_Static = (decimal)FunctionCommon.GetDBValue(row["DonGia"]);
            this.CachDung_Static = (string)FunctionCommon.GetDBValue(row["CachDung"]);
            this.NgayKe_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayKe"]);
            this.NgayPhat_Static = (DateTime?)FunctionCommon.GetDBValue(row["NgayPhat"]);
            this.NguoiPhat_Static = (decimal?)FunctionCommon.GetDBValue(row["NguoiPhat"]);
            this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]);
        }
    }
}
