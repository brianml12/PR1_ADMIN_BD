using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public static MySqlConnection conexion;
        static string usuario = "sistema_pr1";
        static string password = "123456789";
        static string bd = "LinuxDB";
        static string servidor = "20.220.226.14";
        static string puerto = "3306";

        // Este metodo comprueba si hay conexion a internet
        public static bool conexionInternet()
        {
            bool conexion = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            return true;
        }

        // Este metodo conecta hace la conexion a la base de datos
        public static bool conectar()
        {
            try
            {
                conexion = new MySqlConnection("Database=" + bd + ";Data Source=" + servidor + ";Port=" + puerto + ";User Id=" + usuario + ";Password=" + password);
                conexion.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Este metodo desconecta de la base de datos
        public static void desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
