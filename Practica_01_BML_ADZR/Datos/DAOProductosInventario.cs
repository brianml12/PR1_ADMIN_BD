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
    public class DAOProductosInventario
    {
        public List<Producto> obtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("select i.idProducto, i.NombreCorto, i.Descripcion, i.Serie, i.Color, i.FechaAdquision, i.TipoAdquision, i.Observaciones, a.NombreArea, a.Ubicacion from Inventario i inner join Areas a on a.idArea=i.AREAS_id;");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Producto> lista = new List<Producto>();
                    Producto objProducto = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objProducto = new Producto();
                        objProducto.idProducto = int.Parse(fila["idProducto"].ToString());
                        objProducto.NombreCorto = fila["NombreCorto"].ToString();
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.Serie = fila["Serie"].ToString();
                        objProducto.Color = fila["Color"].ToString();
                        objProducto.FechaAdquision = fila["FechaAdquision"].ToString();
                        objProducto.TipoAdquision = fila["TipoAdquision"].ToString();
                        objProducto.Observaciones = fila["Observaciones"].ToString();
                        objProducto.NombreArea = fila["NombreArea"].ToString();
                        objProducto.Ubicacion = fila["Ubicacion"].ToString();
                        lista.Add(objProducto);
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
                throw new Exception("No se pudo obtener la información de los productos");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool agregar(Producto objProducto)
        {
            try
            {
                if (Conexion.conectar())
                {
                    string query = "INSERT INTO Inventario VALUES(default, @NombreCorto, @Descripcion, @Serie, @Color, @FechaAdquision, @TipoAdquision, @Observaciones, @AREAS_id);";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@NombreCorto", objProducto.NombreCorto);
                    comando.Parameters.AddWithValue("@Descripcion", objProducto.Descripcion);
                    comando.Parameters.AddWithValue("@Serie", objProducto.Serie);
                    comando.Parameters.AddWithValue("@Color", objProducto.Color);
                    comando.Parameters.AddWithValue("@FechaAdquision", objProducto.FechaAdquision);
                    comando.Parameters.AddWithValue("@TipoAdquision", objProducto.TipoAdquision);
                    comando.Parameters.AddWithValue("@Observaciones", objProducto.Observaciones);
                    comando.Parameters.AddWithValue("@AREAS_id", objProducto.AREAS_id);
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

        public List<Area> obtenerAreas()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("select IFNULL(idArea,0) IdArea, IFNULL(NombreArea,'') NombreArea from Areas where Estado='ACTIVO';");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Area> lista = new List<Area>();
                    Area objArea = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objArea = new Area();
                        objArea.idArea = int.Parse(fila["IdArea"].ToString());
                        objArea.NombreArea = fila["NombreArea"].ToString();
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

        public Producto obtenerUno(int ID)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("select i.NombreCorto, i.Descripcion, i.Serie, i.Color, i.FechaAdquision, i.TipoAdquision, i.Observaciones, a.NombreArea, i.AREAS_id from Inventario i inner join Areas a on a.idArea=i.AREAS_id where (idProducto=@IdProducto);");
                    comando.Parameters.AddWithValue("@IdProducto", ID);
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    Producto objProducto = null;
                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objProducto = new Producto();
                        objProducto.NombreCorto = fila["NombreCorto"].ToString();
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.Serie = fila["Serie"].ToString();
                        objProducto.Color = fila["Color"].ToString();
                        objProducto.FechaAdquision = fila["FechaAdquision"].ToString();
                        objProducto.TipoAdquision = fila["TipoAdquision"].ToString();
                        objProducto.Observaciones = fila["Observaciones"].ToString();
                        objProducto.NombreArea = fila["NombreArea"].ToString();
                        objProducto.AREAS_id = int.Parse(fila["AREAS_id"].ToString());
                    }
                    return objProducto;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del producto");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool modificar(Producto objProducto)
        {
            try
            {
                if (Conexion.conectar())
                {
                    string query = @"UPDATE Inventario SET NombreCorto=@nombrecorto, Descripcion=@descripcion, Serie=@serie, Color=@color, FechaAdquision=@fechaAdquision, TipoAdquision=@tipoAdquision, Observaciones=@observaciones, AREAS_id=@areas_id WHERE idProducto=@idProducto;";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@nombreCorto", objProducto.NombreCorto);
                    comando.Parameters.AddWithValue("@descripcion", objProducto.Descripcion);
                    comando.Parameters.AddWithValue("@serie", objProducto.Serie);
                    comando.Parameters.AddWithValue("@color", objProducto.Color);
                    comando.Parameters.AddWithValue("@fechaAdquision", objProducto.FechaAdquision);
                    comando.Parameters.AddWithValue("@tipoAdquision", objProducto.TipoAdquision);
                    comando.Parameters.AddWithValue("@areas_id", objProducto.AREAS_id);
                    comando.Parameters.AddWithValue("@observaciones", objProducto.Observaciones);
                    comando.Parameters.AddWithValue("@idproducto", objProducto.idProducto);
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
                    MySqlCommand comando = new MySqlCommand(@"DELETE FROM Inventario WHERE idProducto=@idproducto;");
                    comando.Parameters.AddWithValue("@idproducto", id);
                    comando.Connection = Conexion.conexion;
                    int filasBorradas = comando.ExecuteNonQuery();
                    return (filasBorradas > 0);
                }
            }
            catch (MySqlException ex)
            {
                
            }
            finally
            {
                Conexion.desconectar();
            }
            return true;
        }

        public List<Producto> buscarTodos(String textobuscar)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("select i.idProducto, i.NombreCorto, i.Descripcion, i.Serie, i.Color, i.FechaAdquision, i.TipoAdquision, i.Observaciones, a.NombreArea, a.Ubicacion from Inventario i inner join Areas a on a.idArea=i.AREAS_id where i.NombreCorto like ('%" + textobuscar + "%');");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Producto> lista = new List<Producto>();
                    Producto objProducto = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objProducto = new Producto();
                        objProducto.idProducto = int.Parse(fila["idProducto"].ToString());
                        objProducto.NombreCorto = fila["NombreCorto"].ToString();
                        objProducto.Descripcion = fila["Descripcion"].ToString();
                        objProducto.Serie = fila["Serie"].ToString();
                        objProducto.Color = fila["Color"].ToString();
                        objProducto.FechaAdquision = fila["FechaAdquision"].ToString();
                        objProducto.TipoAdquision = fila["TipoAdquision"].ToString();
                        objProducto.Observaciones = fila["Observaciones"].ToString();
                        objProducto.NombreArea = fila["NombreArea"].ToString();
                        objProducto.Ubicacion = fila["Ubicacion"].ToString();
                        lista.Add(objProducto);
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
                throw new Exception("No se pudo obtener la información de los productos");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
