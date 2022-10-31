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
    internal class clsDeportista
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb";
        private string Tabla = "DEPORTISTA";
        //Declaro de manera local las variables ( los campos el Add Deportista)
        private string CodigoDeportista;
        private string NombreDeportista;
        private string ApellidoDeportista;
        private string DireccionDeportista;
        private Int32 TelefonoDeportista;
        private Int32 EdadDeportista;
        private string Deporte;
        //Propiedades de las variables
        //Get:Retorna lo de las variables
        //Set:Toma el valor y lo almacena
        public string CodDeportista
        {
            get { return CodigoDeportista; }
            set { CodigoDeportista = value; }
        }
        public string NombreDep
        {
            get { return NombreDeportista; }
            set { NombreDeportista = value; }
        }
        public string ApellidoDep
        {
            get { return ApellidoDeportista; }
            set { ApellidoDeportista = value; }
        }
        public string DireccionDep
        {
            get { return DireccionDeportista; }
            set { DireccionDeportista = value; }
        }
        public Int32 TelefonoDep
        {
            get { return TelefonoDeportista; }
            set { TelefonoDeportista = value; }
        }
        public Int32 EdadDep
        {
            get { return EdadDeportista; }
            set { EdadDeportista = value; }
        }
        public string DeportesDep
        {
            get { return Deporte; }
            set { Deporte = value; }
        }
        public void Buscar(string Codigo)
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                //Recibo el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay filas que leer entra en el "si"
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetString(0) == CodDeportista)
                        {
                            CodigoDeportista = Lector.GetString(0);
                            NombreDeportista = Lector.GetString(1);
                            ApellidoDeportista = Lector.GetString(2);
                            DireccionDeportista = Lector.GetString(3);
                            TelefonoDeportista = Lector.GetInt32(4);
                            EdadDeportista = Lector.GetInt32(5);
                            Deporte = Lector.GetString(6);
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado el codigo del deportista");
            }
        }
        public void Agregar()
        {
            try
            {
                string Sql = "INSERT INTO DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    "VALUES ('" + CodigoDeportista + "','" + NombreDep + "','" + ApellidoDep + "','" + DireccionDep + "','" + TelefonoDep + "','" + EdadDep + "','" + Deporte + "')";
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido registrar los datos.");
            }
        }

    }
}
