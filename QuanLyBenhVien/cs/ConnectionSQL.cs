using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace QuanLyBenhVien
{
    public static class ConnectionSQL
    {
        /// <summary>
        /// Biến để lưu chuỗi kết nối với SQL
        /// Biến này chứa giá trị xuyên suốt quá trình chạy phân mềm.
        /// </summary>
        //public static string ConnectionString = "Data Source=10.72.45.253;Initial Catalog=QLHIS;Persist Security Info=True;User ID=QLHIS;Password=gw34jnt67wewf678NIOoiocAS894j";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["KetNoiSQL"].ConnectionString;
        //CT
        //public static string ConnectionString = "Data Source=192.168.30.2;Initial Catalog=QLHIS;Persist Security Info=True;User ID=shpt;Password=shptsqlrwdata";

        //public static string ConnectionString = "Server=(local);Database=QLHIS;Trusted_Connection=True";

        /// <summary>
        /// Biến để lưu thông tin tài khoản và mật khẩu trên cổng BHYT.
        /// Sau này sẽ đổi qua lấy trong CSDL.
        /// </summary>
      //  public static string UsernameBHYT = "74165_TC";
      //  public static string PasswordBHYT = "P@ssword2019"; //"bvct2016";

      //  public static string UsernameBHYT = "74165_BV";
     //   public static string PasswordBHYT = "abc123+-"; //"bvct2016";

       // public static object ConfigurationManager { get; private set; }







        /// <summary>
        /// Hàm trả về danh sách các biến có trong proc SQL
        /// </summary>
        /// <param name="procedureName">Tên Proc</param>
        /// <returns>Datatable</returns>
        private static DataTable GetParameter(string procedureName)
        {
            SqlConnection conn = new SqlConnection(ConnectionString); ;
            SqlDataAdapter dataAdapter = null;
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand();
            InitSqlCommand(command, "LayDanhSachThamSo", conn);

            SqlParameter para = new SqlParameter();
            para.ParameterName = "@V_PROCNAME";
            para.Value = procedureName;
            command.Parameters.Add(para);

            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Hàm truyền vào các biến được lưu trong Command để hỗ trợ thực thi câu lệnh SQL
        /// </summary>
        /// <param name="command">Biến command</param>
        /// <param name="procedureName">Tên proc</param>
        /// <param name="connection">Biến kết nối sql</param>
        private static void InitSqlCommand(SqlCommand command, string procedureName, SqlConnection connection)
        {
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;
        }

        /// <summary>
        /// Hàm truyền giá trị vào các biến có trong Proc SQL
        /// </summary>
        /// <param name="procudureName">Tên Proc</param>
        /// <param name="command">Biến command</param>
        /// <param name="paraValue">Mảng giá trị các biến</param>
        private static void AddParameters(string procudureName, SqlCommand command, object[] paraValue)
        {
            DataTable dt_para = new DataTable();
            dt_para = GetParameter(procudureName);

            for (int index = 0; index <= dt_para.Rows.Count - 1; index += 1)
            {
                SqlParameter para = new SqlParameter();
                para.ParameterName = dt_para.Rows[index]["PARAMETER_NAME"].ToString();
                para.Value = (paraValue[index] == null ? DBNull.Value : paraValue[index]);
                command.Parameters.Add(para);
            }
        }

        /// <summary>
        /// Hàm lấy giá trị của Proc sau khi thực thi trả về bảng dữ liệu
        /// </summary>
        /// <param name="procudureName">Tên proc</param>
        /// <param name="paraValue">Mảng chứa giá trị của các biến truyền vào</param>
        /// <returns>DataTable</returns>
        public static DataTable GetDataTable(string procudureName, object[] paraValue)
        {
            SqlConnection conn = new SqlConnection(ConnectionString); ;
            SqlDataAdapter dataAdapter = null;
            DataTable dt = new DataTable();
            
            SqlCommand command = new SqlCommand();
            command.CommandTimeout = 100;
            InitSqlCommand(command, procudureName, conn);

            AddParameters(procudureName, command, paraValue);

            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);

            return dt;
        }

        public static DataTable GetDataTable(string procudureName, object[] paraValue, int TimeOut)
        {
            SqlConnection conn = new SqlConnection(ConnectionString); ;
            SqlDataAdapter dataAdapter = null;
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand();
            command.CommandTimeout = TimeOut;
            InitSqlCommand(command, procudureName, conn);

            AddParameters(procudureName, command, paraValue);

            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Hàm lấy giá trị của Proc sau khi thực thi trả về nhiều bảng dữ liệu
        /// </summary>
        /// <param name="procudureName">Tên Proc</param>
        /// <param name="paraValue">Mảng chứa giá trị của các biến truyền vào</param>
        /// <returns>DataSet</returns>
        public static DataSet GetDataSet(string procudureName, object[] paraValue)
        {
            SqlConnection conn = new SqlConnection(ConnectionString); ;
            SqlDataAdapter dataAdapter = null;
            DataSet ds = new DataSet();

            SqlCommand command = new SqlCommand();
            InitSqlCommand(command, procudureName, conn);

            AddParameters(procudureName, command, paraValue);

            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(ds);

            return ds;
        }

        public static DataSet GetDataSet(string procudureName, object[] paraValue, int TimeOut)
        {
            SqlConnection conn = new SqlConnection(ConnectionString); ;
            SqlDataAdapter dataAdapter = null;
            DataSet ds = new DataSet();

            SqlCommand command = new SqlCommand();
            command.CommandTimeout = TimeOut;
            InitSqlCommand(command, procudureName, conn);

            AddParameters(procudureName, command, paraValue);

            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(ds);

            return ds;
        }


        /// <summary>
        /// Hàm thực thi câu lệnh SQL
        /// </summary>
        /// <param name="procudureName">Tên Proc</param>
        /// <param name="paraValue">Mảng chứa giá trị của các biến truyền vào</param>
        public static void ExecuteQuery(string procudureName, object[] paraValue)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand command = new SqlCommand();
            InitSqlCommand(command, procudureName, conn);
            AddParameters(procudureName, command, paraValue);
            command.ExecuteNonQuery();
            conn.Close();
        }
        
        /// <summary>
        /// Hàm thêm mới một dòng trong SQL. Giá trị trả về là ID của dòng mới được thêm vào
        /// </summary>
        /// <param name="procudureName">Tên Proc</param>
        /// <param name="paraValue">Giá trị của các biến truyền vào</param>
        /// <returns>Int</returns>
        public static decimal InsertRow(string procudureName, object[] paraValue)
        {
            return decimal.Parse(GetDataTable(procudureName, paraValue).Rows[0][0].ToString());
        }


        /// <summary>
        /// Bổ sung từ 30/07/2022, phiên bản mới
        /// </summary>

        public static void ExecuteUpdate(string table, string field, object[] paraValue)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "UPDATE " + table + " SET " + field + " = @Value WHERE ID = @Id";
            SqlParameter para = new SqlParameter("@Id", (paraValue[0] == null ? DBNull.Value : paraValue[0]));
            command.Parameters.Add(para);
            SqlParameter para1 = new SqlParameter("@Value", (paraValue[1] == null ? DBNull.Value : paraValue[1]));
            command.Parameters.Add(para1);

            command.ExecuteNonQuery();
            conn.Close();
        }

        public static void ExecuteDelete(string table, decimal Id)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "DELETE " + table + " WHERE ID = @Id";
            SqlParameter para = new SqlParameter("@Id", Id);
            command.Parameters.Add(para);

            command.ExecuteNonQuery();
            conn.Close();
        }


        public static DataTable ExecuteSelect(string table, string field, object[] paraValue)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            if (field != "")
            {
                command.CommandText = "SELECT * FROM " + table + " WHERE TrangThaiId = 1 AND " + field + " = @Value ";
                SqlParameter para = new SqlParameter("@Value", (paraValue[0] == null ? DBNull.Value : paraValue[0]));
                command.Parameters.Add(para);
            }
            else
            {
                command.CommandText = "SELECT * FROM " + table + " WHERE TrangThaiId = 1";

            }
            SqlDataAdapter dataAdapter = null;
            DataTable dt = new DataTable();

            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);

            return dt;

        }

        public static DataTable ExecuteFreeSelect(string query)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = query;

            SqlDataAdapter dataAdapter = null;
            DataTable dt = new DataTable();

            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dt);

            return dt;

        }

        public static decimal ExecuteInsertRow(string Table, object[] paraValue)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;

            // lay ds cac column
            //   DataTable dt = ConnectionSQL.ExecuteFreeSelect("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + Table + "'");
            string query = "INSERT INTO " + Table + "  OUTPUT INSERTED.ID VALUES (";
            for (int i = 0; i < paraValue.Length; i++)
            {
                if (i != paraValue.Length - 1)
                    query = query + "@Para" + i.ToString() + ",";
                else query = query + "@Para" + i.ToString() + ")";
            }

            command.CommandText = query;

            for (int i = 0; i < paraValue.Length; i++)
            {
                SqlParameter para = new SqlParameter("@Para" + i.ToString(), (paraValue[i] == null ? DBNull.Value : paraValue[i]));
                command.Parameters.Add(para);
            }
            conn.Open();

            decimal modified = (decimal)command.ExecuteScalar();

            conn.Close();
            return modified;

        }





    }
}
