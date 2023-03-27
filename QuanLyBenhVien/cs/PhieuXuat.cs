using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class PhieuXuat
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private decimal NguoiLap_Static;
private DateTime NgayLap_Static;
private DateTime NgayXuat_Static;
private decimal NguoiXuat_Static;
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


public decimal NguoiLap
{ 
     get 
     { 
         return this.NguoiLap_Static; 
     } 
     set 
     { 
         PhieuXuatCommon.Update_NguoiLap(this.Id, value);
         this.NguoiLap_Static = value;
     }
} 


public DateTime NgayLap
{ 
     get 
     { 
         return this.NgayLap_Static; 
     } 
     set 
     { 
         PhieuXuatCommon.Update_NgayLap(this.Id, value);
         this.NgayLap_Static = value;
     }
} 


public DateTime NgayXuat
{ 
     get 
     { 
         return this.NgayXuat_Static; 
     } 
     set 
     { 
         PhieuXuatCommon.Update_NgayXuat(this.Id, value);
         this.NgayXuat_Static = value;
     }
} 


public decimal NguoiXuat
{ 
     get 
     { 
         return this.NguoiXuat_Static; 
     } 
     set 
     { 
         PhieuXuatCommon.Update_NguoiXuat(this.Id, value);
         this.NguoiXuat_Static = value;
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
         PhieuXuatCommon.Update_GhiChu(this.Id, value);
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
         PhieuXuatCommon.Update_TinhTrangId(this.Id, value);
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
         PhieuXuatCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectPhieuXuat
        /// </summary> 
public PhieuXuat(decimal Id)
{
    DataTable Table = PhieuXuatCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildPhieuXuat(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có PhieuXuat!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildPhieuXuat(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.NguoiLap_Static = (decimal)FunctionCommon.GetDBValue(row["NguoiLap"]); 
    this.NgayLap_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayLap"]); 
    this.NgayXuat_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayXuat"]); 
    this.NguoiXuat_Static = (decimal)FunctionCommon.GetDBValue(row["NguoiXuat"]); 
    this.GhiChu_Static = (string)FunctionCommon.GetDBValue(row["GhiChu"]); 
    this.TinhTrangId_Static = (decimal)FunctionCommon.GetDBValue(row["TinhTrangId"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
