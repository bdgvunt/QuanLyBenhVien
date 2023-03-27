using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class LoaiKhamCommon 
     {       
 /// Insert  
public static decimal Insert(string TenLoaiKham, string GhiChu, decimal DichVuId, decimal TinhTrangId, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("LoaiKham", new object[] { TenLoaiKham, GhiChu, DichVuId, TinhTrangId, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("LoaiKham","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("LoaiKham", field, paraValue); 
 } 
 /// Update 
public static void Update_TenLoaiKham(decimal Id, string TenLoaiKham)
{
     ConnectionSQL.ExecuteUpdate("LoaiKham", "TenLoaiKham", new object[] { Id, TenLoaiKham});
} 
public static void Update_GhiChu(decimal Id, string GhiChu)
{
     ConnectionSQL.ExecuteUpdate("LoaiKham", "GhiChu", new object[] { Id, GhiChu});
} 
public static void Update_DichVuId(decimal Id, decimal DichVuId)
{
     ConnectionSQL.ExecuteUpdate("LoaiKham", "DichVuId", new object[] { Id, DichVuId});
} 
public static void Update_TinhTrangId(decimal Id, decimal TinhTrangId)
{
     ConnectionSQL.ExecuteUpdate("LoaiKham", "TinhTrangId", new object[] { Id, TinhTrangId});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("LoaiKham", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("LoaiKham", Id ); 
} 
} 
} 
