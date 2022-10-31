namespace pryVelezBaseDeDatos
{
    partial class frmBuscarDeportista
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
            this.StatusConexion = new System.Windows.Forms.StatusStrip();
            this.mrcInformacion = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.mskEdad = new System.Windows.Forms.MaskedTextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.mrcInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusConexion
            // 
            this.StatusConexion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusConexion.Location = new System.Drawing.Point(0, 428);
            this.StatusConexion.Name = "StatusConexion";
            this.StatusConexion.Size = new System.Drawing.Size(348, 22);
            this.StatusConexion.TabIndex = 7;
            this.StatusConexion.Text = "statusStrip1";
            // 
            // mrcInformacion
            // 
            this.mrcInformacion.Controls.Add(this.txtDireccion);
            this.mrcInformacion.Controls.Add(this.lblDeporte);
            this.mrcInformacion.Controls.Add(this.txtNombre);
            this.mrcInformacion.Controls.Add(this.lstDeporte);
            this.mrcInformacion.Controls.Add(this.lblEdad);
            this.mrcInformacion.Controls.Add(this.lblNombre);
            this.mrcInformacion.Controls.Add(this.txtApellido);
            this.mrcInformacion.Controls.Add(this.mskTelefono);
            this.mrcInformacion.Controls.Add(this.lblTelefono);
            this.mrcInformacion.Controls.Add(this.lblApellido);
            this.mrcInformacion.Controls.Add(this.lblDireccion);
            this.mrcInformacion.Controls.Add(this.mskEdad);
            this.mrcInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcInformacion.Location = new System.Drawing.Point(12, 92);
            this.mrcInformacion.Name = "mrcInformacion";
            this.mrcInformacion.Size = new System.Drawing.Size(312, 272);
            this.mrcInformacion.TabIndex = 78;
            this.mrcInformacion.TabStop = false;
            this.mrcInformacion.Text = "Informacion Deportista";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(157, 111);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ShortcutsEnabled = false;
            this.txtDireccion.Size = new System.Drawing.Size(132, 27);
            this.txtDireccion.TabIndex = 71;
            // 
            // txtCodigoDeportista
            // 
            this.txtCodigoDeportista.Location = new System.Drawing.Point(192, 22);
            this.txtCodigoDeportista.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoDeportista.MaxLength = 5;
            this.txtCodigoDeportista.Name = "txtCodigoDeportista";
            this.txtCodigoDeportista.ShortcutsEnabled = false;
            this.txtCodigoDeportista.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoDeportista.TabIndex = 68;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(6, 230);
            this.lblDeporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(74, 20);
            this.lblDeporte.TabIndex = 67;
            this.lblDeporte.Text = "Deporte:";
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeportista.Location = new System.Drawing.Point(18, 22);
            this.lblCodigoDeportista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(167, 20);
            this.lblCodigoDeportista.TabIndex = 61;
            this.lblCodigoDeportista.Text = "Codigo Deportista:";
            this.lblCodigoDeportista.Click += new System.EventHandler(this.lblCodigoDeportista_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 39);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(132, 27);
            this.txtNombre.TabIndex = 69;
            // 
            // lstDeporte
            // 
            this.lstDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "RUGBY",
            "ATLETISMO",
            "PADEL",
            "HANDBALL"});
            this.lstDeporte.Location = new System.Drawing.Point(157, 223);
            this.lstDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(132, 28);
            this.lstDeporte.TabIndex = 74;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(6, 191);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(52, 20);
            this.lblEdad.TabIndex = 66;
            this.lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 39);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 62;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(157, 75);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MaxLength = 10;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(132, 27);
            this.txtApellido.TabIndex = 70;
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(157, 146);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefono.Mask = "000000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(132, 27);
            this.mskTelefono.TabIndex = 73;
            this.mskTelefono.ValidatingType = typeof(int);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(6, 153);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 20);
            this.lblTelefono.TabIndex = 65;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 77);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 20);
            this.lblApellido.TabIndex = 63;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(6, 115);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(86, 20);
            this.lblDireccion.TabIndex = 64;
            this.lblDireccion.Text = "Direccion:";
            // 
            // mskEdad
            // 
            this.mskEdad.Location = new System.Drawing.Point(157, 186);
            this.mskEdad.Margin = new System.Windows.Forms.Padding(4);
            this.mskEdad.Mask = "00";
            this.mskEdad.Name = "mskEdad";
            this.mskEdad.Size = new System.Drawing.Size(55, 27);
            this.mskEdad.TabIndex = 72;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(236, 56);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(88, 30);
            this.cmdBuscar.TabIndex = 79;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(12, 370);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(88, 30);
            this.cmdEliminar.TabIndex = 81;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Location = new System.Drawing.Point(236, 370);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(88, 30);
            this.cmdModificar.TabIndex = 80;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // frmBuscarDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.mrcInformacion);
            this.Controls.Add(this.txtCodigoDeportista);
            this.Controls.Add(this.lblCodigoDeportista);
            this.Controls.Add(this.StatusConexion);
            this.Name = "frmBuscarDeportista";
            this.Text = "frmBuscarDeportista";
            this.mrcInformacion.ResumeLayout(false);
            this.mrcInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusConexion;
        private System.Windows.Forms.GroupBox mrcInformacion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.MaskedTextBox mskEdad;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
    }
}