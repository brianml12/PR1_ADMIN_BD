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
    public partial class frmProductosInventarioModificar : Form {
        public int IDProducto;
        Producto objProducto;

        public frmProductosInventarioModificar() {
            InitializeComponent();
        }

        public frmProductosInventarioModificar(int id) : this()
        {
            try
            {
                IDProducto = id;
                cmbArea.DataSource = new DAOProductosInventario().obtenerAreas();
                cmbArea.DisplayMember = "NombreArea";
                cmbArea.ValueMember = "idArea";
                objProducto = new DAOProductosInventario().obtenerUno(IDProducto);
                txtNombre.Enfoque(this, new EventArgs());
                txtDescripcion.Enfoque(this, new EventArgs());
                txtSerie.Enfoque(this, new EventArgs());
                txtObservaciones.Enfoque(this, new EventArgs());
                txtColor.Enfoque(this, new EventArgs());
                txtNombre.Texto = objProducto.NombreCorto;
                txtDescripcion.Texto = objProducto.Descripcion;
                txtSerie.Texto = objProducto.Serie;
                dtpFechaAd.Text = objProducto.FechaAdquision;
                cmbArea.SelectedValue = objProducto.AREAS_id;
                txtObservaciones.Texto = objProducto.Observaciones;
                txtColor.Texto = objProducto.Color;
                cmbTipoAdqusicion.Text = objProducto.TipoAdquision;
            }
            catch
            {
            }
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

        private void frmProductosInventarioModificar_Load(object sender, EventArgs e) {
            // BOTON SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // BOTON ATRAS
            btnAtras.MouseHover += new EventHandler(this.activarMano);
            btnAtras.MouseMove += new MouseEventHandler(this.activarMano);
            btnAtras.MouseLeave += new EventHandler(this.desactivarMano);
            // BOTON AGREGAR
            btnGuardar.MouseHover += new EventHandler(this.activarMano);
            btnGuardar.MouseMove += new MouseEventHandler(this.activarMano);
            btnGuardar.MouseLeave += new EventHandler(this.desactivarMano);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (camposVacios())
                {
                    MessageBox.Show("Rellene todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    objProducto.idProducto = IDProducto;
                    objProducto.NombreCorto = txtNombre.Texto;
                    objProducto.Descripcion = txtDescripcion.Texto;
                    objProducto.Serie = txtSerie.Texto;
                    objProducto.Color = txtColor.Texto;
                    objProducto.FechaAdquision = dtpFechaAd.Text;
                    objProducto.TipoAdquision = cmbTipoAdqusicion.SelectedItem.ToString();
                    objProducto.Observaciones = txtObservaciones.Texto;
                    objProducto.AREAS_id = int.Parse(cmbArea.SelectedValue.ToString());
                    objProducto.Descripcion = txtDescripcion.Texto;
                    if (new DAOProductosInventario().modificar(objProducto))
                    {
                        MessageBox.Show("Producto modificado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSalir_Click(this, new EventArgs());
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
