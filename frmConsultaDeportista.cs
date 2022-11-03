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
    public partial class frmConsultaDeportista : Form
    {
        public frmConsultaDeportista()
        {
            InitializeComponent();
        }
        private void frmConsultaDeportista_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection Conexion = new OleDbConnection();
                OleDbCommand Comando = new OleDbCommand();
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();
                string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb";
                Conexion = new OleDbConnection(Ruta);
                Conexion.Open();
                //Con esto indico que la base de datos se conecto de manera exitosa
                StatuConexion.BackColor = Color.Green;
            }
            catch (Exception)
            {
                //Con esto indico que no se pudo conectar con la base de datos
                StatuConexion.BackColor = Color.Red;
            }
        }
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            GrillaDeportista.DataSource = null;
            GrillaDeportista.Rows.Clear();
            //Instanciamos
            clsDeportista ListarEnGrilla = new clsDeportista();
            //Se llama al metodo que se creo en la clase para listar en la grilla
            ListarEnGrilla.ListarGrilla(GrillaDeportista);
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
