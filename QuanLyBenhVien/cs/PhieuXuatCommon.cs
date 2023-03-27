using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class PhieuXuatCommon 
     {       
 /// Insert  
public static decimal Insert(decimal NguoiLap, DateTime NgayLap, DateTime NgayXuat, decimal NguoiXuat, string GhiChu, decimal TinhTrangId, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("PhieuXuat", new object[] { NguoiLap, NgayLap, NgayXuat, NguoiXuat, GhiChu, TinhTrangId, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("PhieuXuat","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("PhieuXuat", field, paraValue); 
 }
        public static DataTable PhieuXuat_Select_Ngay(DateTime ngay)
        {
            return ConnectionSQL.GetDataTable("PhieuXuat_Select_Ngay", new object[] {ngay});
        }
        /// Update 
        public static void Update_NguoiLap(decimal Id, decimal NguoiLap)
{
     ConnectionSQL.ExecuteUpdate("PhieuXuat", "NguoiLap", new object[] { Id, NguoiLap});
} 
public static void Update_NgayLap(decimal Id, DateTime NgayLap)
{
     ConnectionSQL.ExecuteUpdate("PhieuXuat", "NgayLap", new object[] { Id, NgayLap});
} 
public static void Update_NgayXuat(decimal Id, DateTime NgayXuat)
{
     ConnectionSQL.ExecuteUpdate("PhieuXuat", "NgayXuat", new object[] { Id, NgayXuat});
} 
public static void Update_NguoiXuat(decimal Id, decimal NguoiXuat)
{
     ConnectionSQL.ExecuteUpdate("PhieuXuat", "NguoiXuat", new object[] { Id, NguoiXuat});
} 
public static void Update_GhiChu(decimal Id, string GhiChu)
{
     ConnectionSQL.ExecuteUpdate("PhieuXuat", "GhiChu", new object[] { Id, GhiChu});
} 
public static void Update_TinhTrangId(decimal Id, decimal TinhTrangId)
{
     ConnectionSQL.ExecuteUpdate("PhieuXuat", "TinhTrangId", new object[] { Id, TinhTrangId});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("PhieuXuat", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("PhieuXuat", Id ); 
} 
} 
} 
