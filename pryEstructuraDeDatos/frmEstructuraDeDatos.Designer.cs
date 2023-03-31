namespace pryEstructuraDeDatos
{
    partial class frmEstructuraDeDatos
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.datosProgramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNoLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.BackgroundImage = global::pryEstructuraDeDatos.Properties.Resources.Fondo_Formulario;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSistema,
            this.tsmLineales,
            this.tsmNoLineales});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSistema
            // 
            this.tsmSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosProgramadorToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.tsmSistema.ForeColor = System.Drawing.Color.White;
            this.tsmSistema.Name = "tsmSistema";
            this.tsmSistema.Size = new System.Drawing.Size(60, 20);
            this.tsmSistema.Text = "Sistema";
            // 
            // datosProgramadorToolStripMenuItem
            // 
            this.datosProgramadorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.datosProgramadorToolStripMenuItem.Name = "datosProgramadorToolStripMenuItem";
            this.datosProgramadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosProgramadorToolStripMenuItem.Text = "Datos Programador";
            this.datosProgramadorToolStripMenuItem.Click += new System.EventHandler(this.datosProgramadorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // tsmLineales
            // 
            this.tsmLineales.ForeColor = System.Drawing.Color.White;
            this.tsmLineales.Name = "tsmLineales";
            this.tsmLineales.Size = new System.Drawing.Size(61, 20);
            this.tsmLineales.Text = "Lineales";
            // 
            // tsmNoLineales
            // 
            this.tsmNoLineales.ForeColor = System.Drawing.Color.White;
            this.tsmNoLineales.Name = "tsmNoLineales";
            this.tsmNoLineales.Size = new System.Drawing.Size(80, 20);
            this.tsmNoLineales.Text = "No Lineales";
            // 
            // frmEstructuraDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.BackgroundImage = global::pryEstructuraDeDatos.Properties.Resources.fondo_formulario_grande;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 467);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstructuraDeDatos";
            this.Text = "Estructura de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSistema;
        private System.Windows.Forms.ToolStripMenuItem datosProgramadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmLineales;
        private System.Windows.Forms.ToolStripMenuItem tsmNoLineales;
    }
}

