namespace pryVelezBaseDeDatos
{
    partial class frmPrincipal
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
            this.StatusConexion = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusConexion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusConexion
            // 
            this.StatusConexion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.lblFechaActual});
            this.StatusConexion.Location = new System.Drawing.Point(0, 424);
            this.StatusConexion.Name = "StatusConexion";
            this.StatusConexion.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.StatusConexion.Size = new System.Drawing.Size(587, 26);
            this.StatusConexion.TabIndex = 1;
            this.StatusConexion.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(15, 20);
            this.lblEstado.Text = "-";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(15, 20);
            this.lblFechaActual.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(587, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrToolStripMenuItem
            // 
            this.registrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistaToolStripMenuItem1,
            this.entrenadorToolStripMenuItem1});
            this.registrToolStripMenuItem.Name = "registrToolStripMenuItem";
            this.registrToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.registrToolStripMenuItem.Text = "Registro";
            // 
            // deportistaToolStripMenuItem1
            // 
            this.deportistaToolStripMenuItem1.Name = "deportistaToolStripMenuItem1";
            this.deportistaToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.deportistaToolStripMenuItem1.Text = "Deportistas";
            this.deportistaToolStripMenuItem1.Click += new System.EventHandler(this.deportistaToolStripMenuItem1_Click);
            // 
            // entrenadorToolStripMenuItem1
            // 
            this.entrenadorToolStripMenuItem1.Name = "entrenadorToolStripMenuItem1";
            this.entrenadorToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.entrenadorToolStripMenuItem1.Text = "Entrenador";
            this.entrenadorToolStripMenuItem1.Click += new System.EventHandler(this.entrenadorToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistaToolStripMenuItem,
            this.entrenadorToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // deportistaToolStripMenuItem
            // 
            this.deportistaToolStripMenuItem.Name = "deportistaToolStripMenuItem";
            this.deportistaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.deportistaToolStripMenuItem.Text = "Deportistas";
            this.deportistaToolStripMenuItem.Click += new System.EventHandler(this.deportistaToolStripMenuItem_Click);
            // 
            // entrenadorToolStripMenuItem
            // 
            this.entrenadorToolStripMenuItem.Name = "entrenadorToolStripMenuItem";
            this.entrenadorToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.entrenadorToolStripMenuItem.Text = "Entrenador";
            this.entrenadorToolStripMenuItem.Click += new System.EventHandler(this.entrenadorToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistasToolStripMenuItem,
            this.entrenadorToolStripMenuItem2});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.modificarToolStripMenuItem.Text = "Buscar";
            // 
            // deportistasToolStripMenuItem
            // 
            this.deportistasToolStripMenuItem.Name = "deportistasToolStripMenuItem";
            this.deportistasToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.deportistasToolStripMenuItem.Text = "Deportistas";
            this.deportistasToolStripMenuItem.Click += new System.EventHandler(this.deportistasToolStripMenuItem_Click);
            // 
            // entrenadorToolStripMenuItem2
            // 
            this.entrenadorToolStripMenuItem2.Name = "entrenadorToolStripMenuItem2";
            this.entrenadorToolStripMenuItem2.Size = new System.Drawing.Size(168, 26);
            this.entrenadorToolStripMenuItem2.Text = "Entrenador";
            this.entrenadorToolStripMenuItem2.Click += new System.EventHandler(this.entrenadorToolStripMenuItem2_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StatusConexion);
            this.Name = "frmPrincipal";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.StatusConexion.ResumeLayout(false);
            this.StatusConexion.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusConexion;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaActual;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

