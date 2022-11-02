namespace pryVelezBaseDeDatos
{
    partial class frmConsultaEntrenadores
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
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.GrillaEntrenador = new System.Windows.Forms.DataGridView();
            this.StatusConexion = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEntrenador)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(653, 342);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(110, 38);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(507, 342);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(110, 38);
            this.cmdSalir.TabIndex = 2;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // GrillaEntrenador
            // 
            this.GrillaEntrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEntrenador.Location = new System.Drawing.Point(12, 11);
            this.GrillaEntrenador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrillaEntrenador.Name = "GrillaEntrenador";
            this.GrillaEntrenador.ReadOnly = true;
            this.GrillaEntrenador.RowHeadersVisible = false;
            this.GrillaEntrenador.RowHeadersWidth = 51;
            this.GrillaEntrenador.RowTemplate.Height = 24;
            this.GrillaEntrenador.Size = new System.Drawing.Size(751, 310);
            this.GrillaEntrenador.TabIndex = 3;
            // 
            // StatusConexion
            // 
            this.StatusConexion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusConexion.Location = new System.Drawing.Point(0, 396);
            this.StatusConexion.Name = "StatusConexion";
            this.StatusConexion.Size = new System.Drawing.Size(773, 22);
            this.StatusConexion.TabIndex = 6;
            this.StatusConexion.Text = "statusStrip1";
            // 
            // frmConsultaEntrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 418);
            this.Controls.Add(this.StatusConexion);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.GrillaEntrenador);
            this.Name = "frmConsultaEntrenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Entrenadores";
            this.Load += new System.EventHandler(this.frmConsultaEntrenadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEntrenador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridView GrillaEntrenador;
        private System.Windows.Forms.StatusStrip StatusConexion;
    }
}