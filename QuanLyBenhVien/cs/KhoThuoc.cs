using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public class KhoThuoc
    {
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
        private decimal Id_Static;
        private decimal MaThuoc_Static;
        private decimal MaKho_Static;
        private string SoLo_Static;
        private DateTime HanDung_Static;
        private DateTime NgayTao_Static;
        private decimal? MaPhieu_Static;
        private decimal LoaiPhieu_Static;
        private decimal SoLuong_Static;
        private decimal TinhTrangId_Static;
        private decimal TrangThaiId_Static;

        public decimal Id
        {
            get
            {
                return this.Id_Static;
            }
        }


        public decimal MaThuoc
        {
            get
            {
                return this.MaThuoc_Static;
            }
            set
            {
                KhoThuocCommon.Update_MaThuoc(this.Id, value);
                this.MaThuoc_Static = value;
            }
        }


        public decimal MaKho
        {
            get
            {
                return this.MaKho_Static;
            }
            set
            {
                KhoThuocCommon.Update_MaKho(this.Id, value);
                this.MaKho_Static = value;
            }
        }


        public string SoLo
        {
            get
            {
                return this.SoLo_Static;
            }
            set
            {
                KhoThuocCommon.Update_SoLo(this.Id, value);
                this.SoLo_Static = value;
            }
        }


        public DateTime HanDung
        {
            get
            {
                return this.HanDung_Static;
            }
            set
            {
                KhoThuocCommon.Update_HanDung(this.Id, value);
                this.HanDung_Static = value;
            }
        }


        public DateTime NgayTao
        {
            get
            {
                return this.NgayTao_Static;
            }
            set
            {
                KhoThuocCommon.Update_NgayTao(this.Id, value);
                this.NgayTao_Static = value;
            }
        }


        public decimal? MaPhieu
        {
            get
            {
                return this.MaPhieu_Static;
            }
            set
            {
                KhoThuocCommon.Update_MaPhieu(this.Id, value);
                this.MaPhieu_Static = value;
            }
        }


        public decimal LoaiPhieu
        {
            get
            {
                return this.LoaiPhieu_Static;
            }
            set
            {
                KhoThuocCommon.Update_LoaiPhieu(this.Id, value);
                this.LoaiPhieu_Static = value;
            }
        }


        public decimal SoLuong
        {
            get
            {
                return this.SoLuong_Static;
            }
            set
            {
                KhoThuocCommon.Update_SoLuong(this.Id, value);
                this.SoLuong_Static = value;
            }
        }


        public decimal TinhTrangId
        {
            get
            {
                return this.TinhTrangId_Static;
            }
            set
            {
                KhoThuocCommon.Update_TinhTrangId(this.Id, value);
                this.TinhTrangId_Static = value;
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
                KhoThuocCommon.Update_TrangThaiId(this.Id, value);
                this.TrangThaiId_Static = value;
            }
        }


        /// <summary> 
        /// Hàm khởi tạo ObjectKhoThuoc
        /// </summary> 
        public KhoThuoc(decimal Id)
        {
            DataTable Table = KhoThuocCommon.Select_field("Id", new object[] { Id });
            if (Table.Rows.Count > 0)
            {
                BuildKhoThuoc(Table.Rows[0]);
            }
            else
                throw new Exception("Không có KhoThuoc!");
        }

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
        private void BuildKhoThuoc(DataRow row)
        {
            this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]);
            this.MaThuoc_Static = (decimal)FunctionCommon.GetDBValue(row["MaThuoc"]);
            this.MaKho_Static = (decimal)FunctionCommon.GetDBValue(row["MaKho"]);
            this.SoLo_Static = (string)FunctionCommon.GetDBValue(row["SoLo"]);
            this.HanDung_Static = (DateTime)FunctionCommon.GetDBValue(row["HanDung"]);
            this.NgayTao_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayTao"]);
            this.MaPhieu_Static = (decimal?)FunctionCommon.GetDBValue(row["MaPhieu"]);
            this.LoaiPhieu_Static = (decimal)FunctionCommon.GetDBValue(row["LoaiPhieu"]);
            this.SoLuong_Static = decimal.Parse( FunctionCommon.GetDBValue(row["SoLuong"]).ToString() );
            this.TinhTrangId_Static = (decimal)FunctionCommon.GetDBValue(row["TinhTrangId"]);
            this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]);
        }
    }
}
