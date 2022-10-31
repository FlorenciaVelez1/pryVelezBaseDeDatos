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
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.grillaConsultaDeportistas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatuConexion = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.grillaConsultaDeportistas)).BeginInit();
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
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(673, 338);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(92, 33);
            this.cmdLimpiar.TabIndex = 7;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            // 
            // grillaConsultaDeportistas
            // 
            this.grillaConsultaDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaConsultaDeportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grillaConsultaDeportistas.Location = new System.Drawing.Point(12, 12);
            this.grillaConsultaDeportistas.Name = "grillaConsultaDeportistas";
            this.grillaConsultaDeportistas.RowHeadersVisible = false;
            this.grillaConsultaDeportistas.RowHeadersWidth = 51;
            this.grillaConsultaDeportistas.RowTemplate.Height = 24;
            this.grillaConsultaDeportistas.Size = new System.Drawing.Size(871, 310);
            this.grillaConsultaDeportistas.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código Deportista";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dirección";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Teléfono";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Edad";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Deporte";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
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
            // frmConsultaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 415);
            this.Controls.Add(this.StatuConexion);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.grillaConsultaDeportistas);
            this.Name = "frmConsultaDeportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Deportista";
            this.Load += new System.EventHandler(this.frmConsultaDeportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaConsultaDeportistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.DataGridView grillaConsultaDeportistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.StatusStrip StatuConexion;
    }
}