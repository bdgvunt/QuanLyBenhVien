using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public class LuotKham
    {
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
        private decimal Id_Static;
        private decimal MaBenhNhan_Static;
        private decimal MaTinhTrangKham_Static;
        private DateTime NgayKham_Static;
        private string Trieuchung_Static;
        private string KetQua_Static;
        private string Huyetap_Static;
        private string ChieuCao_Static;
        private string CanNang_Static;
        private DateTime NgayTiepNhan_Static;
        private decimal NguoiTiepNhan_Static;
        private string DichVu_Static;
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
                LuotKhamCommon.Update_MaBenhNhan(this.Id, value);
                this.MaBenhNhan_Static = value;
            }
        }

        public decimal MaTinhTrangKham
        {
            get
            {
                return this.MaTinhTrangKham_Static;
            }
            set
            {
                LuotKhamCommon.Update_MaTinhTrangKham(this.Id, value);
                this.MaTinhTrangKham_Static = value;
            }
        }

        public DateTime NgayKham
        {
            get
            {
                return this.NgayKham_Static;
            }
            set
            {
                LuotKhamCommon.Update_NgayKham(this.Id, value);
                this.NgayKham_Static = value;
            }
        }


        public string Trieuchung
        {
            get
            {
                return this.Trieuchung_Static;
            }
            set
            {
                LuotKhamCommon.Update_Trieuchung(this.Id, value);
                this.Trieuchung_Static = value;
            }
        }


        public string KetQua
        {
            get
            {
                return this.KetQua_Static;
            }
            set
            {
                LuotKhamCommon.Update_KetQua(this.Id, value);
                this.KetQua_Static = value;
            }
        }


        public string Huyetap
        {
            get
            {
                return this.Huyetap_Static;
            }
            set
            {
                LuotKhamCommon.Update_Huyetap(this.Id, value);
                this.Huyetap_Static = value;
            }
        }


        public string ChieuCao
        {
            get
            {
                return this.ChieuCao_Static;
            }
            set
            {
                LuotKhamCommon.Update_ChieuCao(this.Id, value);
                this.ChieuCao_Static = value;
            }
        }


        public string CanNang
        {
            get
            {
                return this.CanNang_Static;
            }
            set
            {
                LuotKhamCommon.Update_CanNang(this.Id, value);
                this.CanNang_Static = value;
            }
        }


        public DateTime NgayTiepNhan
        {
            get
            {
                return this.NgayTiepNhan_Static;
            }
            set
            {
                LuotKhamCommon.Update_NgayTiepNhan(this.Id, value);
                this.NgayTiepNhan_Static = value;
            }
        }


        public decimal NguoiTiepNhan
        {
            get
            {
                return this.NguoiTiepNhan_Static;
            }
            set
            {
                LuotKhamCommon.Update_NguoiTiepNhan(this.Id, value);
                this.NguoiTiepNhan_Static = value;
            }
        }


        public string DichVu
        {
            get
            {
                return this.DichVu_Static;
            }
            set
            {
                LuotKhamCommon.Update_DichVu(this.Id, value);
                this.DichVu_Static = value;
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
                LuotKhamCommon.Update_TrangThaiId(this.Id, value);
                this.TrangThaiId_Static = value;
            }
        }


        /// <summary> 
        /// Hàm khởi tạo ObjectLuotKham
        /// </summary> 
        public LuotKham(decimal Id)
        {
            DataTable Table = LuotKhamCommon.Select_field("Id", new object[] { Id });
            if (Table.Rows.Count > 0)
            {
                BuildLuotKham(Table.Rows[0]);
            }
            else
                throw new Exception("Không có LuotKham!");
        }

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
        private void BuildLuotKham(DataRow row)
        {
            this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]);
            this.MaBenhNhan_Static = (decimal)FunctionCommon.GetDBValue(row["MaBenhNhan"]);
            this.MaTinhTrangKham_Static = (decimal)FunctionCommon.GetDBValue(row["MaTinhTrangKham"]);
            this.NgayKham_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayKham"]);
            this.Trieuchung_Static = (string)FunctionCommon.GetDBValue(row["Trieuchung"]);
            this.KetQua_Static = (string)FunctionCommon.GetDBValue(row["KetQua"]);
            this.Huyetap_Static = (string)FunctionCommon.GetDBValue(row["Huyetap"]);
            this.ChieuCao_Static = (string)FunctionCommon.GetDBValue(row["ChieuCao"]);
            this.CanNang_Static = (string)FunctionCommon.GetDBValue(row["CanNang"]);
            this.NgayTiepNhan_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayTiepNhan"]);
            this.NguoiTiepNhan_Static = (decimal)FunctionCommon.GetDBValue(row["NguoiTiepNhan"]);
            this.DichVu_Static = (string)FunctionCommon.GetDBValue(row["DichVu"]);
            this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]);
        }
    }
}
