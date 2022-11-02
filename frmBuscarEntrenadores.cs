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
                //No se pueden editar las txt
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtProvincia.ReadOnly = true;
                lstDeporte.Enabled = false;
                //habilito los botones
                cmdEliminar.Enabled = true;
                cmdGuardar.Enabled = true;
                cmdModificar.Enabled = true;
            }
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //Deshabilito los botones que no necesito
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = true;
            //Habilito los txt y lst para editar
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtProvincia.ReadOnly = false;
            lstDeporte.Enabled = true;
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
            //No se pueden editar los txt
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtProvincia.ReadOnly = true;
            lstDeporte.Enabled = false;
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
    }
}
