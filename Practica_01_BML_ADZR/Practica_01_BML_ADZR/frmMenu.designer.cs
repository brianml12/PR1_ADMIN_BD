namespace Practica_01_BML_ADZR
{
    partial class frmMenu
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
            this.lblInventario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.btnAreas = new System.Windows.Forms.Button();
            this.btnProductosInventario = new System.Windows.Forms.Button();
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
            this.pnlVentana.Size = new System.Drawing.Size(364, 50);
            this.pnlVentana.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::Practica_01_BML_ADZR.Properties.Resources.x__3_;
            this.btnSalir.Location = new System.Drawing.Point(324, 13);
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
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al sistema";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInventario.Location = new System.Drawing.Point(29, 180);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(128, 50);
            this.lblInventario.TabIndex = 8;
            this.lblInventario.Text = "Productos del\r\n   inventario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(253, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Areas";
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnCerrarPrograma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPrograma.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPrograma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnCerrarPrograma.Image = global::Practica_01_BML_ADZR.Properties.Resources.x__4_;
            this.btnCerrarPrograma.Location = new System.Drawing.Point(95, 264);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(170, 36);
            this.btnCerrarPrograma.TabIndex = 6;
            this.btnCerrarPrograma.Text = "  Cerrar Programa";
            this.btnCerrarPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarPrograma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarPrograma.UseVisualStyleBackColor = false;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.FlatAppearance.BorderSize = 0;
            this.btnAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreas.Image = global::Practica_01_BML_ADZR.Properties.Resources.cajas;
            this.btnAreas.Location = new System.Drawing.Point(247, 102);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(64, 64);
            this.btnAreas.TabIndex = 4;
            this.btnAreas.UseVisualStyleBackColor = true;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // btnProductosInventario
            // 
            this.btnProductosInventario.FlatAppearance.BorderSize = 0;
            this.btnProductosInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosInventario.Image = global::Practica_01_BML_ADZR.Properties.Resources.cajas;
            this.btnProductosInventario.Location = new System.Drawing.Point(62, 102);
            this.btnProductosInventario.Name = "btnProductosInventario";
            this.btnProductosInventario.Size = new System.Drawing.Size(64, 64);
            this.btnProductosInventario.TabIndex = 0;
            this.btnProductosInventario.UseVisualStyleBackColor = true;
            this.btnProductosInventario.Click += new System.EventHandler(this.btnProductosInventario_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 332);
            this.Controls.Add(this.btnCerrarPrograma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.btnAreas);
            this.Controls.Add(this.btnProductosInventario);
            this.Controls.Add(this.pnlVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuAdmin";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlVentana.ResumeLayout(false);
            this.pnlVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVentana;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductosInventario;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrarPrograma;
    }
}