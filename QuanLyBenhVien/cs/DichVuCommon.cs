using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Data; 

namespace QuanLyBenhVien
{ 
     public static class DichVuCommon 
     {       
 /// Insert  
public static decimal Insert(string TenDichVu, string LoaiDichVu, decimal TrangThaiId)
{ 
return ConnectionSQL.ExecuteInsertRow("DichVu", new object[] { TenDichVu, LoaiDichVu, TrangThaiId});
} 
 /// Select 
public static DataTable Select() 
{  
    return ConnectionSQL.ExecuteSelect("DichVu","", new object[] { }); 
} 
public static DataTable Select_field(string field, object[] paraValue) 
{ 
    return ConnectionSQL.ExecuteSelect("DichVu", field, paraValue); 
 } 
 /// Update 
public static void Update_TenDichVu(decimal Id, string TenDichVu)
{
     ConnectionSQL.ExecuteUpdate("DichVu", "TenDichVu", new object[] { Id, TenDichVu});
} 
public static void Update_LoaiDichVu(decimal Id, string LoaiDichVu)
{
     ConnectionSQL.ExecuteUpdate("DichVu", "LoaiDichVu", new object[] { Id, LoaiDichVu});
} 
public static void Update_TrangThaiId(decimal Id, decimal TrangThaiId)
{
     ConnectionSQL.ExecuteUpdate("DichVu", "TrangThaiId", new object[] { Id, TrangThaiId});
} 
/// Delete 
 public static void Delete(decimal Id)
{ 
 ConnectionSQL.ExecuteDelete("DichVu", Id ); 
} 
} 
} 
