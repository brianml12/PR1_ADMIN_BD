using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelos;

namespace Practica_01_BML_ADZR {
    public partial class frmProductosInventario : Form {
        public frmProductosInventario() {
            InitializeComponent();
            cargarTabla();
            
        }

        public void cargarTabla()
        {
            dgvProductos.DataSource = new DAOProductosInventario().obtenerTodos();
            dgvProductos.Columns["AREAS_id"].Visible = false;
            dgvProductos.Columns["idProducto"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Close();
        }
        public void activarMano(object sender, EventArgs e) {
            Cursor = Cursors.Hand;
        }
        public void desactivarMano(object sender, EventArgs e) {
            Cursor = Cursors.Default;
        }

        private void frmProductosInventario_Load(object sender, EventArgs e) {
            // BOTON SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // BOTON ATRAS
            btnAtras.MouseHover += new EventHandler(this.activarMano);
            btnAtras.MouseMove += new MouseEventHandler(this.activarMano);
            btnAtras.MouseLeave += new EventHandler(this.desactivarMano);
            // BOTON AGREGAR
            btnAgregar.MouseHover += new EventHandler(this.activarMano);
            btnAgregar.MouseMove += new MouseEventHandler(this.activarMano);
            btnAgregar.MouseLeave += new EventHandler(this.desactivarMano);
            // BOTON MODIFICAR
            btnModificar.MouseHover += new EventHandler(this.activarMano);
            btnModificar.MouseMove += new MouseEventHandler(this.activarMano);
            btnModificar.MouseLeave += new EventHandler(this.desactivarMano);
            // BOTON ELIMINAR
            btnEliminar.MouseHover += new EventHandler(this.activarMano);
            btnEliminar.MouseMove += new MouseEventHandler(this.activarMano);
            btnEliminar.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnAtras_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            frmProductosInventarioAgregar frm = new frmProductosInventarioAgregar();
            if (this.Tag.Equals("usuario")) {
                frm.Tag = "usuario";
            }
            frm.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value.ToString());
                frmProductosInventarioModificar frm = new frmProductosInventarioModificar(idProducto);
                if (this.Tag.Equals("usuario"))
                {
                    frm.Tag = "usuario";
                }
                frm.Show();
                this.Close();
            }
        }
		
		private void btnEliminar_Click(object sender, EventArgs e) {
            if (dgvProductos.SelectedRows.Count == 0) {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult ans = MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(ans == DialogResult.Yes) {
                    if(new DAOProductosInventario().eliminar(idProducto)) {
                        MessageBox.Show("Producto eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarTabla();
                    }
                    else {
                        MessageBox.Show("NO se pudo eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            dgvProductos.DataSource = new DAOProductosInventario().buscarTodos(txtBusqueda.Text);
            dgvProductos.Columns["AREAS_id"].Visible = false;
            dgvProductos.Columns["idProducto"].Visible = false;
        }

    }
}
