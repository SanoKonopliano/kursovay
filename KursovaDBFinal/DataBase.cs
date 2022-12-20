using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace KursovaDBFinal
{
    public class DataBase
    {

        public SqlConnection Connection = new SqlConnection(@"Data Source=THEATREMASTER;Initial Catalog=kursova2;Integrated security=True");

        public void openConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }

        }
        public void closeConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return Connection;
        }

}
}
