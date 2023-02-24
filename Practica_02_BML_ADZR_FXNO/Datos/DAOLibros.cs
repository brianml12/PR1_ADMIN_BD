using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos
{
    public class DAOLibros
    {
        public List<Libro> ObtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM books");
                    comando.Connection = Conexion.cnn;
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Libro> lista = new List<Libro>();
                    Libro objLibro = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objLibro = new Libro();
                        objLibro.ID = int.Parse(fila["ID"].ToString());
                        objLibro.ISBN = fila["ISBN"].ToString();
                        objLibro.TITULO = fila["TITULO"].ToString();
                        objLibro.NUMERO_EDICION = int.Parse(fila["NUMERO_EDICION"].ToString());
                        objLibro.ANO_PUBLICACION = fila["ANO_PUBLICACION"].ToString();
                        objLibro.NOMBRE_AUTORES = fila["NOMBRE_AUTORES"].ToString();
                        objLibro.PAIS_PUBLICACION = fila["PAIS_PUBLICACION"].ToString();
                        objLibro.SINOPSIS = fila["SINOPSIS"].ToString();
                        objLibro.CARRERA = fila["CARRERA"].ToString();
                        objLibro.MATERIA = fila["MATERIA"].ToString();
                        lista.Add(objLibro);
                    }
                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo obtener la información de los libros");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool agregar(Libro objLibro)
        {
            try
            {
                if (Conexion.conectar())
                {
                    string query = "INSERT INTO books VALUES (@isbn, @titulo, @edicion, @ano, @autor, @pais, @sinopsis, @carrera, @materia)";
                    SqlCommand comando = new SqlCommand(query);
                    comando.Parameters.AddWithValue("@isbn", objLibro.ISBN);
                    comando.Parameters.AddWithValue("@titulo", objLibro.TITULO);
                    comando.Parameters.AddWithValue("@edicion", objLibro.NUMERO_EDICION);
                    comando.Parameters.AddWithValue("@ano", objLibro.ANO_PUBLICACION);
                    comando.Parameters.AddWithValue("@autor", objLibro.NOMBRE_AUTORES);
                    comando.Parameters.AddWithValue("@pais", objLibro.PAIS_PUBLICACION);
                    comando.Parameters.AddWithValue("@sinopsis", objLibro.SINOPSIS);
                    comando.Parameters.AddWithValue("@carrera", objLibro.CARRERA);
                    comando.Parameters.AddWithValue("@materia", objLibro.MATERIA);
                    comando.Connection = Conexion.cnn;
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

        public bool eliminar(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    SqlCommand comando = new SqlCommand("DELETE FROM books WHERE ID=@idlibro");
                    comando.Parameters.AddWithValue("@idlibro", id);
                    comando.Connection = Conexion.cnn;
                    int filasBorradas = comando.ExecuteNonQuery();
                    return (filasBorradas > 0);
                }
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                Conexion.desconectar();
            }
            return true;
        }

        public Libro obtenerUno(int ID)
        {
            try
            {
                if (Conexion.conectar())
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM books WHERE ID=@idlibro");
                    comando.Parameters.AddWithValue("@idlibro", ID);
                    comando.Connection = Conexion.cnn;
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    Libro objLibro = null;
                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objLibro = new Libro();
                        objLibro.ISBN = fila["ISBN"].ToString();
                        objLibro.TITULO = fila["TITULO"].ToString();
                        objLibro.NUMERO_EDICION = int.Parse(fila["NUMERO_EDICION"].ToString());
                        objLibro.ANO_PUBLICACION = fila["ANO_PUBLICACION"].ToString();
                        objLibro.NOMBRE_AUTORES = fila["NOMBRE_AUTORES"].ToString();
                        objLibro.PAIS_PUBLICACION = fila["PAIS_PUBLICACION"].ToString();
                        objLibro.SINOPSIS = fila["SINOPSIS"].ToString();
                        objLibro.CARRERA = fila["CARRERA"].ToString();
                        objLibro.MATERIA = fila["MATERIA"].ToString();
                    }
                    return objLibro;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo obtener la información del libro");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
