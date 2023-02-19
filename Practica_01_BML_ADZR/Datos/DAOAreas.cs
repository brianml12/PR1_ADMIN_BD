using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAOAreas
    {
        public List<Area> obtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT a.idArea, a.NombreArea, a.Ubicacion, a.Estado FROM Areas a;");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Area> lista = new List<Area>();
                    Area objArea = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objArea = new Area();
                        objArea.idArea = int.Parse(fila["idArea"].ToString());
                        objArea.NombreArea = fila["NombreArea"].ToString();
                        objArea.Ubicacion = fila["Ubicacion"].ToString();
                        objArea.Estado = fila["Estado"].ToString();
                        lista.Add(objArea);
                    }
                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las areas");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool agregar(Area objArea)
        {
            try
            {
                if (Conexion.conectar())
                {
                    string query = "INSERT INTO Areas VALUES(default, @NombreArea, @Ubicacion, @Estado);";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@NombreArea", objArea.NombreArea);
                    comando.Parameters.AddWithValue("@Ubicacion", objArea.Ubicacion);
                    comando.Parameters.AddWithValue("@Estado", objArea.Estado);
                    comando.Connection = Conexion.conexion;
                    comando.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public Area obtenerUno(int ID)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT a.NombreArea, a.Ubicacion, a.Estado FROM Areas a where (idArea=@IdArea);");
                    comando.Parameters.AddWithValue("@IdArea", ID);
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    Area objArea = null;
                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objArea = new Area();
                        objArea.NombreArea = fila["NombreArea"].ToString();
                        objArea.Ubicacion = fila["Ubicacion"].ToString();
                        objArea.Estado = fila["Estado"].ToString();
                        
                    }
                    return objArea;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de la area");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool modificar(Area objArea)
        {
            try
            {
                if (Conexion.conectar())
                {
                    string query = @"UPDATE Areas SET NombreArea=@nombrearea, Ubicacion=@ubicacion, estado=@estado WHERE idArea=@idarea;";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@nombrearea", objArea.NombreArea);
                    comando.Parameters.AddWithValue("@ubicacion", objArea.Ubicacion);
                    comando.Parameters.AddWithValue("@estado", objArea.Estado);
                    comando.Parameters.AddWithValue("@idarea", objArea.idArea);
                    comando.Connection = Conexion.conexion;
                    int filasEditadas = comando.ExecuteNonQuery();
                    return (filasEditadas > 0);
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                Conexion.desconectar();
            }
            return true;
        }

        public bool eliminar(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(@"DELETE FROM Areas WHERE idArea=@idarea;");
                    comando.Parameters.AddWithValue("@idarea", id);
                    comando.Connection = Conexion.conexion;
                    int filasBorradas = comando.ExecuteNonQuery();
                    return (filasBorradas > 0);
                }
            }
            catch (MySqlException ex)
            {
                if (Conexion.conectar())
                {
                    string query = @"UPDATE Areas SET Estado='INACTIVO' WHERE idArea=@idarea;";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@idarea", id);
                    comando.Connection = Conexion.conexion;
                    int filasBorradas = comando.ExecuteNonQuery();
                    return (filasBorradas > 0);
                }
                return false;   
            }
            finally
            {
                Conexion.desconectar();
            }
            return true;
        }

        public List<Area> buscarTodos(String textobuscar)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT a.idArea, a.NombreArea, a.Ubicacion, a.Estado FROM Areas a where a.NombreArea like ('%" + textobuscar + "%');");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Area> lista = new List<Area>();
                    Area objArea = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objArea = new Area();
                        objArea.idArea = int.Parse(fila["idArea"].ToString());
                        objArea.NombreArea = fila["NombreArea"].ToString();
                        objArea.Ubicacion = fila["Ubicacion"].ToString();
                        objArea.Estado = fila["Estado"].ToString();
                        lista.Add(objArea);
                    }
                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de las areas");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
