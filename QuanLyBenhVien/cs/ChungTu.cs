using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class ChungTu
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private decimal MaLuotKham_Static;
private decimal MaNhanVien_Static;
private decimal NguoiThuTien_Static;
private DateTime NgayLap_Static;
private DateTime NgayThu_Static;
private string GhiChu_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public decimal MaLuotKham
{ 
     get 
     { 
         return this.MaLuotKham_Static; 
     } 
     set 
     { 
         ChungTuCommon.Update_MaLuotKham(this.Id, value);
         this.MaLuotKham_Static = value;
     }
} 


public decimal MaNhanVien
{ 
     get 
     { 
         return this.MaNhanVien_Static; 
     } 
     set 
     { 
         ChungTuCommon.Update_MaNhanVien(this.Id, value);
         this.MaNhanVien_Static = value;
     }
} 


public decimal NguoiThuTien
{ 
     get 
     { 
         return this.NguoiThuTien_Static; 
     } 
     set 
     { 
         ChungTuCommon.Update_NguoiThuTien(this.Id, value);
         this.NguoiThuTien_Static = value;
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
         ChungTuCommon.Update_NgayLap(this.Id, value);
         this.NgayLap_Static = value;
     }
} 


public DateTime NgayThu
{ 
     get 
     { 
         return this.NgayThu_Static; 
     } 
     set 
     { 
         ChungTuCommon.Update_NgayThu(this.Id, value);
         this.NgayThu_Static = value;
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
         ChungTuCommon.Update_GhiChu(this.Id, value);
         this.GhiChu_Static = value;
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
         ChungTuCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectChungTu
        /// </summary> 
public ChungTu(decimal Id)
{
    DataTable Table = ChungTuCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildChungTu(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có ChungTu!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildChungTu(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.MaLuotKham_Static = (decimal)FunctionCommon.GetDBValue(row["MaLuotKham"]); 
    this.MaNhanVien_Static = (decimal)FunctionCommon.GetDBValue(row["MaNhanVien"]); 
    this.NguoiThuTien_Static = (decimal)FunctionCommon.GetDBValue(row["NguoiThuTien"]); 
    this.NgayLap_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayLap"]); 
    this.NgayThu_Static = (DateTime)FunctionCommon.GetDBValue(row["NgayThu"]); 
    this.GhiChu_Static = (string)FunctionCommon.GetDBValue(row["GhiChu"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
