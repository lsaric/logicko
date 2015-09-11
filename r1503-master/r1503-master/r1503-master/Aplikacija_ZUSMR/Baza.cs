using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class Baza
    {
        

        private Baza()
        {
            connectionString = @"Data Source=31.147.204.119\\PISERVER,1433;Initial Catalog=1503_DB;Persist Security Info=True;User ID=1503_User;Password=uit87giz";
            //putanja za spajanje na server za bazu
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
       ~Baza()
       {
           try
           {
               connection.Close();
               connection = null;
           }
           catch
           {

           }
       }
        private static Baza instance;
        private string connectionString;
        private SqlConnection connection;

        public static Baza Instance 
        {
            get {
                if (instance==null){
                    instance = new Baza();
                }
                return instance;
            }
        }

        public string ConnectionString{
            get {return connectionString; }
            private set {connectionString = value; }
        }
        public SqlConnection Connection{
            get{return connection; }
            private set {connection = value; }
        }

        public SqlDataReader DohvatiDataReader(string sqlUpit){
            SqlCommand select = new SqlCommand(sqlUpit,Connection);
            return select.ExecuteReader();
        }
        public object VrijednostUpita(string sqlUpit){
            SqlCommand select = new SqlCommand(sqlUpit,Connection);
            return select.ExecuteScalar();
        }

        public int IzvrsavanjeUpita(string sqlUpit){
            SqlCommand select = new SqlCommand(sqlUpit,Connection);
            return select.ExecuteNonQuery();
        }
    }
}

