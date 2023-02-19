using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_01_BML_ADZR
{
    public partial class frmMenu : Form {
        public frmMenu() {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e) { 
            DialogResult ans = MessageBox.Show("¿Está seguro que desea cerrar el programa?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ans == DialogResult.OK) {
                this.Close();
                Application.Exit();
            }
        }

        public void activarMano(object sender, EventArgs e) {
            Cursor = Cursors.Hand;
        }

        public void desactivarMano(object sender, EventArgs e) {
            Cursor = Cursors.Default;
        }

        private void frmMenu_Load(object sender, EventArgs e) {
            // BOTON SALIR
            btnSalir.MouseHover += new EventHandler(this.activarMano);
            btnSalir.MouseMove += new MouseEventHandler(this.activarMano);
            btnSalir.MouseLeave += new EventHandler(this.desactivarMano);
            // BOTON CERRAR SESION
            btnCerrarPrograma.MouseHover += new EventHandler(this.activarMano);
            btnCerrarPrograma.MouseMove += new MouseEventHandler(this.activarMano);
            btnCerrarPrograma.MouseLeave += new EventHandler(this.desactivarMano);
            // BOTON PRODUCTOS INVENTARIO
            btnProductosInventario.MouseHover += new EventHandler(this.activarMano);
            btnProductosInventario.MouseMove += new MouseEventHandler(this.activarMano);
            btnProductosInventario.MouseLeave += new EventHandler(this.desactivarMano);
            // BOTON AREAS
            btnAreas.MouseHover += new EventHandler(this.activarMano);
            btnAreas.MouseMove += new MouseEventHandler(this.activarMano);
            btnAreas.MouseLeave += new EventHandler(this.desactivarMano);
        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            btnSalir_Click(this, new EventArgs());
        }

        private void btnProductosInventario_Click(object sender, EventArgs e)
        {
            frmProductosInventario frm = new frmProductosInventario();
            frm.Tag = "usuario";
            frm.Show();
            this.Close();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            frmAreas frm = new frmAreas();
            frm.Tag = "usuario";
            frm.Show();
            this.Close();
        }
    }
}
