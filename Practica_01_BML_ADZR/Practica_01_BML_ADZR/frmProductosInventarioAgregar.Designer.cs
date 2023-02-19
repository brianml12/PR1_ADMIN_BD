namespace Practica_01_BML_ADZR
{
    partial class frmProductosInventarioAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlVentana = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new ControlesPersonalizados.TextBoxPlaceHolder();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.txtSerie = new ControlesPersonalizados.TextBoxPlaceHolder();
            this.txtColor = new ControlesPersonalizados.TextBoxPlaceHolder();
            this.txtDescripcion = new ControlesPersonalizados.TextBoxPlaceHolder();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaAd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservaciones = new ControlesPersonalizados.TextBoxPlaceHolder();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoAdqusicion = new System.Windows.Forms.ComboBox();
            this.pnlVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVentana
            // 
            this.pnlVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.pnlVentana.Controls.Add(this.btnSalir);
            this.pnlVentana.Controls.Add(this.label1);
            this.pnlVentana.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVentana.Location = new System.Drawing.Point(0, 0);
            this.pnlVentana.Name = "pnlVentana";
            this.pnlVentana.Size = new System.Drawing.Size(539, 50);
            this.pnlVentana.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::Practica_01_BML_ADZR.Properties.Resources.x__3_;
            this.btnSalir.Location = new System.Drawing.Point(497, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Productos";
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Practica_01_BML_ADZR.Properties.Resources.arrow_small_left;
            this.btnAtras.Location = new System.Drawing.Point(48, 68);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(32, 32);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(216)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.btnAgregar.Image = global::Practica_01_BML_ADZR.Properties.Resources.mas__1_;
            this.btnAgregar.Location = new System.Drawing.Point(132, 593);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 36);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "  Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCancelar.Image = global::Practica_01_BML_ADZR.Properties.Resources.x__4_;
            this.btnCancelar.Location = new System.Drawing.Point(291, 593);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "  Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(94, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Agregar";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceHolder = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(350, 30);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Texto = "Nombre";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(146, 354);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(350, 26);
            this.cmbArea.TabIndex = 4;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(146, 268);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.PlaceHolder = "Serie";
            this.txtSerie.Size = new System.Drawing.Size(350, 30);
            this.txtSerie.TabIndex = 2;
            this.txtSerie.Texto = "Serie";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(146, 492);
            this.txtColor.Name = "txtColor";
            this.txtColor.PlaceHolder = "Color";
            this.txtColor.Size = new System.Drawing.Size(350, 30);
            this.txtColor.TabIndex = 6;
            this.txtColor.Texto = "Color";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(146, 166);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceHolder = "Descripción";
            this.txtDescripcion.Size = new System.Drawing.Size(350, 91);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Texto = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Serie";
            // 
            // dtpFechaAd
            // 
            this.dtpFechaAd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAd.Location = new System.Drawing.Point(146, 311);
            this.dtpFechaAd.Name = "dtpFechaAd";
            this.dtpFechaAd.Size = new System.Drawing.Size(350, 29);
            this.dtpFechaAd.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Fecha Ad.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Area";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(146, 397);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PlaceHolder = "Observaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(350, 83);
            this.txtObservaciones.TabIndex = 5;
            this.txtObservaciones.Texto = "Observaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Observaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Tipo Adquisicion";
            // 
            // cmbTipoAdqusicion
            // 
            this.cmbTipoAdqusicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAdqusicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAdqusicion.FormattingEnabled = true;
            this.cmbTipoAdqusicion.Items.AddRange(new object[] {
            "Compra",
            "Donacion"});
            this.cmbTipoAdqusicion.Location = new System.Drawing.Point(146, 536);
            this.cmbTipoAdqusicion.Name = "cmbTipoAdqusicion";
            this.cmbTipoAdqusicion.Size = new System.Drawing.Size(350, 26);
            this.cmbTipoAdqusicion.TabIndex = 7;
            // 
            // frmProductosInventarioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 654);
            this.Controls.Add(this.cmbTipoAdqusicion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductosInventarioAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmProductosInventarioAgregar_Load);
            this.pnlVentana.ResumeLayout(false);
            this.pnlVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVentana;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label2;
        private ControlesPersonalizados.TextBoxPlaceHolder txtNombre;
        private System.Windows.Forms.ComboBox cmbArea;
        private ControlesPersonalizados.TextBoxPlaceHolder txtSerie;
        private ControlesPersonalizados.TextBoxPlaceHolder txtColor;
        private ControlesPersonalizados.TextBoxPlaceHolder txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private ControlesPersonalizados.TextBoxPlaceHolder txtObservaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoAdqusicion;
    }
}