//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oops
//{
//    class DataBaseConnection
//    {
//        string ConnectionString;
//        SqlConnection connection;

//        public DataBaseConnection(string connstring)
//        {
//            ConnectionString=connstring;
//            connection=new SqlConnection(ConnectionString);
//        }

//        public void OpenConnection()
//        {
//            try
//            {
//                connection.Open();
//                Console.WriteLine("Connection opened successfully.");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Error opening connection: " + e.Message);
//            }

            
//        }

//        public void CloseConnection()
//        {
//            if(connection.State == System.Data.ConnectionState.Open)
//            {
//                connection.Close();
//                Console.WriteLine("Connection closed successfully.");
//            }
//        }
//    }

//    internal class sqlcon
//    {
//        static void Main(string[] args)
//        {
//            string connstring = "Data Source=Luffy\\SQLEXPRESS;Initial Catalog=RegisterForm;'[Integrated Security=True";
//            DataBaseConnection db = new DataBaseConnection(connstring);
//            db.OpenConnection();
//            db.CloseConnection();
//        }
//    }
//}
