using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QuanLyBenhVien
{  
    public class ChiTietPhieuNhap
    { 
        /// <summary> 
        /// Khai báo biến static
        /// </summary> 
private decimal Id_Static;
private decimal MaPhieuNhap_Static;
private decimal MaThuoc_Static;
private string SoLo_Static;
private DateTime HanDung_Static;
private decimal SoLuong_Static;
private decimal DonGia_Static;
private decimal GhiChu_Static;
private decimal TrangThaiId_Static;

public decimal Id
{ 
     get 
     { 
         return this.Id_Static; 
     } 
} 


public decimal MaPhieuNhap
{ 
     get 
     { 
         return this.MaPhieuNhap_Static; 
     } 
     set 
     { 
         ChiTietPhieuNhapCommon.Update_MaPhieuNhap(this.Id, value);
         this.MaPhieuNhap_Static = value;
     }
} 


public decimal MaThuoc
{ 
     get 
     { 
         return this.MaThuoc_Static; 
     } 
     set 
     { 
         ChiTietPhieuNhapCommon.Update_MaThuoc(this.Id, value);
         this.MaThuoc_Static = value;
     }
} 


public string SoLo
{ 
     get 
     { 
         return this.SoLo_Static; 
     } 
     set 
     { 
         ChiTietPhieuNhapCommon.Update_SoLo(this.Id, value);
         this.SoLo_Static = value;
     }
} 


public DateTime HanDung
{ 
     get 
     { 
         return this.HanDung_Static; 
     } 
     set 
     { 
         ChiTietPhieuNhapCommon.Update_HanDung(this.Id, value);
         this.HanDung_Static = value;
     }
} 


public decimal SoLuong
{ 
     get 
     { 
         return this.SoLuong_Static; 
     } 
     set 
     { 
         ChiTietPhieuNhapCommon.Update_SoLuong(this.Id, value);
         this.SoLuong_Static = value;
     }
} 


public decimal DonGia
{ 
     get 
     { 
         return this.DonGia_Static; 
     } 
     set 
     { 
         ChiTietPhieuNhapCommon.Update_DonGia(this.Id, value);
         this.DonGia_Static = value;
     }
} 


public decimal GhiChu
{ 
     get 
     { 
         return this.GhiChu_Static; 
     } 
     set 
     { 
         ChiTietPhieuNhapCommon.Update_GhiChu(this.Id, value);
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
         ChiTietPhieuNhapCommon.Update_TrangThaiId(this.Id, value);
         this.TrangThaiId_Static = value;
     }
} 


        /// <summary> 
        /// Hàm khởi tạo ObjectChiTietPhieuNhap
        /// </summary> 
public ChiTietPhieuNhap(decimal Id)
{
    DataTable Table = ChiTietPhieuNhapCommon.Select_field("Id",new object[] { Id });
    if (Table.Rows.Count > 0)
    {
        BuildChiTietPhieuNhap(Table.Rows[0]);
    } 
    else 
        throw new Exception("Không có ChiTietPhieuNhap!"); 
 } 

        /// <summary> 
        /// Gán giá trị từ database vào biến static
        /// </summary> 
private void BuildChiTietPhieuNhap(DataRow row) 
{ 
    this.Id_Static = (decimal)FunctionCommon.GetDBValue(row["Id"]); 
    this.MaPhieuNhap_Static = (decimal)FunctionCommon.GetDBValue(row["MaPhieuNhap"]); 
    this.MaThuoc_Static = (decimal)FunctionCommon.GetDBValue(row["MaThuoc"]); 
    this.SoLo_Static = (string)FunctionCommon.GetDBValue(row["SoLo"]); 
    this.HanDung_Static = (DateTime)FunctionCommon.GetDBValue(row["HanDung"]); 
    this.SoLuong_Static = (decimal)FunctionCommon.GetDBValue(row["SoLuong"]); 
    this.DonGia_Static = (decimal)FunctionCommon.GetDBValue(row["DonGia"]); 
    this.GhiChu_Static = (decimal)FunctionCommon.GetDBValue(row["GhiChu"]); 
    this.TrangThaiId_Static = (decimal)FunctionCommon.GetDBValue(row["TrangThaiId"]); 
}
}
}
