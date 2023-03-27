using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public static class ChungTuCommon
    {
        /// Insert  
        public static decimal Insert(decimal MaLuotKham, decimal MaNhanVien, decimal NguoiThuTien, DateTime NgayLap, DateTime NgayThu, string GhiChu, decimal TrangThaiId)
        {
            return ConnectionSQL.ExecuteInsertRow("ChungTu", new object[] { MaLuotKham, MaNhanVien, NguoiThuTien, NgayLap, NgayThu, GhiChu, TrangThaiId });
        }
        /// Select 
        public static DataTable Select()
        {
            return ConnectionSQL.ExecuteSelect("ChungTu", "", new object[] { });
        }
        public static DataTable Select_field(string field, object[] paraValue)
        {
            return ConnectionSQL.ExecuteSelect("ChungTu", field, paraValue);
        }
        public static DataTable Select_DSTheoNgay(DateTime ngay)
        {
            return ConnectionSQL.GetDataTable("ChungTu_Select_Ngay", new object[] { ngay });
        }
        /// Update 
        public static void Update_MaLuotKham(decimal Id, decimal MaLuotKham)
        {
            ConnectionSQL.ExecuteUpdate("ChungTu", "MaLuotKham", new object[] { Id, MaLuotKham });
        }
        public static void Update_MaNhanVien(decimal Id, decimal MaNhanVien)
        {
            ConnectionSQL.ExecuteUpdate("ChungTu", "MaNhanVien", new object[] { Id, MaNhanVien });
        }
        public static void Update_NguoiThuTien(decimal Id, decimal NguoiThuTien)
        {
            ConnectionSQL.ExecuteUpdate("ChungTu", "NguoiThuTien", new object[] { Id, NguoiThuTien });
        }
        public static void Update_NgayLap(decimal Id, DateTime NgayLap)
        {
            ConnectionSQL.ExecuteUpdate("ChungTu", "NgayLap", new object[] { Id, NgayLap });
        }
        public static void Update_NgayThu(decimal Id, DateTime NgayThu)
        {
            ConnectionSQL.ExecuteUpdate("ChungTu", "NgayThu", new object[] { Id, NgayThu });
        }
        public static void Update_GhiChu(decimal Id, string GhiChu)
        {
            ConnectionSQL.ExecuteUpdate("ChungTu", "GhiChu", new object[] { Id, GhiChu });
        }
        public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
        {
            ConnectionSQL.ExecuteUpdate("ChungTu", "TrangThaiId", new object[] { Id, TrangThaiId });
        }
        /// Delete 
        public static void Delete(decimal Id)
        {
            ConnectionSQL.ExecuteDelete("ChungTu", Id);
        }
    }
}
