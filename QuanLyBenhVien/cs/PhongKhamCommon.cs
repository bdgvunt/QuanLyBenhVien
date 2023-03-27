using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class PhongKhamCommon 
     {       
 /// Insert  
public static decimal Insert(string TenPhongKham, string GhiChu, decimal TinhTrangId, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("PhongKham", new object[] { TenPhongKham, GhiChu, TinhTrangId, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("PhongKham","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("PhongKham", field, paraValue); 
 } 
 /// Update 
public static void Update_TenPhongKham(decimal Id, string TenPhongKham)
{
     ConnectionSQL.ExecuteUpdate("PhongKham", "TenPhongKham", new object[] { Id, TenPhongKham});
} 
public static void Update_GhiChu(decimal Id, string GhiChu)
{
     ConnectionSQL.ExecuteUpdate("PhongKham", "GhiChu", new object[] { Id, GhiChu});
} 
public static void Update_TinhTrangId(decimal Id, decimal TinhTrangId)
{
     ConnectionSQL.ExecuteUpdate("PhongKham", "TinhTrangId", new object[] { Id, TinhTrangId});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("PhongKham", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("PhongKham", Id ); 
} 
} 
} 
