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
    public partial class frmBuscarDeportista : Form
    {
        public frmBuscarDeportista()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            clsDeportista BuscarDeportista = new clsDeportista();
            BuscarDeportista.Buscar(txtCodigoDeportista.Text);
            if (BuscarDeportista.CodDeportista != txtCodigoDeportista.Text)
            {
                MessageBox.Show("El codigo ingresado no se encuentra en la base de datos.");
            }
            else
            {
                txtNombre.Text = BuscarDeportista.NombreDep;
                txtApellido.Text = BuscarDeportista.ApellidoDep;
                txtDireccion.Text = BuscarDeportista.DireccionDep;
                mskTelefono.Text = Convert.ToString(BuscarDeportista.TelefonoDep);
                mskEdad.Text = Convert.ToString(BuscarDeportista.EdadDep);
                lstDeporte.Text = Convert.ToString(BuscarDeportista.DeportesDep);
                //No se pueden editar las txt
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                mskTelefono.ReadOnly = true;
                mskEdad.ReadOnly = true;
                lstDeporte.Enabled = false;
                //habilito los botones
                cmdEliminar.Enabled = true;
                cmdGuardar.Enabled = true;
                cmdModificar.Enabled = true;

            }

        }
        private void txtCodigoDeportista_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoDeportista.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //Deshabilito los botones que no uso
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = true;
            //Habilito los txt y lst para editar
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            mskTelefono.ReadOnly = false;
            mskEdad.ReadOnly = false;
            lstDeporte.Enabled = true;
        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsDeportista ModificarDeportista = new clsDeportista();
            ModificarDeportista.NombreDep = txtNombre.Text;
            ModificarDeportista.ApellidoDep = txtApellido.Text;
            ModificarDeportista.DireccionDep = txtDireccion.Text;
            ModificarDeportista.TelefonoDep = Convert.ToInt32(mskTelefono.Text);
            ModificarDeportista.EdadDep = Convert.ToInt32(mskEdad.Text);
            ModificarDeportista.DeportesDep = lstDeporte.Text;
            ModificarDeportista.Modificar(CodigoDeportista);
            MessageBox.Show("La informacion ha sido modificada exitosamente.");
            Limpiar();
        }

        private void Limpiar()
        {
            //Limpio los txt y lst
            txtCodigoDeportista.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            mskEdad.Text = "";
            mskTelefono.Text = "";
            lstDeporte.SelectedIndex = -1;
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            //No se editan los txt y lst
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            mskTelefono.ReadOnly = true;
            mskEdad.ReadOnly = true;
            lstDeporte.Enabled = false;
            txtCodigoDeportista.Focus();
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsDeportista EliminarDeportista = new clsDeportista();
            EliminarDeportista.Eliminar(CodigoDeportista);
            MessageBox.Show("Datos borrados con exito");
            Limpiar();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmBuscarDeportista_Load(object sender, EventArgs e)
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
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras");
            }
        }
        private void txtCodigoDeportista_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
