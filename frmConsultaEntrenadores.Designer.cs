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
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.grillaConsultaEntrenador = new System.Windows.Forms.DataGridView();
            this.StatusConexion = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.grillaConsultaEntrenador)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(669, 337);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(92, 33);
            this.cmdConsultar.TabIndex = 5;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(549, 337);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(92, 33);
            this.cmdLimpiar.TabIndex = 4;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            // 
            // grillaConsultaEntrenador
            // 
            this.grillaConsultaEntrenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaConsultaEntrenador.Location = new System.Drawing.Point(12, 11);
            this.grillaConsultaEntrenador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaConsultaEntrenador.Name = "grillaConsultaEntrenador";
            this.grillaConsultaEntrenador.RowHeadersVisible = false;
            this.grillaConsultaEntrenador.RowHeadersWidth = 51;
            this.grillaConsultaEntrenador.RowTemplate.Height = 24;
            this.grillaConsultaEntrenador.Size = new System.Drawing.Size(751, 310);
            this.grillaConsultaEntrenador.TabIndex = 3;
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
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.grillaConsultaEntrenador);
            this.Name = "frmConsultaEntrenadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaEntrenadores";
            this.Load += new System.EventHandler(this.frmConsultaEntrenadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaConsultaEntrenador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.DataGridView grillaConsultaEntrenador;
        private System.Windows.Forms.StatusStrip StatusConexion;
    }
}