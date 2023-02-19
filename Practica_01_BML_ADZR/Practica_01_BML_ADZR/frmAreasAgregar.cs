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
    public partial class frmAreasAgregar : Form {
        public frmAreasAgregar() {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            frmAreas frm = new frmAreas();
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

        private void frmAreasAgregar_Load(object sender, EventArgs e) {
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
            else if (txtUbicacion.Texto.Equals(txtUbicacion.PlaceHolder)) return true;
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
                    Area objArea = new Area();
                    objArea.NombreArea = txtNombre.Texto;
                    objArea.Ubicacion = txtUbicacion.Texto;
                    objArea.Estado = cmbEstado.SelectedItem.ToString();
                    if (new DAOAreas().agregar(objArea))
                    {
                        MessageBox.Show("Area registrada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSalir_Click(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo agregar la area", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
