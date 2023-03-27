using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public static class LuotKhamCommon
    {
        /// Insert  
        public static decimal Insert(decimal MaBenhNhan,  decimal MaTinhTrangKham, DateTime NgayKham, string Trieuchung, string KetQua, string Huyetap, string ChieuCao, string CanNang,String NhietDo,String Mach, DateTime NgayTiepNhan, decimal NguoiTiepNhan, string DichVu, decimal TrangThaiId)
        {
            return ConnectionSQL.ExecuteInsertRow("LuotKham", new object[] { MaBenhNhan, MaTinhTrangKham, NgayKham, Trieuchung, KetQua, Huyetap, ChieuCao, CanNang, NhietDo, Mach, NgayTiepNhan, NguoiTiepNhan, DichVu, TrangThaiId });
        }
        /// Select 
        public static DataTable Select()
        {
            return ConnectionSQL.ExecuteSelect("LuotKham", "", new object[] { });
        }
        public static DataTable Select_field(string field, object[] paraValue)
        {
            return ConnectionSQL.ExecuteSelect("LuotKham", field, paraValue);
        }

        public static DataTable Select_DSTheoNgay(DateTime ngay)
        {
            return ConnectionSQL.GetDataTable("LuotKham_Select_Ngay", new object[] { ngay  });
        }

        public static DataTable Select_ThongTinVienPhi(decimal LuotKhamId)
        {
            return ConnectionSQL.GetDataTable("LuotKham_Select_ThongTinVienPhi", new object[] { LuotKhamId });
        }

        public static DataTable Select_DSTheoNgayPhongKhamTinhTrangKham(DateTime ngay, decimal PhongKhamId, decimal TinhTrangKhamId)
        {
            return ConnectionSQL.GetDataTable("LuotKham_Select_Ngay_PhongKham_TinhTrang", new object[] { ngay , PhongKhamId, TinhTrangKhamId});
        }

        /// Update 
        public static void Update_MaBenhNhan(decimal Id, decimal MaBenhNhan)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "MaBenhNhan", new object[] { Id, MaBenhNhan });
        }
        public static void Update_MaTinhTrangKham(decimal Id, decimal TinhTrangKham)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "TinhTrangKham", new object[] { Id, TinhTrangKham });
        }
        public static void Update_NgayKham(decimal Id, DateTime NgayKham)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "NgayKham", new object[] { Id, NgayKham });
        }
        public static void Update_Trieuchung(decimal Id, string Trieuchung)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "Trieuchung", new object[] { Id, Trieuchung });
        }
        public static void Update_KetQua(decimal Id, string KetQua)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "KetQua", new object[] { Id, KetQua });
        }
        public static void Update_Huyetap(decimal Id, string Huyetap)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "Huyetap", new object[] { Id, Huyetap });
        }
        public static void Update_ChieuCao(decimal Id, string ChieuCao)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "ChieuCao", new object[] { Id, ChieuCao });
        }
        public static void Update_CanNang(decimal Id, string CanNang)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "CanNang", new object[] { Id, CanNang });
        }
        public static void Update_NgayTiepNhan(decimal Id, DateTime NgayTiepNhan)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "NgayTiepNhan", new object[] { Id, NgayTiepNhan });
        }
        public static void Update_NguoiTiepNhan(decimal Id, decimal NguoiTiepNhan)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "NguoiTiepNhan", new object[] { Id, NguoiTiepNhan });
        }
        public static void Update_DichVu(decimal Id, string DichVu)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "DichVu", new object[] { Id, DichVu });
        }
        public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
        {
            ConnectionSQL.ExecuteUpdate("LuotKham", "TrangThaiId", new object[] { Id, TrangThaiId });
        }
        /// Delete 
        public static void Delete(decimal Id)
        {
            ConnectionSQL.ExecuteDelete("LuotKham", Id);
        }
    }
}
