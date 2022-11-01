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
        private string CodigoDeportista;
        private string NombreEntrenador;
        private string ApellidoEntrenador;
        private string DireccionEntrenador;
        private string ProvinciaEntrenador;
        private string DeporteEntrenador;
        //Propiedades de las variables (nombre de los campos de la base)
        public string Codigo
        {
            get { return CodigoDeportista; }
            set { CodigoDeportista = value; }
        }
        public string Nombre
        {
            get { return NombreEntrenador; }
            set { NombreEntrenador = value; }
        }
        public string Apellido
        {
            get { return ApellidoEntrenador; }
            set { ApellidoEntrenador = value; }
        }
        public string Direccion
        {
            get { return DireccionEntrenador; }
            set { DireccionEntrenador = value; }
        }
        public string Provincia
        {
            get { return ProvinciaEntrenador; }
            set { ProvinciaEntrenador = value; }
        }
        public string Deporte
        {
            get { return DeporteEntrenador; }
            set { DeporteEntrenador = value; }
        }
        public void Agregar()
        {
            try
            {
                //Instruccion sql, creo variable con la intruccion concatenada y utilizo la variable luego
                string Sql = "INSERT INTO ENTRENADORES ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                    "VALUES ('" + Codigo + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Provincia + "','" + Deporte + "')";
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
                MessageBox.Show("No se han podido registrar los datos.");
            }
        }
        public void Listar(DataGridView GrillaEntrenador)
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
            GrillaEntrenador.DataSource = DataConsulta.Tables[0];
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
                            NombreEntrenador = Lector.GetString(1);
                            ApellidoEntrenador = Lector.GetString(2);
                            DireccionEntrenador = Lector.GetString(3);
                            ProvinciaEntrenador =Lector.GetString(4);
                            Deporte = Lector.GetString(5);
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha encontrado el codigo ingresado.");
            }
        }
        public void Modificar(string Codigo)
        {
            string Sql = "UPDATE ENTRENADORES SET DIRECCION= '" + Direccion + "', DEPORTE='" + Deporte + "' WHERE [CODIGO DEPORTISTA] = '" + Codigo + "'";
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = Sql;
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
        public void Eliminar(string Codigo)
        {
            string Sql = "DELETE FROM ENTRENADORES WHERE ('" + Codigo + "'= [CODIGO DEPORTISTA])";
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
