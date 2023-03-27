using QuanLyBenhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            //gcTable.DataSource = ConnectionSQL.ExecuteFreeSelect("SELECT * FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME;");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                string Class = "";
                string Table = dgv.SelectedRows[0].Cells["TABLE_NAME"].ToString();

                // lay thong tin cua table

                DataTable dt = ConnectionSQL.ExecuteFreeSelect("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + Table + "'");
                Class = "using System;" + Environment.NewLine
                        + "using System.Collections.Generic;" + Environment.NewLine
                        + "using System.Linq;" + Environment.NewLine
                        + "using System.Text;" + Environment.NewLine
                        + "using System.Data;" + Environment.NewLine + Environment.NewLine

                        + "namespace " + Assembly.GetExecutingAssembly().GetName().Name + Environment.NewLine
                        + "{  " + Environment.NewLine
                        + "    public class " + Table + Environment.NewLine
                        + "    { " + Environment.NewLine
                        + "        /// <summary> " + Environment.NewLine
                        + "        /// Khai báo biến static" + Environment.NewLine
                        + "        /// </summary> " + Environment.NewLine;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Class = Class + "private " + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + " " + dt.Rows[i]["COLUMN_NAME"].ToString() + "_Static;" + Environment.NewLine;
                }

                Class = Class + Environment.NewLine;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Class = Class
                    + "public " + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + " " + dt.Rows[i]["COLUMN_NAME"].ToString() + Environment.NewLine
                    + "{ " + Environment.NewLine
                    + "     get " + Environment.NewLine
                    + "     { " + Environment.NewLine
                    + "         return this." + dt.Rows[i]["COLUMN_NAME"].ToString() + "_Static; " + Environment.NewLine
                    + "     } " + Environment.NewLine;
                    if (dt.Rows[i]["COLUMN_NAME"].ToString() != "Id")
                        Class = Class
                    + "     set " + Environment.NewLine
                    + "     { " + Environment.NewLine
                    + "         " + Table + "Common.Update_" + dt.Rows[i]["COLUMN_NAME"].ToString() + "(this.Id, value);" + Environment.NewLine
                    + "         this." + dt.Rows[i]["COLUMN_NAME"].ToString() + "_Static = value;" + Environment.NewLine
                    + "     }" + Environment.NewLine;

                    Class = Class
                    + "} " + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                }


                Class = Class
                + "        /// <summary> " + Environment.NewLine
                + "        /// Hàm khởi tạo Object" + Table + Environment.NewLine
                + "        /// </summary> " + Environment.NewLine;


                Class = Class
                + "public " + Table + "(decimal Id)" + Environment.NewLine
                + "{" + Environment.NewLine
                + "    DataTable Table = " + Table + "Common.Select_field(\"Id\",new object[] { Id });" + Environment.NewLine
                + "    if (Table.Rows.Count > 0)" + Environment.NewLine
                + "    {" + Environment.NewLine
                + "        Build" + Table + "(Table.Rows[0]);" + Environment.NewLine
                + "    } " + Environment.NewLine
                + "    else " + Environment.NewLine
                + "        throw new Exception(\"Không có " + Table + "!\"); " + Environment.NewLine
                + " } " + Environment.NewLine + Environment.NewLine;

                Class = Class
                + "        /// <summary> " + Environment.NewLine
                + "        /// Gán giá trị từ database vào biến static" + Environment.NewLine
                + "        /// </summary> " + Environment.NewLine;


                Class = Class
                + "private void Build" + Table + "(DataRow row) " + Environment.NewLine
                + "{ " + Environment.NewLine;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Class = Class + "    this." + dt.Rows[i]["COLUMN_NAME"].ToString() + "_Static = (" + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + ")FunctionCommon.GetDBValue(row[\"" + dt.Rows[i]["COLUMN_NAME"].ToString() + "\"]); " + Environment.NewLine;
                }
                Class = Class + "}" + Environment.NewLine;

                Class = Class + "}" + Environment.NewLine;
                Class = Class + "}" + Environment.NewLine;

                teClass.Text = Class;


                string Common = "";

                Common = Common
                + "using System; " + Environment.NewLine
                + "using System.Collections.Generic; " + Environment.NewLine
                + "using System.Linq; " + Environment.NewLine
                + "using System.Text; " + Environment.NewLine
                + "using System.Data; " + Environment.NewLine + Environment.NewLine;

                Common = Common
                + "namespace " + Assembly.GetExecutingAssembly().GetName().Name + Environment.NewLine
                + "{ " + Environment.NewLine
                + "     public static class " + Table + "Common " + Environment.NewLine
                + "     {       " + Environment.NewLine
                + " /// Insert  " + Environment.NewLine
                + "public static decimal Insert(";
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    Common = Common + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + " " + dt.Rows[i]["COLUMN_NAME"].ToString();
                    if (i != dt.Rows.Count - 1) Common = Common + ", "; else Common = Common + ")";
                }

                //decimal PhongKhamId, string HoTen, string DiaChi, DateTime NgaySinh, decimal GioiTinh, string SoDienThoai, decimal NgheNghiepId, decimal TrangThaiId)
                Common = Common
                + Environment.NewLine + "{ " + Environment.NewLine
                + "return ConnectionSQL.ExecuteInsertRow(\"" + Table + "\", new object[] { ";

                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    Common = Common + dt.Rows[i]["COLUMN_NAME"].ToString();
                    if (i != dt.Rows.Count - 1) Common = Common + ", "; else Common = Common + "});";
                }

                Common = Common
                + Environment.NewLine + "} " + Environment.NewLine
                + " /// Select " + Environment.NewLine
                + "public static DataTable Select() " + Environment.NewLine
                + "{  " + Environment.NewLine
                + "    return ConnectionSQL.ExecuteSelect(\"" + Table + "\",\"\", new object[] { }); " + Environment.NewLine
                + "} " + Environment.NewLine
                + "public static DataTable Select_field(string field, object[] paraValue) " + Environment.NewLine
                + "{ " + Environment.NewLine
                + "    return ConnectionSQL.ExecuteSelect(\"" + Table + "\", field, paraValue); " + Environment.NewLine
                + " } " + Environment.NewLine;

                Common = Common
                    + " /// Update " + Environment.NewLine;
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    Common = Common
                        + "public static void Update_" + dt.Rows[i]["COLUMN_NAME"].ToString() + "(decimal Id, " + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + " " + dt.Rows[i]["COLUMN_NAME"].ToString() + ")" + Environment.NewLine
                        + "{" + Environment.NewLine
                        + "     ConnectionSQL.ExecuteUpdate(\"" + Table + "\", \"" + dt.Rows[i]["COLUMN_NAME"].ToString() + "\", new object[] { Id, " + dt.Rows[i]["COLUMN_NAME"].ToString() + "});" + Environment.NewLine
                        + "} " + Environment.NewLine;
                }

                //  + PhongKhamId, HoTen, DiaChi, NgaySinh, GioiTinh, SoDienThoai, NgheNghiepId, TrangThaiId });
                //  }

                Common = Common
                    + "/// Delete " + Environment.NewLine
                    + " public static void Delete(decimal Id)" + Environment.NewLine
                    + "{ " + Environment.NewLine
                    + " ConnectionSQL.ExecuteDelete(\"" + Table + "\", Id ); " + Environment.NewLine
                    + "} " + Environment.NewLine
                + "} " + Environment.NewLine
                + "} " + Environment.NewLine;

                teCommon.Text = Common;

            }




        }
        private string MappingType(string SQLtype)
        {
            if (SQLtype == "numeric" || SQLtype == "decimal") return "decimal";
            if (SQLtype == "nvarchar") return "string";
            if (SQLtype == "date" || SQLtype == "datetime") return "DateTime";
            return "";
        }

        private void xtpCommon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string folderName = dialog.SelectedPath;

                    //  string createText = "Hello and Welcome" + Environment.NewLine;
                    string Table = dgv.SelectedRows[0].Cells["TABLE_NAME"].ToString();
                    System.IO.File.WriteAllText(folderName + "\\" + Table + ".cs", teClass.Text);

                    System.IO.File.WriteAllText(folderName + "\\" + Table + "Common.cs", teCommon.Text);
                    //   teThuMucLayAnhCDHA.Text = folderName;

                }
            }
        }

        private void frmClass_Load_1(object sender, EventArgs e)
        {
            dgv.DataSource = ConnectionSQL.ExecuteFreeSelect("SELECT * FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgv.SelectedRows.Count > 0)
                {
                    string Class = "";
                    string Table = dgv.SelectedRows[0].Cells["TABLE_NAME"].Value.ToString();

                    // lay thong tin cua table

                    DataTable dt = ConnectionSQL.ExecuteFreeSelect("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + Table + "'");
                    Class = "using System;" + Environment.NewLine
                            + "using System.Collections.Generic;" + Environment.NewLine
                            + "using System.Linq;" + Environment.NewLine
                            + "using System.Text;" + Environment.NewLine
                            + "using System.Data;" + Environment.NewLine + Environment.NewLine

                            + "namespace " + Assembly.GetExecutingAssembly().GetName().Name + Environment.NewLine
                            + "{  " + Environment.NewLine
                            + "    public class " + Table + Environment.NewLine
                            + "    { " + Environment.NewLine
                            + "        /// <summary> " + Environment.NewLine
                            + "        /// Khai báo biến static" + Environment.NewLine
                            + "        /// </summary> " + Environment.NewLine;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Class = Class + "private " + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + " " + dt.Rows[i]["COLUMN_NAME"].ToString() + "_Static;" + Environment.NewLine;
                    }

                    Class = Class + Environment.NewLine;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Class = Class
                        + "public " + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + " " + dt.Rows[i]["COLUMN_NAME"].ToString() + Environment.NewLine
                        + "{ " + Environment.NewLine
                        + "     get " + Environment.NewLine
                        + "     { " + Environment.NewLine
                        + "         return this." + dt.Rows[i]["COLUMN_NAME"].ToString() + "_Static; " + Environment.NewLine
                        + "     } " + Environment.NewLine;
                        if (dt.Rows[i]["COLUMN_NAME"].ToString() != "Id")
                            Class = Class
                        + "     set " + Environment.NewLine
                        + "     { " + Environment.NewLine
                        + "         " + Table + "Common.Update_" + dt.Rows[i]["COLUMN_NAME"].ToString() + "(this.Id, value);" + Environment.NewLine
                        + "         this." + dt.Rows[i]["COLUMN_NAME"].ToString() + "_Static = value;" + Environment.NewLine
                        + "     }" + Environment.NewLine;

                        Class = Class
                        + "} " + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                    }


                    Class = Class
                    + "        /// <summary> " + Environment.NewLine
                    + "        /// Hàm khởi tạo Object" + Table + Environment.NewLine
                    + "        /// </summary> " + Environment.NewLine;


                    Class = Class
                    + "public " + Table + "(decimal Id)" + Environment.NewLine
                    + "{" + Environment.NewLine
                    + "    DataTable Table = " + Table + "Common.Select_field(\"Id\",new object[] { Id });" + Environment.NewLine
                    + "    if (Table.Rows.Count > 0)" + Environment.NewLine
                    + "    {" + Environment.NewLine
                    + "        Build" + Table + "(Table.Rows[0]);" + Environment.NewLine
                    + "    } " + Environment.NewLine
                    + "    else " + Environment.NewLine
                    + "        throw new Exception(\"Không có " + Table + "!\"); " + Environment.NewLine
                    + " } " + Environment.NewLine + Environment.NewLine;

                    Class = Class
                    + "        /// <summary> " + Environment.NewLine
                    + "        /// Gán giá trị từ database vào biến static" + Environment.NewLine
                    + "        /// </summary> " + Environment.NewLine;


                    Class = Class
                    + "private void Build" + Table + "(DataRow row) " + Environment.NewLine
                    + "{ " + Environment.NewLine;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Class = Class + "    this." + dt.Rows[i]["COLUMN_NAME"].ToString() + "_Static = (" + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + ")FunctionCommon.GetDBValue(row[\"" + dt.Rows[i]["COLUMN_NAME"].ToString() + "\"]); " + Environment.NewLine;
                    }
                    Class = Class + "}" + Environment.NewLine;

                    Class = Class + "}" + Environment.NewLine;
                    Class = Class + "}" + Environment.NewLine;

                    tbClass.Text = Class;


                    string Common = "";

                    Common = Common
                    + "using System; " + Environment.NewLine
                    + "using System.Collections.Generic; " + Environment.NewLine
                    + "using System.Linq; " + Environment.NewLine
                    + "using System.Text; " + Environment.NewLine
                    + "using System.Data; " + Environment.NewLine + Environment.NewLine;

                    Common = Common
                    + "namespace " + Assembly.GetExecutingAssembly().GetName().Name + Environment.NewLine
                    + "{ " + Environment.NewLine
                    + "     public static class " + Table + "Common " + Environment.NewLine
                    + "     {       " + Environment.NewLine
                    + " /// Insert  " + Environment.NewLine
                    + "public static decimal Insert(";
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        Common = Common + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + " " + dt.Rows[i]["COLUMN_NAME"].ToString();
                        if (i != dt.Rows.Count - 1) Common = Common + ", "; else Common = Common + ")";
                    }

                    //decimal PhongKhamId, string HoTen, string DiaChi, DateTime NgaySinh, decimal GioiTinh, string SoDienThoai, decimal NgheNghiepId, decimal TrangThaiId)
                    Common = Common
                    + Environment.NewLine + "{ " + Environment.NewLine
                    + "return ConnectionSQL.ExecuteInsertRow(\"" + Table + "\", new object[] { ";

                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        Common = Common + dt.Rows[i]["COLUMN_NAME"].ToString();
                        if (i != dt.Rows.Count - 1) Common = Common + ", "; else Common = Common + "});";
                    }

                    Common = Common
                    + Environment.NewLine + "} " + Environment.NewLine
                    + " /// Select " + Environment.NewLine
                    + "public static DataTable Select() " + Environment.NewLine
                    + "{  " + Environment.NewLine
                    + "    return ConnectionSQL.ExecuteSelect(\"" + Table + "\",\"\", new object[] { }); " + Environment.NewLine
                    + "} " + Environment.NewLine
                    + "public static DataTable Select_field(string field, object[] paraValue) " + Environment.NewLine
                    + "{ " + Environment.NewLine
                    + "    return ConnectionSQL.ExecuteSelect(\"" + Table + "\", field, paraValue); " + Environment.NewLine
                    + " } " + Environment.NewLine;

                    Common = Common
                        + " /// Update " + Environment.NewLine;
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        Common = Common
                            + "public static void Update_" + dt.Rows[i]["COLUMN_NAME"].ToString() + "(decimal Id, " + MappingType(dt.Rows[i]["DATA_TYPE"].ToString()) + " " + dt.Rows[i]["COLUMN_NAME"].ToString() + ")" + Environment.NewLine
                            + "{" + Environment.NewLine
                            + "     ConnectionSQL.ExecuteUpdate(\"" + Table + "\", \"" + dt.Rows[i]["COLUMN_NAME"].ToString() + "\", new object[] { Id, " + dt.Rows[i]["COLUMN_NAME"].ToString() + "});" + Environment.NewLine
                            + "} " + Environment.NewLine;
                    }

                    //  + PhongKhamId, HoTen, DiaChi, NgaySinh, GioiTinh, SoDienThoai, NgheNghiepId, TrangThaiId });
                    //  }

                    Common = Common
                        + "/// Delete " + Environment.NewLine
                        + " public static void Delete(decimal Id)" + Environment.NewLine
                        + "{ " + Environment.NewLine
                        + " ConnectionSQL.ExecuteDelete(\"" + Table + "\", Id ); " + Environment.NewLine
                        + "} " + Environment.NewLine
                    + "} " + Environment.NewLine
                    + "} " + Environment.NewLine;

                    tbCommon.Text = Common;

                }

            }
            catch (Exception ex)
            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string folderName = dialog.SelectedPath;

                    //  string createText = "Hello and Welcome" + Environment.NewLine;
                    string Table = dgv.SelectedRows[0].Cells["TABLE_NAME"].Value.ToString();
                 //   string Table = dgv.SelectedRows[0].Cells["TABLE_NAME"].Value.ToString();

                    System.IO.File.WriteAllText(folderName + "\\" + Table + ".cs", tbClass.Text);

                    System.IO.File.WriteAllText(folderName + "\\" + Table + "Common.cs", tbCommon.Text);
                    //   teThuMucLayAnhCDHA.Text = folderName;

                }
            }
        }
    }
}
