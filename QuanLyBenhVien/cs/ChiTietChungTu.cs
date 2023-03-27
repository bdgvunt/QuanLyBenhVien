using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class ChiTietChungTu
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private decimal MaChungTu_Static;
private decimal MaChiDinh_Static;
private decimal Loai_Static;
private decimal SoTien_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public decimal MaChungTu
{ 
     get 
     { 
         return this.MaChungTu_Static; 
     } 
     set 
     { 
         ChiTietChungTuCommon.Update_MaChungTu(this.Id, value);
         this.MaChungTu_Static = value;
     }
} 


public decimal MaChiDinh
{ 
     get 
     { 
         return this.MaChiDinh_Static; 
     } 
     set 
     { 
         ChiTietChungTuCommon.Update_MaChiDinh(this.Id, value);
         this.MaChiDinh_Static = value;
     }
} 


public decimal Loai
{ 
     get 
     { 
         return this.Loai_Static; 
     } 
     set 
     { 
         ChiTietChungTuCommon.Update_Loai(this.Id, value);
         this.Loai_Static = value;
     }
} 


public decimal SoTien
{ 
     get 
     { 
         return this.SoTien_Static; 
     } 
     set 
     { 
         ChiTietChungTuCommon.Update_SoTien(this.Id, value);
         this.SoTien_Static = value;
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
         ChiTietChungTuCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectChiTietChungTu
        /// </summary> 
public ChiTietChungTu(decimal Id)
{
    DataTable Table = ChiTietChungTuCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildChiTietChungTu(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có ChiTietChungTu!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildChiTietChungTu(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.MaChungTu_Static = (decimal)FunctionCommon.GetDBValue(row["MaChungTu"]); 
    this.MaChiDinh_Static = (decimal)FunctionCommon.GetDBValue(row["MaChiDinh"]); 
    this.Loai_Static = (decimal)FunctionCommon.GetDBValue(row["Loai"]); 
    this.SoTien_Static = (decimal)FunctionCommon.GetDBValue(row["SoTien"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
