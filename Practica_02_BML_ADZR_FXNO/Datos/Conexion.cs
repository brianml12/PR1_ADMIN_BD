using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        public static SqlConnection cnn;

        public static void desconectar()
        {
            try
            {
                cnn.Close();
            }
            catch (Exception)
            {

            }
        }

        public static bool conectar()
        {
            try
            {
                string connetionString = null;
                connetionString = "Data Source=20.118.130.198,1433;Network Library = DBMSSOCN; Initial Catalog = sistema_web;User ID = sa; Password = Root1*";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
