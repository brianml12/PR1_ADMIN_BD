namespace Practica_01_BML_ADZR
{
    partial class frmAreas
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
            this.dgvAreas = new System.Windows.Forms.DataGridView();
            this.idArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
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
            this.pnlVentana.Size = new System.Drawing.Size(790, 50);
            this.pnlVentana.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::Practica_01_BML_ADZR.Properties.Resources.x__3_;
            this.btnSalir.Location = new System.Drawing.Point(748, 8);
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
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Areas";
            // 
            // dgvAreas
            // 
            this.dgvAreas.AllowUserToAddRows = false;
            this.dgvAreas.AllowUserToDeleteRows = false;
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArea,
            this.NombreArea,
            this.Ubicacion,
            this.Estado});
            this.dgvAreas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAreas.Location = new System.Drawing.Point(48, 150);
            this.dgvAreas.Name = "dgvAreas";
            this.dgvAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAreas.Size = new System.Drawing.Size(704, 194);
            this.dgvAreas.TabIndex = 2;
            // 
            // idArea
            // 
            this.idArea.DataPropertyName = "idArea";
            this.idArea.HeaderText = "ID Area";
            this.idArea.Name = "idArea";
            this.idArea.ReadOnly = true;
            // 
            // NombreArea
            // 
            this.NombreArea.DataPropertyName = "NombreArea";
            this.NombreArea.HeaderText = "Nombre Area";
            this.NombreArea.Name = "NombreArea";
            this.NombreArea.ReadOnly = true;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Width = 250;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Practica_01_BML_ADZR.Properties.Resources.arrow_small_left;
            this.btnAtras.Location = new System.Drawing.Point(48, 78);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(32, 32);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(152)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(147)))), ((int)(((byte)(23)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(147)))), ((int)(((byte)(23)))));
            this.btnModificar.Image = global::Practica_01_BML_ADZR.Properties.Resources.edit;
            this.btnModificar.Location = new System.Drawing.Point(336, 378);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 36);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "  Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(216)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(152)))), ((int)(((byte)(114)))));
            this.btnAgregar.Image = global::Practica_01_BML_ADZR.Properties.Resources.mas__1_;
            this.btnAgregar.Location = new System.Drawing.Point(162, 378);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 36);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "  Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnEliminar.Image = global::Practica_01_BML_ADZR.Properties.Resources.x__4_;
            this.btnEliminar.Location = new System.Drawing.Point(510, 378);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "  Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(86, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Buscar";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(162, 82);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(533, 29);
            this.txtBusqueda.TabIndex = 28;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::Practica_01_BML_ADZR.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(701, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 475);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvAreas);
            this.Controls.Add(this.pnlVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmAreas_Load);
            this.pnlVentana.ResumeLayout(false);
            this.pnlVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVentana;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAreas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
    }
}