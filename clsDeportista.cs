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
        public void Agregar()
        {
            try
            {
                //Instruccion sql, creo variable con la intruccion concatenada y utilizo la variable luego
                string Sql = "INSERT INTO DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    "VALUES ('" + CodDeportista + "','" + NombreDep + "','" + ApellidoDep + "','" + DireccionDep + "','" + TelefonoDep + "','" + EdadDep + "','" + Deporte + "')";
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
        public void ListarGrilla(DataGridView GrillaDeportista)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = Tabla;
            //Adaptador se conecta con la base y trae los datos y se suben los datos a una tabla "virtual"(dataset)
            Adaptador = new OleDbDataAdapter(Comando);
            //Tabla virtual
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            GrillaDeportista.DataSource = DataConsulta.Tables[0];
            Conexion.Close();
        }
        public void Buscar(string CodDeportista)
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                //Recibe el contenido de la tabla
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
                            TelefonoDeportista = int.Parse( Lector.GetString(4));
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
        public void Modificar(string CodDeportista)
        {
            string Sql = "UPDATE DEPORTISTA SET NOMBRE= '" + NombreDep + "', APELLIDO= '" + ApellidoDep + "' , DIRECCION= '" + DireccionDep +"', TELEFONO=" + TelefonoDep +", EDAD=" + EdadDep + ", DEPORTE='" + DeportesDep + "' WHERE [CODIGO DEPORTISTA] = '" + CodDeportista+ "'";
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = Sql;
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
        public void Eliminar(string CodDeportista)
        {
            string Sql = "DELETE FROM DEPORTISTA WHERE ('" + CodDeportista + "'= [CODIGO DEPORTISTA])";
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = Sql;
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
