using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Modelos;

namespace Practica_02_BML_ADZR_FXNO
{
    public partial class frmLibrosAgregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Libro objLibro = new Libro();
            objLibro.ISBN = txtISBN.Text;
            objLibro.TITULO = txtTitulo.Text;
            objLibro.NUMERO_EDICION = int.Parse(txtNEdicion.Text);
            objLibro.ANO_PUBLICACION = txtAnoPublicacion.Text;
            objLibro.NOMBRE_AUTORES = txtAutor.Text;
            objLibro.PAIS_PUBLICACION = txtPais.Text;
            objLibro.SINOPSIS = txtSinopsis.Text;
            objLibro.CARRERA = txtCarrera.Text;
            objLibro.MATERIA = txtMateria.Text;
            if (new DAOLibros().agregar(objLibro))
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}