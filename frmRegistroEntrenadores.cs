using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace pryVelezBaseDeDatos
{
    public partial class frmRegistroEntrenadores : Form
    {
        public frmRegistroEntrenadores()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpiar()
        {
            txtCodigoDeportista.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            lstDeporte.SelectedIndex = -1;
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
           Limpiar();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            //Llamo la clase para tomar los codigos 
            clsEntrenador Registro = new clsEntrenador();
            Registro.Codigo = txtCodigoDeportista.Text;
            Registro.Nombre = txtNombre.Text;
            Registro.Apellido = txtApellido.Text;
            Registro.Direccion = txtDireccion.Text;
            Registro.Provincia = txtProvincia.Text;
            Registro.Deporte = Convert.ToString(lstDeporte.SelectedItem);
            //Llamo al procedimiento creado en la clase para agregar el dato nuevo
            Registro.Agregar();
            MessageBox.Show("Se ha registrado correctamente el nuevo Entrenador");
            Limpiar();
            txtCodigoDeportista.Focus();
        }
        private void frmRegistroEntrenadores_Load(object sender, EventArgs e)
        {
            txtCodigoDeportista.Focus();
            try
            {
                OleDbConnection Conexion = new OleDbConnection();
                OleDbCommand Comando = new OleDbCommand();
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();
                string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb";
                Conexion = new OleDbConnection(Ruta);
                Conexion.Open();
                StatusConexion.BackColor = Color.Green;
            }
            catch (Exception)
            {
                StatusConexion.BackColor = Color.Red;
            }
            cmdRegistrar.Enabled = false;
        }
        private void txtCodigoDeportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras");
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras");
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras");
            }
        }
        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras");
            }
        }
        public void Chequeo()
        {
            if (txtCodigoDeportista.Text != "" & txtNombre.Text != "" & txtApellido.Text != "" & txtDireccion.Text != "" & txtProvincia.Text != "" & lstDeporte.SelectedIndex >= 0)
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
                cmdRegistrar.Enabled = false;    
            }
        }
        private void txtCodigoDeportista_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
    }

}
