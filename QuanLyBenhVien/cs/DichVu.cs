using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class DichVu
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private string TenDichVu_Static;
private string LoaiDichVu_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public string TenDichVu
{ 
     get 
     { 
         return this.TenDichVu_Static; 
     } 
     set 
     { 
         DichVuCommon.Update_TenDichVu(this.Id, value);
         this.TenDichVu_Static = value;
     }
} 


public string LoaiDichVu
{ 
     get 
     { 
         return this.LoaiDichVu_Static; 
     } 
     set 
     { 
         DichVuCommon.Update_LoaiDichVu(this.Id, value);
         this.LoaiDichVu_Static = value;
     }
} 


public decimal TrangThaiId
{ 
     get 
     { 
         return this.TrangThaiId_Static; 
     } 
     set 
     { 
         DichVuCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectDichVu
        /// </summary> 
public DichVu(decimal Id)
{
    DataTable Table = DichVuCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildDichVu(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có DichVu!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildDichVu(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.TenDichVu_Static = (string)FunctionCommon.GetDBValue(row["TenDichVu"]); 
    this.LoaiDichVu_Static = (string)FunctionCommon.GetDBValue(row["LoaiDichVu"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
