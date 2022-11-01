namespace pryVelezBaseDeDatos
{
    partial class frmConsultaDeportista
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
            this.GrillaDeportista = new System.Windows.Forms.DataGridView();
            this.StatuConexion = new System.Windows.Forms.StatusStrip();
            this.cmdSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDeportista)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(791, 338);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(92, 33);
            this.cmdConsultar.TabIndex = 8;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // GrillaDeportista
            // 
            this.GrillaDeportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDeportista.Location = new System.Drawing.Point(12, 12);
            this.GrillaDeportista.Name = "GrillaDeportista";
            this.GrillaDeportista.RowHeadersVisible = false;
            this.GrillaDeportista.RowHeadersWidth = 51;
            this.GrillaDeportista.RowTemplate.Height = 24;
            this.GrillaDeportista.Size = new System.Drawing.Size(871, 310);
            this.GrillaDeportista.TabIndex = 6;
            // 
            // StatuConexion
            // 
            this.StatuConexion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatuConexion.Location = new System.Drawing.Point(0, 393);
            this.StatuConexion.Name = "StatuConexion";
            this.StatuConexion.Size = new System.Drawing.Size(896, 22);
            this.StatuConexion.TabIndex = 9;
            this.StatuConexion.Text = "statusStrip1";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(657, 338);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(92, 33);
            this.cmdSalir.TabIndex = 10;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmConsultaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 415);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.StatuConexion);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.GrillaDeportista);
            this.Name = "frmConsultaDeportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Deportista";
            this.Load += new System.EventHandler(this.frmConsultaDeportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDeportista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridView GrillaDeportista;
        private System.Windows.Forms.StatusStrip StatuConexion;
        private System.Windows.Forms.Button cmdSalir;
    }
}