using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_01_BML_ADZR {
    public partial class frmProductosInventarioAgregar : Form {
        public frmProductosInventarioAgregar() {
            InitializeComponent();
			cmbArea.DataSource = new DAOProductosInventario().obtenerAreas();
			cmbArea.DisplayMember = "NombreArea";
			cmbArea.ValueMember = "idArea";
            cmbTipoAdqusicion.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            frmProductosInventario frm = new frmProductosInventario();
            if (this.Tag.Equals("usuario")) {
                frm.Tag = "usuario";
            }
            frm.Show();
            this.Close();
        }

        public void activarMano(object sender, EventArgs e) {
            Cursor = Cursors.Hand;
        }
        public void desactivarMano(object sender, EventArgs e) {
            Cursor = Cursors.Default;
        }

        private void frmProductosInventarioAgregar_Load(object sender, EventArgs e) {
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
            // BOTON CANCELAR
            btnCancelar.MouseHover += new EventHandler(this.activarMano);
            btnCancelar.MouseMove += new MouseEventHandler(this.activarMano);
            btnCancelar.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnAtras_Click(object sender, EventArgs e) {
            btnSalir_Click(this, new EventArgs());
        }

        public bool camposVacios()
        {
            if (txtNombre.Texto.Equals(txtNombre.PlaceHolder)) return true;
            else if (txtDescripcion.Texto.Equals(txtDescripcion.PlaceHolder)) return true;
            else if (txtSerie.Texto.Equals(txtSerie.PlaceHolder)) return true;
            else if (txtObservaciones.Texto.Equals(txtObservaciones.PlaceHolder)) return true;
            else if (txtColor.Texto.Equals(txtColor.PlaceHolder)) return true;
            else return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (camposVacios())
                {
                    MessageBox.Show("Rellene todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Producto objProducto = new Producto();

                    objProducto.NombreCorto = txtNombre.Texto;
                    objProducto.Descripcion = txtDescripcion.Texto;
                    objProducto.Serie = txtSerie.Texto;
                    objProducto.Color = txtColor.Texto;
                    objProducto.FechaAdquision = dtpFechaAd.Text;
                    objProducto.TipoAdquision = cmbTipoAdqusicion.SelectedItem.ToString();
                    objProducto.Observaciones = txtObservaciones.Texto;
                    objProducto.AREAS_id = int.Parse(cmbArea.SelectedValue.ToString());
                    objProducto.Descripcion = txtDescripcion.Texto;
                    if (new DAOProductosInventario().agregar(objProducto))
                    {
                        MessageBox.Show("Producto registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSalir_Click(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el ingreso de datos. Verifique de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
