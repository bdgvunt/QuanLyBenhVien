using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class DonViTinhCommon 
     {       
 /// Insert  
public static decimal Insert(string TenDonViTinh, string GhiChu, decimal TinhTrangId, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("DonViTinh", new object[] { TenDonViTinh, GhiChu, TinhTrangId, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("DonViTinh","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("DonViTinh", field, paraValue); 
 } 
 /// Update 
public static void Update_TenDonViTinh(decimal Id, string TenDonViTinh)
{
     ConnectionSQL.ExecuteUpdate("DonViTinh", "TenDonViTinh", new object[] { Id, TenDonViTinh});
} 
public static void Update_GhiChu(decimal Id, string GhiChu)
{
     ConnectionSQL.ExecuteUpdate("DonViTinh", "GhiChu", new object[] { Id, GhiChu});
} 
public static void Update_TinhTrangId(decimal Id, decimal TinhTrangId)
{
     ConnectionSQL.ExecuteUpdate("DonViTinh", "TinhTrangId", new object[] { Id, TinhTrangId});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("DonViTinh", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("DonViTinh", Id ); 
} 
} 
} 
