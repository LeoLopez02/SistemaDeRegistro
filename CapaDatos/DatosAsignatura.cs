using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosAsignatura
    {
        //Variables
        private int _IdAsignatura;
        private string _Nombre;
        private string _Descripcion;
        private int _CantidadHoras;
        private int _IdProfesor;
        private int _IdCurso;
        private string _TextoBuscar;

        //Propiedades

        public int IdAsignatura
        {
            get { return _IdAsignatura; }
            set { _IdAsignatura = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public int CantidadHoras
        {
            get { return _CantidadHoras; }
            set { _CantidadHoras = value; }
        }

        public int IdProfesor
        {
            get { return _IdProfesor; }
            set { _IdProfesor = value; }
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
        public DatosAsignatura()
        { 
            
        }

        //Constructor con Parametros
        public DatosAsignatura(int idasignatura, string nombre, string descripcion, int cantidadhoras, int idprofesor, int idcurso, string textobuscar)
        {
            this.IdAsignatura = idasignatura;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.CantidadHoras = cantidadhoras;
            this.IdProfesor = idprofesor;
            this.IdCurso = idcurso;
            this.TextoBuscar = textobuscar;
        }

        //Metodo Insertar
        public string Insertar(DatosAsignatura Asignatura)
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
                Command.CommandText = "spinsertar_asignatura";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdAsignatura = new SqlParameter();
                ParametroIdAsignatura.ParameterName = "@idasignatura";
                ParametroIdAsignatura.SqlDbType = SqlDbType.Int;
                ParametroIdAsignatura.Direction = ParameterDirection.Output;
                Command.Parameters.Add(ParametroIdAsignatura);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 50;
                ParametroNombre.Value = Asignatura.Nombre;
                Command.Parameters.Add(ParametroNombre);

                SqlParameter ParametroDescripcion = new SqlParameter();
                ParametroDescripcion.ParameterName = "@descripcion";
                ParametroDescripcion.SqlDbType = SqlDbType.NVarChar;
                ParametroDescripcion.Size = 100;
                ParametroDescripcion.Value = Asignatura.Descripcion;
                Command.Parameters.Add(ParametroDescripcion);

                SqlParameter ParametroCantidadHoras = new SqlParameter();
                ParametroCantidadHoras.ParameterName = "@cantidadhoras";
                ParametroCantidadHoras.SqlDbType = SqlDbType.Int;
                ParametroCantidadHoras.Value = Asignatura.CantidadHoras;
                Command.Parameters.Add(ParametroCantidadHoras);

                SqlParameter ParametroIdProfesor = new SqlParameter();
                ParametroIdProfesor.ParameterName = "@idprofesor";
                ParametroIdProfesor.SqlDbType = SqlDbType.Int;
                ParametroIdProfesor.Value = Asignatura.IdCurso;
                Command.Parameters.Add(ParametroIdProfesor);

                SqlParameter ParametroIdCurso = new SqlParameter();
                ParametroIdCurso.ParameterName = "@idcurso";
                ParametroIdCurso.SqlDbType = SqlDbType.Int;
                ParametroIdCurso.Value = Asignatura.IdCurso;
                Command.Parameters.Add(ParametroIdCurso);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se insertó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Insertar CapaDatos Asignatura.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        //Metodo Editar
        public string Editar(DatosAsignatura Asignatura)
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
                Command.CommandText = "speditar_asignatura";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                //Parametros
                SqlParameter ParametroIdAsignatura = new SqlParameter();
                ParametroIdAsignatura.ParameterName = "@idasignatura";
                ParametroIdAsignatura.SqlDbType = SqlDbType.Int;
                ParametroIdAsignatura.Value = Asignatura.IdAsignatura;
                Command.Parameters.Add(ParametroIdAsignatura);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 50;
                ParametroNombre.Value = Asignatura.Nombre;
                Command.Parameters.Add(ParametroNombre);

                SqlParameter ParametroDescripcion = new SqlParameter();
                ParametroDescripcion.ParameterName = "@descripcion";
                ParametroDescripcion.SqlDbType = SqlDbType.NVarChar;
                ParametroDescripcion.Size = 100;
                ParametroDescripcion.Value = Asignatura.Descripcion;
                Command.Parameters.Add(ParametroDescripcion);

                SqlParameter ParametroCantidadHoras = new SqlParameter();
                ParametroCantidadHoras.ParameterName = "@cantidadhoras";
                ParametroCantidadHoras.SqlDbType = SqlDbType.Int;
                ParametroCantidadHoras.Value = Asignatura.CantidadHoras;
                Command.Parameters.Add(ParametroCantidadHoras);

                SqlParameter ParametroIdProfesor = new SqlParameter();
                ParametroIdProfesor.ParameterName = "@idprofesor";
                ParametroIdProfesor.SqlDbType = SqlDbType.Int;
                ParametroIdProfesor.Value = Asignatura.IdCurso;
                Command.Parameters.Add(ParametroIdProfesor);

                SqlParameter ParametroIdCurso = new SqlParameter();
                ParametroIdCurso.ParameterName = "@idcurso";
                ParametroIdCurso.SqlDbType = SqlDbType.Int;
                ParametroIdCurso.Value = Asignatura.IdCurso;
                Command.Parameters.Add(ParametroIdCurso);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Editar CapaDatos Asignatura.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) 
                    SqlCon.Close();
            }
            return Respuesta;
        }

        //Metodo Eliminar
        public string Eliminar(DatosAsignatura Asignatura)
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
                Command.CommandText = "speliminar_asignatura";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdAsignatura = new SqlParameter();
                ParametroIdAsignatura.ParameterName = "@idasignatura";
                ParametroIdAsignatura.SqlDbType = SqlDbType.Int;
                ParametroIdAsignatura.Value = Asignatura.IdAsignatura;
                Command.Parameters.Add(ParametroIdAsignatura);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : " No se eliminó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Eliminar CapaDatos Asignatura.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) 
                    SqlCon.Close();
            }
            return Respuesta;
        }

        public DataTable Mostrar()
        {
            DataTable DataTableResultado = new DataTable("Asignatura");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spmostrar_asignatura";
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

        public DataTable BuscarNombre(DatosAsignatura Asignatura)
        {
            DataTable DataTableResultado = new DataTable("Asignatura");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spbuscarnombre_asignatura";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroTextoBuscar = new SqlParameter();
                ParametroTextoBuscar.ParameterName = "@textobuscar";
                ParametroTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParametroTextoBuscar.Size = 20;
                ParametroTextoBuscar.Value = Asignatura.TextoBuscar;
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
