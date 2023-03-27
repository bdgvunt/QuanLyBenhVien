using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class PhongKham
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private string TenPhongKham_Static;
private string GhiChu_Static;
private decimal TinhTrangId_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public string TenPhongKham
{ 
     get 
     { 
         return this.TenPhongKham_Static; 
     } 
     set 
     { 
         PhongKhamCommon.Update_TenPhongKham(this.Id, value);
         this.TenPhongKham_Static = value;
     }
} 


public string GhiChu
{ 
     get 
     { 
         return this.GhiChu_Static; 
     } 
     set 
     { 
         PhongKhamCommon.Update_GhiChu(this.Id, value);
         this.GhiChu_Static = value;
     }
} 


public decimal TinhTrangId
{ 
     get 
     { 
         return this.TinhTrangId_Static; 
     } 
     set 
     { 
         PhongKhamCommon.Update_TinhTrangId(this.Id, value);
         this.TinhTrangId_Static = value;
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
         PhongKhamCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectPhongKham
        /// </summary> 
public PhongKham(decimal Id)
{
    DataTable Table = PhongKhamCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildPhongKham(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có PhongKham!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildPhongKham(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.TenPhongKham_Static = (string)FunctionCommon.GetDBValue(row["TenPhongKham"]); 
    this.GhiChu_Static = (string)FunctionCommon.GetDBValue(row["GhiChu"]); 
    this.TinhTrangId_Static = (decimal)FunctionCommon.GetDBValue(row["TinhTrangId"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
