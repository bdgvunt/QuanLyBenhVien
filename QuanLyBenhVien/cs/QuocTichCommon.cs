using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class QuocTichCommon 
     {       
 /// Insert  
public static decimal Insert(string TenQuocTich, string GhiChu, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("QuocTich", new object[] { TenQuocTich, GhiChu, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("QuocTich","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("QuocTich", field, paraValue); 
 } 
 /// Update 
public static void Update_TenQuocTich(decimal Id, string TenQuocTich)
{
     ConnectionSQL.ExecuteUpdate("QuocTich", "TenQuocTich", new object[] { Id, TenQuocTich});
} 
public static void Update_GhiChu(decimal Id, string GhiChu)
{
     ConnectionSQL.ExecuteUpdate("QuocTich", "GhiChu", new object[] { Id, GhiChu});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("QuocTich", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("QuocTich", Id ); 
} 
} 
} 
