using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosCursos
    {
        //Variables
        private int _IdCurso;
        private string _Nombre;
        private string _TextoBuscar;

        //Propiedades
        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructor Vacio
        public DatosCursos()
        { 
            
        }

        //Constructor
        public DatosCursos(int idcurso, string nombre, string textobuscar)
        {
            this.IdCurso = idcurso;
            this.Nombre = nombre;
            this.TextoBuscar = textobuscar;
        }

        //Metodo Insertar
        public string Insertar(DatosCursos Cursos)
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
                Command.CommandText = "spinsertar_cursos";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdAareas = new SqlParameter();
                ParametroIdAareas.ParameterName = "@idcurso";
                ParametroIdAareas.SqlDbType = SqlDbType.Int;
                ParametroIdAareas.Direction = ParameterDirection.Output;
                Command.Parameters.Add(ParametroIdAareas);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 20;
                ParametroNombre.Value = Cursos.Nombre;
                Command.Parameters.Add(ParametroNombre);

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

        ///Metodo Editar
        public string Editar(DatosCursos Cursos)
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
                Command.CommandText = "speditar_cursos";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdCursos = new SqlParameter();
                ParametroIdCursos.ParameterName = "@idcurso";
                ParametroIdCursos.SqlDbType = SqlDbType.Int;
                ParametroIdCursos.Value = Cursos.IdCurso;
                Command.Parameters.Add(ParametroIdCursos);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 20;
                ParametroNombre.Value = Cursos.Nombre;
                Command.Parameters.Add(ParametroNombre);

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
        public string Eliminar(DatosCursos Cursos)
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
                Command.CommandText = "speliminar_cursos";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdCursos = new SqlParameter();
                ParametroIdCursos.ParameterName = "@idcurso";
                ParametroIdCursos.SqlDbType = SqlDbType.Int;
                ParametroIdCursos.Value = Cursos.IdCurso;
                Command.Parameters.Add(ParametroIdCursos);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : " No se eliminó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Eliminar CapaDatos Administrativo.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public DataTable Mostrar()
        {
            DataTable DataTableResultado = new DataTable("Cursos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spmostrar_cursos";
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

        public DataTable BuscarNombre(DatosCursos Cursos)
        {
            DataTable DataTableResultado = new DataTable("Cursos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spbuscarnombre_cursos";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroTextoBuscar = new SqlParameter();
                ParametroTextoBuscar.ParameterName = "@textobuscar";
                ParametroTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParametroTextoBuscar.Size = 20;
                ParametroTextoBuscar.Value = Cursos.TextoBuscar;
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
