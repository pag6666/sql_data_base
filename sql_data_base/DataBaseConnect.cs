using System.Data;
using System.Data.SqlClient;
namespace sql_data_base
{
    class DataBaseConnect
    {
    SqlConnection conn = new SqlConnection($@"
        Server=DESKTOP-NBDK7UV;
        Initial Catalog =DB;
        Integrated Security = True");
        //server = имя пк
        //Initial Catalog = имя дб
        
        public void OpenConnect() 
        {
            if(conn.State==ConnectionState.Closed)
                conn.Open();
        }
        //
        public void CloseConnect()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public SqlConnection GetConnection() => conn;
    }

}
