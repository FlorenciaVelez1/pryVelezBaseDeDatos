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
    public partial class frmBuscarEntrenadores : Form
    {
        public frmBuscarEntrenadores()
        {
            InitializeComponent();
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            clsEntrenador BuscarEntrenador = new clsEntrenador();
            BuscarEntrenador.Buscar(txtCodigoDeportista.Text);
            if (BuscarEntrenador.Codigo != txtCodigoDeportista.Text)
            {
                MessageBox.Show("El codigo ingresado no se encuentra en la base de datos.");
            }
            else
            {
                txtNombre.Text = BuscarEntrenador.Nombre;
                txtApellido.Text = BuscarEntrenador.Apellido;
                txtDireccion.Text = BuscarEntrenador.Direccion;
                txtProvincia.Text = BuscarEntrenador.Provincia;
                lstDeporte.Text = Convert.ToString(BuscarEntrenador.Deporte);
                NoEditarTXT();
                //habilito los botones
                cmdEliminar.Enabled = true;
                cmdGuardar.Enabled = false;
                cmdModificar.Enabled = true;
            }
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //Deshabilito los botones que no necesito
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdBuscar.Enabled = false;
            cmdGuardar.Enabled = true;
            cmdCancelar.Visible = true;
            //Habilito los txt y lst para editar
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtProvincia.ReadOnly = false;
            lstDeporte.Enabled = true;
        }
        private void NoEditarTXT()
        {
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtProvincia.ReadOnly = true;
            lstDeporte.Enabled = false;
        }
        private void Limpiar()
        {
            //Limpio los txt
            txtCodigoDeportista.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            lstDeporte.SelectedIndex = -1;
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            NoEditarTXT();
            txtCodigoDeportista.Focus();
        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsEntrenador ModificarEntrenador = new clsEntrenador();
            ModificarEntrenador.Nombre = txtNombre.Text;
            ModificarEntrenador.Apellido = txtApellido.Text;
            ModificarEntrenador.Direccion = txtDireccion.Text;
            ModificarEntrenador.Provincia = txtProvincia.Text;
            ModificarEntrenador.Deporte = lstDeporte.Text;
            ModificarEntrenador.Modificar(CodigoDeportista);
            MessageBox.Show("La informacion ha sido modificada exitosamente.");
            Limpiar();
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsEntrenador EliminarEntrenador = new clsEntrenador();
            EliminarEntrenador.Eliminar(CodigoDeportista);
            MessageBox.Show("Datos borrados con exito");
            Limpiar();
        }
        private void frmBuscarEntrenadores_Load(object sender, EventArgs e)
        {
            NoEditarTXT();
            txtCodigoDeportista.Focus();
            //Cancelar los cmd
            cmdBuscar.Enabled = false;
            cmdEliminar.Enabled = false;
            cmdGuardar.Enabled = false; 
            cmdModificar.Enabled = false;
            cmdCancelar.Visible = false;
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
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtCodigoDeportista_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoDeportista.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            NoEditarTXT();
            //habilito  o no los botones
            cmdEliminar.Enabled = true;
            cmdModificar.Enabled = true; 
            cmdGuardar.Enabled = false;
            cmdCancelar.Visible = false;
            cmdBuscar.Enabled = true;
        }
        public void Chequeo()
        {
            if (txtCodigoDeportista.Text != "" & txtNombre.Text != "" & txtApellido.Text != "" & txtDireccion.Text != "" & txtProvincia.Text != "")
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
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
    }
}
