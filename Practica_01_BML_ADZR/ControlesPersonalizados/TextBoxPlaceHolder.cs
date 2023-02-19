using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados {
    public partial class TextBoxPlaceHolder : UserControl {

        public TextBoxPlaceHolder() {
            InitializeComponent();
            txtCaja.ForeColor = Color.LightGray;
        }

        public string Texto {
            get { return txtCaja.Text;  }
            set { txtCaja.Text = value; }
        }

        string placeholder;
        public string PlaceHolder {
            get { return placeholder; }
            set { placeholder = value; }
        }

        private void TextBoxPlaceHolder_Load(object sender, EventArgs e) {
            txtCaja.GotFocus += new EventHandler(this.Enfoque);
            txtCaja.LostFocus += new EventHandler(this.Desenfoque);
            Desenfoque(this, new EventArgs());
        }

        public void Enfoque(object sender, EventArgs e) { 
            if(txtCaja.Text == placeholder) {
                txtCaja.Text = "";
                txtCaja.ForeColor = Color.Black;
            }
        }

        public void Desenfoque(object sender, EventArgs e) { 
            if(txtCaja.Text == "") {
                txtCaja.Text = placeholder;
                txtCaja.ForeColor = Color.LightGray;
            }
        }
    }
}
