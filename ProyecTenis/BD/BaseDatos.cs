using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecTenis.BD
{
    class BaseDatos
    {
        private static string strCnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Repository\proyecto tennis\ProyecTenis\ProyecTenis\App_Data\BD.mdf;Integrated Security=True";
        private static string usuario = "";
        private static string clave = "";

        public BaseDatos() { }

        public static SqlConnection GetConnection()
        {
            SqlConnection cnn = new SqlConnection(strCnn);

            try
            {
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Horror -> " + ex.ToString());
                return null;
            }
        }
    }
}