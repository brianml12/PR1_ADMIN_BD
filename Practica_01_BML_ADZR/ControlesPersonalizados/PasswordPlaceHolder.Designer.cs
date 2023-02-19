namespace ControlesPersonalizados
{
    partial class PasswordPlaceHolder
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCaja
            // 
            this.txtCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCaja.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.ForeColor = System.Drawing.Color.Black;
            this.txtCaja.Location = new System.Drawing.Point(0, 0);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(180, 29);
            this.txtCaja.TabIndex = 2;
            this.txtCaja.UseSystemPasswordChar = true;
            this.txtCaja.TextChanged += new System.EventHandler(this.txtCaja_TextChanged);
            // 
            // PasswordPlaceHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCaja);
            this.Name = "PasswordPlaceHolder";
            this.Size = new System.Drawing.Size(180, 30);
            this.Load += new System.EventHandler(this.TextBoxPlaceHolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaja;
    }
}
