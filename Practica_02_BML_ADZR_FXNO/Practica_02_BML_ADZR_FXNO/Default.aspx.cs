using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace Practica_02_BML_ADZR_FXNO
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvLibros.DataSource = new DAOLibros().ObtenerTodos();
            gvLibros.DataBind();
        }

        protected void lbtnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmLibrosAgregar.aspx");
        }

        protected void lbtnEliminar_Click(object sender, EventArgs e)
        {
            int rowindex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int id_seleccionado = int.Parse(gvLibros.Rows[rowindex].Cells[0].Text);
            if (new DAOLibros().eliminar(id_seleccionado))
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}