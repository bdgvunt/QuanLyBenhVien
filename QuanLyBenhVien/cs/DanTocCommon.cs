using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class DanTocCommon 
     {       
 /// Insert  
public static decimal Insert(string TenDanToc, string GhiChu, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("DanToc", new object[] { TenDanToc, GhiChu, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("DanToc","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("DanToc", field, paraValue); 
 } 
 /// Update 
public static void Update_TenDanToc(decimal Id, string TenDanToc)
{
     ConnectionSQL.ExecuteUpdate("DanToc", "TenDanToc", new object[] { Id, TenDanToc});
} 
public static void Update_GhiChu(decimal Id, string GhiChu)
{
     ConnectionSQL.ExecuteUpdate("DanToc", "GhiChu", new object[] { Id, GhiChu});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("DanToc", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("DanToc", Id ); 
} 
} 
} 
