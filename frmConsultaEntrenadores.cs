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
    public partial class frmConsultaEntrenadores : Form
    {
        public frmConsultaEntrenadores()
        {
            InitializeComponent();
        }
        private void frmConsultaEntrenadores_Load(object sender, EventArgs e)
        {
            OleDbConnection Conexion = new OleDbConnection();
            OleDbCommand Comando = new OleDbCommand();
            OleDbDataAdapter Adaptador = new OleDbDataAdapter();
            string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb";
            Conexion = new OleDbConnection(Ruta);
            Conexion.Open();
            //Con esto indico que la base de datos se conecto de manera exitosa
            StatusConexion.BackColor = Color.Green;
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            GrillaEntrenador.DataSource = null;
            GrillaEntrenador.Rows.Clear();
            //Instanciamos
            clsEntrenador  ListarGrilla = new clsEntrenador();
            //Se llama al metodo que se creo en la clase para listar en la grilla
            ListarGrilla.Listar(GrillaEntrenador);
        }
    }
}
