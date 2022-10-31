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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection Conexion = new OleDbConnection();
                OleDbCommand Comando = new OleDbCommand();
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();
                lblFechaActual.Text = DateTime.Now.ToString();
                string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb";
                Conexion = new OleDbConnection(Ruta);
                Conexion.Open();
                //Con esto indico que la base de datos se conecto de manera exitosa
                lblEstado.Text = "Conectado:" + Conexion.ConnectionString;
                StatusConexion.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Con esto indico que no se pudo conectar con la base de datos
                StatusConexion.BackColor = Color.Red;
            }
        }
        private void deportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroDeportista RegistroDeportista = new frmRegistroDeportista();
            RegistroDeportista.ShowDialog();
        }
        private void entrenadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroEntrenadores RegistroEntrenadores = new frmRegistroEntrenadores();
            RegistroEntrenadores.ShowDialog();
        }
        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDeportista ConsultaDeportista = new frmConsultaDeportista();
            ConsultaDeportista.ShowDialog();
        }
        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenadores ConsultaEntrenadores = new frmConsultaEntrenadores();
            ConsultaEntrenadores.ShowDialog();
        }
        private void deportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarDeportista BuscarDeportista = new frmBuscarDeportista();
            BuscarDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBuscarEntrenadores BuscarEntrenadores = new frmBuscarEntrenadores();
            BuscarEntrenadores.ShowDialog();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
