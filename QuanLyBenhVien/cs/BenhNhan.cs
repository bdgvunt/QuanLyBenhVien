using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public class BenhNhan
    {
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
        private decimal Id_Static;
        private decimal MaBenhNhan_Static;
        private string TenBenhNhan_Static;
        private decimal GioiTinh_Static;
        private DateTime NgaySinh_Static;
        private string DiaChi_Static;
        private string SoDienThoai_Static;
        private decimal MaQuocTich_Static;
        private decimal MaDantoc_Static;
        private decimal TrangThaiId_Static;

        public decimal Id
        {
            get
            {
                return this.Id_Static;
            }
        }


        public decimal MaBenhNhan
        {
            get
            {
                return this.MaBenhNhan_Static;
            }
            set
            {
                BenhNhanCommon.Update_MaBenhNhan(this.Id, value);
                this.MaBenhNhan_Static = value;
            }
        }


        public string TenBenhNhan
        {
            get
            {
                return this.TenBenhNhan_Static;
            }
            set
            {
                BenhNhanCommon.Update_TenBenhNhan(this.Id, value);
                this.TenBenhNhan_Static = value;
            }
        }


        public decimal GioiTinh
        {
            get
            {
                return this.GioiTinh_Static;
            }
            set
            {
                BenhNhanCommon.Update_GioiTinh(this.Id, value);
                this.GioiTinh_Static = value;
            }
        }


        public DateTime NgaySinh
        {
            get
            {
                return this.NgaySinh_Static;
            }
            set
            {
                BenhNhanCommon.Update_NgaySinh(this.Id, value);
                this.NgaySinh_Static = value;
            }
        }


        public string DiaChi
        {
            get
            {
                return this.DiaChi_Static;
            }
            set
            {
                BenhNhanCommon.Update_DiaChi(this.Id, value);
                this.DiaChi_Static = value;
            }
        }


        public string SoDienThoai
        {
            get
            {
                return this.SoDienThoai_Static;
            }
            set
            {
                BenhNhanCommon.Update_SoDienThoai(this.Id, value);
                this.SoDienThoai_Static = value;
            }
        }


        public decimal MaQuocTich
        {
            get
            {
                return this.MaQuocTich_Static;
            }
            set
            {
                BenhNhanCommon.Update_MaQuocTich(this.Id, value);
                this.MaQuocTich_Static = value;
            }
        }


        public decimal MaDantoc
        {
            get
            {
                return this.MaDantoc_Static;
            }
            set
            {
                BenhNhanCommon.Update_MaDantoc(this.Id, value);
                this.MaDantoc_Static = value;
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
                BenhNhanCommon.Update_TrangThaiId(this.Id, value);
                this.TrangThaiId_Static = value;
            }
        }


        /// <summary> 
        /// Hàm khởi tạo ObjectBenhNhan
        /// </summary> 
        public BenhNhan(decimal Id)
        {
            DataTable Table = BenhNhanCommon.Select_field("Id", new object[] { Id });
            if (Table.Rows.Count > 0)
            {
                BuildBenhNhan(Table.Rows[0]);
            }
            else
                throw new Exception("Không có BenhNhan!");
        }

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
        private void BuildBenhNhan(DataRow row)
        {
            this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]);
            this.MaBenhNhan_Static = (decimal)FunctionCommon.GetDBValue(row["MaBenhNhan"]);
            this.TenBenhNhan_Static = (string)FunctionCommon.GetDBValue(row["TenBenhNhan"]);
            this.GioiTinh_Static = (decimal)FunctionCommon.GetDBValue(row["GioiTinh"]);
            this.NgaySinh_Static = (DateTime)FunctionCommon.GetDBValue(row["NgaySinh"]);
            this.DiaChi_Static = (string)FunctionCommon.GetDBValue(row["DiaChi"]);
            this.SoDienThoai_Static = (string)FunctionCommon.GetDBValue(row["SoDienThoai"]);
            this.MaQuocTich_Static = (decimal)FunctionCommon.GetDBValue(row["MaQuocTich"]);
            this.MaDantoc_Static = (decimal)FunctionCommon.GetDBValue(row["MaDantoc"]);
            this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]);
        }
    }
}
