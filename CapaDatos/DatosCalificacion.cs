using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosCalificacion
    {
        //Variables
        private int _IdCalificacion;
        private decimal _PrimerPeriodo;
        private decimal _SegundoPeriodo;
        private decimal _TercerPeriodo;
        private decimal _CuartoPeriodo;
        private decimal _CalificacionFinal;
        private int _IdAsignatura;
        private int _IdEstudiante;
        private string _AñoEscolar;
        private string _TextoBuscar;

        //Propiedades

        public int IdCalificacion
        {
          get { return _IdCalificacion; }
          set { _IdCalificacion = value; }
        }

        public decimal PrimerPeriodo
        {
          get { return _PrimerPeriodo; }
          set { _PrimerPeriodo = value; }
        }

        public decimal SegundoPeriodo
        {
          get { return _SegundoPeriodo; }
          set { _SegundoPeriodo = value; }
        }

        public decimal TercerPeriodo
        {
          get { return _TercerPeriodo; }
          set { _TercerPeriodo = value; }
        }

        public decimal CuartoPeriodo
        {
          get { return _CuartoPeriodo; }
          set { _CuartoPeriodo = value; }
        }

        public decimal CalificacionFinal
        {
          get { return _CalificacionFinal; }
          set { _CalificacionFinal = value; }
        }

        public int IdAsignatura
        {
            get { return _IdAsignatura; }
            set { _IdAsignatura = value; }
        }

        public int IdEstudiante
        {
            get { return _IdEstudiante; }
            set { _IdEstudiante = value; }
        }

        public string AñoEscolar
        {
          get { return _AñoEscolar; }
          set { _AñoEscolar = value; }
        }

        public string TextoBuscar
        {
          get { return _TextoBuscar; }
          set { _TextoBuscar = value; }
        }

        //Constructor Vacio
        public DatosCalificacion()
        { 
        
        }

        //Constructor con Parametros
        public DatosCalificacion(int idcalificacion, decimal primerperiodo, decimal segundoperiodo, decimal tercerperiodo, decimal cuartoperiodo, decimal calificacionfinal, string añoescolar, string textobuscar)
        {
            this.IdCalificacion = idcalificacion;
            this.PrimerPeriodo = primerperiodo;
            this.SegundoPeriodo = segundoperiodo;
            this.TercerPeriodo = tercerperiodo;
            this.CuartoPeriodo = cuartoperiodo;
            this.CalificacionFinal = calificacionfinal;
            this.AñoEscolar = añoescolar;
            this.TextoBuscar = textobuscar;
        }

        //Metodo Insertar
        public string Insertar(DatosCalificacion Calificacion)
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
                Command.CommandText = "spinsertar_calificacion";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdCalificacion = new SqlParameter();
                ParametroIdCalificacion.ParameterName = "@idcalificacion";
                ParametroIdCalificacion.SqlDbType = SqlDbType.Int;
                ParametroIdCalificacion.Direction = ParameterDirection.Output;
                Command.Parameters.Add(ParametroIdCalificacion);

                SqlParameter ParametroPrimerPeriodo = new SqlParameter();
                ParametroPrimerPeriodo.ParameterName = "@primerperiodo";
                ParametroPrimerPeriodo.SqlDbType = SqlDbType.Decimal;
                ParametroPrimerPeriodo.Value = Calificacion.PrimerPeriodo;
                Command.Parameters.Add(ParametroPrimerPeriodo);

                SqlParameter ParametroSegundoPeriodo = new SqlParameter();
                ParametroSegundoPeriodo.ParameterName = "@segundoperiodo";
                ParametroSegundoPeriodo.SqlDbType = SqlDbType.Decimal;
                ParametroSegundoPeriodo.Value = Calificacion.SegundoPeriodo;
                Command.Parameters.Add(ParametroSegundoPeriodo);

                SqlParameter ParametroTercerPeriodo = new SqlParameter();
                ParametroTercerPeriodo.ParameterName = "@tercerperiodo";
                ParametroTercerPeriodo.SqlDbType = SqlDbType.Decimal;
                ParametroTercerPeriodo.Value = Calificacion.TercerPeriodo;
                Command.Parameters.Add(ParametroTercerPeriodo);

                SqlParameter ParametroCuartoPeriodo = new SqlParameter();
                ParametroCuartoPeriodo.ParameterName = "@cuartoperiodo";
                ParametroCuartoPeriodo.SqlDbType = SqlDbType.Decimal;
                ParametroCuartoPeriodo.Value = Calificacion.CuartoPeriodo;
                Command.Parameters.Add(ParametroCuartoPeriodo);

                //SqlParameter ParametroCalificacionFinal = new SqlParameter();
                //ParametroCalificacionFinal.ParameterName = "@calificacionfinal";
                //ParametroCalificacionFinal.SqlDbType = SqlDbType.Decimal;
                //ParametroCalificacionFinal.Value = Calificacion.CalificacionFinal;
                //Command.Parameters.Add(ParametroCalificacionFinal);

                SqlParameter ParametroIdAsignatura = new SqlParameter();
                ParametroIdAsignatura.ParameterName = "@idasignatura";
                ParametroIdAsignatura.SqlDbType = SqlDbType.Int;
                ParametroIdAsignatura.Value = Calificacion.IdAsignatura;
                Command.Parameters.Add(ParametroIdAsignatura);

                SqlParameter ParametroIdEstudiante = new SqlParameter();
                ParametroIdEstudiante.ParameterName = "@idestudiante";
                ParametroIdEstudiante.SqlDbType = SqlDbType.Int;
                ParametroIdEstudiante.Value = Calificacion.IdEstudiante;
                Command.Parameters.Add(ParametroIdEstudiante);

                SqlParameter ParametroAñoEscolar = new SqlParameter();
                ParametroAñoEscolar.ParameterName = "@añoescolar";
                ParametroAñoEscolar.SqlDbType = SqlDbType.NVarChar;
                ParametroAñoEscolar.Size = 20;
                ParametroAñoEscolar.Value = Calificacion.AñoEscolar;
                Command.Parameters.Add(ParametroAñoEscolar);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se insertó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Insertar CapaDatos Calificacion.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        //Metodo Editar
        public string Editar(DatosCalificacion Calificacion)
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
                Command.CommandText = "speditar_calificacion";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdCalificacion = new SqlParameter();
                ParametroIdCalificacion.ParameterName = "@idcalificacion";
                ParametroIdCalificacion.SqlDbType = SqlDbType.Int;
                ParametroIdCalificacion.Value = Calificacion.IdCalificacion;
                Command.Parameters.Add(ParametroIdCalificacion);

                SqlParameter ParametroPrimerPeriodo = new SqlParameter();
                ParametroPrimerPeriodo.ParameterName = "@primerperiodo";
                ParametroPrimerPeriodo.SqlDbType = SqlDbType.Decimal;
                ParametroPrimerPeriodo.Value = Calificacion.PrimerPeriodo;
                Command.Parameters.Add(ParametroPrimerPeriodo);

                SqlParameter ParametroSegundoPeriodo = new SqlParameter();
                ParametroSegundoPeriodo.ParameterName = "@segundoperiodo";
                ParametroSegundoPeriodo.SqlDbType = SqlDbType.Decimal;
                ParametroSegundoPeriodo.Value = Calificacion.SegundoPeriodo;
                Command.Parameters.Add(ParametroSegundoPeriodo);

                SqlParameter ParametroTercerPeriodo = new SqlParameter();
                ParametroTercerPeriodo.ParameterName = "@tercerperiodo";
                ParametroTercerPeriodo.SqlDbType = SqlDbType.Decimal;
                ParametroTercerPeriodo.Value = Calificacion.TercerPeriodo;
                Command.Parameters.Add(ParametroTercerPeriodo);

                SqlParameter ParametroCuartoPeriodo = new SqlParameter();
                ParametroCuartoPeriodo.ParameterName = "@cuartoperiodo";
                ParametroCuartoPeriodo.SqlDbType = SqlDbType.Decimal;
                ParametroCuartoPeriodo.Value = Calificacion.CuartoPeriodo;
                Command.Parameters.Add(ParametroCuartoPeriodo);

                //SqlParameter ParametroCalificacionFinal = new SqlParameter();
                //ParametroCalificacionFinal.ParameterName = "@calificacionfinal";
                //ParametroCalificacionFinal.SqlDbType = SqlDbType.Decimal;
                //ParametroCalificacionFinal.Value = Calificacion.CalificacionFinal;
                //Command.Parameters.Add(ParametroCalificacionFinal);

                SqlParameter ParametroIdAsignatura = new SqlParameter();
                ParametroIdAsignatura.ParameterName = "@idasignatura";
                ParametroIdAsignatura.SqlDbType = SqlDbType.Int;
                ParametroIdAsignatura.Value = Calificacion.IdAsignatura;
                Command.Parameters.Add(ParametroIdAsignatura);

                SqlParameter ParametroIdEstudiante = new SqlParameter();
                ParametroIdEstudiante.ParameterName = "@idestudiante";
                ParametroIdEstudiante.SqlDbType = SqlDbType.Int;
                ParametroIdEstudiante.Value = Calificacion.IdEstudiante;
                Command.Parameters.Add(ParametroIdEstudiante);

                SqlParameter ParametroAñoEscolar = new SqlParameter();
                ParametroAñoEscolar.ParameterName = "@añoescolar";
                ParametroAñoEscolar.SqlDbType = SqlDbType.NVarChar;
                ParametroAñoEscolar.Size = 20;
                ParametroAñoEscolar.Value = Calificacion.AñoEscolar;
                Command.Parameters.Add(ParametroAñoEscolar);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Editar CapaDatos Calificacion.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        //Metodo Eliminar
        public string Eliminar(DatosCalificacion Calificacion)
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
                Command.CommandText = "speliminar_calificacion";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdCalificacion = new SqlParameter();
                ParametroIdCalificacion.ParameterName = "@idcalificacion";
                ParametroIdCalificacion.SqlDbType = SqlDbType.Int;
                ParametroIdCalificacion.Value = Calificacion.IdCalificacion;
                Command.Parameters.Add(ParametroIdCalificacion);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : " No se eliminó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Eliminar CapaDatos Calificacion.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public DataTable Mostrar()
        {
            DataTable DataTableResultado = new DataTable("Calificacion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spmostrar_calificacion";
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

        public DataTable BuscarNombre(DatosCalificacion Calificacion)
        {
            DataTable DataTableResultado = new DataTable("Calificacion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spbuscarnombre_calificacion";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroTextoBuscar = new SqlParameter();
                ParametroTextoBuscar.ParameterName = "@textobuscar";
                ParametroTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParametroTextoBuscar.Size = 20;
                ParametroTextoBuscar.Value = Calificacion.TextoBuscar;
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

        public DataTable BuscarNombreEstudiante(DatosCalificacion Calificacion)
        {
            DataTable DataTableResultado = new DataTable("Estudiante");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spbuscarnombrevista_estudiante";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroTextoBuscar = new SqlParameter();
                ParametroTextoBuscar.ParameterName = "@textobuscar";
                ParametroTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParametroTextoBuscar.Size = 20;
                ParametroTextoBuscar.Value = Calificacion.TextoBuscar;
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
