using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosArea
    {
        //Variables
        private int _IdAreas;
        private string _Nombre;
        private int _IdCurso;
        private string _TextoBuscar;

        //Propiedades
        public int IdAreas
        {
            get { return _IdAreas; }
            set { _IdAreas = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructor Vacio
        public DatosArea()
        { 
        
        }

        //Constructor con Parametros
        public DatosArea(int idareas, string nombre, int idcurso, string textobuscar)
        {
            this.IdAreas = idareas;
            this.Nombre = nombre;
            this.IdCurso = idcurso;
            this.TextoBuscar = textobuscar;
        }

        //Metodo Insertar
        public string Insertar(DatosArea Areas)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer Comando
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spinsertar_areas";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdAareas = new SqlParameter();
                ParametroIdAareas.ParameterName = "@idareas";
                ParametroIdAareas.SqlDbType = SqlDbType.Int;
                ParametroIdAareas.Direction = ParameterDirection.Output;
                Command.Parameters.Add(ParametroIdAareas);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 20;
                ParametroNombre.Value =  Areas.Nombre;
                Command.Parameters.Add(ParametroNombre);

                SqlParameter ParametroIdCurso = new SqlParameter();
                ParametroIdCurso.ParameterName = "@idcurso";
                ParametroIdCurso.SqlDbType = SqlDbType.Int;
                ParametroIdCurso.Value = Areas.IdCurso;
                Command.Parameters.Add(ParametroIdCurso);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se insertó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Insertar CapaDatos Areas.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        //Metodo Editar
        public string Editar(DatosArea Areas)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer Comando
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "speditar_areas";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdAareas = new SqlParameter();
                ParametroIdAareas.ParameterName = "@idareas";
                ParametroIdAareas.SqlDbType = SqlDbType.Int;
                ParametroIdAareas.Value = Areas.IdAreas;
                Command.Parameters.Add(ParametroIdAareas);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 20;
                ParametroNombre.Value = Areas.Nombre;
                Command.Parameters.Add(ParametroNombre);

                SqlParameter ParametroIdCurso = new SqlParameter();
                ParametroIdCurso.ParameterName = "@idcurso";
                ParametroIdCurso.SqlDbType = SqlDbType.Int;
                ParametroIdCurso.Value = Areas.IdCurso;
                Command.Parameters.Add(ParametroIdCurso);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Editar CapaDatos Areas.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        //Metodo Eliminar
        public string Eliminar(DatosArea Areas)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //Establecer Comando
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "speliminar_areas";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdAareas = new SqlParameter();
                ParametroIdAareas.ParameterName = "@idareas";
                ParametroIdAareas.SqlDbType = SqlDbType.Int;
                ParametroIdAareas.Value = Areas.IdAreas;
                Command.Parameters.Add(ParametroIdAareas);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : " No se eliminó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Eliminar CapaDatos Areas.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public DataTable Mostrar()
        {
            DataTable DataTableResultado = new DataTable("Areas");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spmostrar_areas";
                Command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SQLAdapter = new SqlDataAdapter(Command);
                SQLAdapter.Fill(DataTableResultado);

            }
            catch (Exception)
            {
                DataTableResultado = null;
            }
            return DataTableResultado;
        }

        public DataTable BuscarNombre(DatosArea Areas)
        {
            DataTable DataTableResultado = new DataTable("Areas");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spbuscarnombre_areas";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroTextoBuscar = new SqlParameter();
                ParametroTextoBuscar.ParameterName = "@textobuscar";
                ParametroTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParametroTextoBuscar.Size = 20;
                ParametroTextoBuscar.Value = Areas.TextoBuscar;
                Command.Parameters.Add(ParametroTextoBuscar);

                SqlDataAdapter SQLAdapter = new SqlDataAdapter(Command);
                SQLAdapter.Fill(DataTableResultado);

            }
            catch (Exception)
            {
                DataTableResultado = null;
            }
            return DataTableResultado;
        }
    }
}
