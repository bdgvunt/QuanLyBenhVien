using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{
    public static class ChiTietChungTuCommon
    {
        /// Insert  
        public static decimal Insert(decimal MaChungTu, decimal MaChiDinh, decimal Loai, decimal SoTien, decimal TrangThaiId)
        {
            return ConnectionSQL.ExecuteInsertRow("ChiTietChungTu", new object[] { MaChungTu, MaChiDinh, Loai, SoTien, TrangThaiId });
        }
        /// Select 
        public static DataTable Select()
        {
            return ConnectionSQL.ExecuteSelect("ChiTietChungTu", "", new object[] { });
        }
        public static DataTable Select_field(string field, object[] paraValue)
        {
            return ConnectionSQL.ExecuteSelect("ChiTietChungTu", field, paraValue);
        }
        public static DataTable Select_ChungTuId(decimal ChungTuId)
        {
            return ConnectionSQL.GetDataTable("ChiTietChungTu_Select_ChungTuId", new object[] { ChungTuId });
        }
        
        /// Update 
        public static void Update_MaChungTu(decimal Id, decimal MaChungTu)
        {
            ConnectionSQL.ExecuteUpdate("ChiTietChungTu", "MaChungTu", new object[] { Id, MaChungTu });
        }
        public static void Update_MaChiDinh(decimal Id, decimal MaChiDinh)
        {
            ConnectionSQL.ExecuteUpdate("ChiTietChungTu", "MaChiDinh", new object[] { Id, MaChiDinh });
        }
        public static void Update_Loai(decimal Id, decimal Loai)
        {
            ConnectionSQL.ExecuteUpdate("ChiTietChungTu", "Loai", new object[] { Id, Loai });
        }
        public static void Update_SoTien(decimal Id, decimal SoTien)
        {
            ConnectionSQL.ExecuteUpdate("ChiTietChungTu", "SoTien", new object[] { Id, SoTien });
        }
        public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
        {
            ConnectionSQL.ExecuteUpdate("ChiTietChungTu", "TrangThaiId", new object[] { Id, TrangThaiId });
        }
        /// Delete 
        public static void Delete(decimal Id)
        {
            ConnectionSQL.ExecuteDelete("ChiTietChungTu", Id);
        }
    }
}
