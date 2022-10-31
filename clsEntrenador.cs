using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agrego los elementos que vamos a usar
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace pryVelezBaseDeDatos
{
    internal class clsEntrenador
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb";
        private string Tabla = "ENTRENADORES";
        //Declaro de manera local las variables ( los campos el Add Entrenadores)
        private string CodigoEntrenadores;
        private string NombreEntrenadores;
        private string ApellidoEntrenadores;
        private string DireccionEntrenadores;
        private string ProvinciaEntrenadores;
        private string Deporte;
    }
}
