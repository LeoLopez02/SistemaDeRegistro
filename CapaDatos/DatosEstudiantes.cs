using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosEstudiantes
    {
        //Variables
        private int _IdEstudiante;
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Direccion;
        private string _Cedula;
        private string _Genero;
        private string _Condicion_Medica;
        private DateTime _Fecha_Nacimiento;  
        private DateTime _Fecha_Ingreso;
        private string _Correo_Electronico;
        private string _Nacionalidad;
        private string _Estatus;
        private string _AñoEscolar;
        private int _IdCurso;
        private int _IdAreas;
        private int _IdAsignatura;
        private int _IdProfesor;
        private string _TextoBuscar;
        
        //Propiedades
        public int IdEstudiante
        {
            get { return _IdEstudiante; }
            set { _IdEstudiante = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

                public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string Cedula
        {
            get { return _Cedula; }
            set { _Cedula = value; }
        }

        public string Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }

        public string Condicion_Medica
        {
            get { return _Condicion_Medica; }
            set { _Condicion_Medica = value; }
        }

        public DateTime Fecha_Nacimiento
        {
            get { return _Fecha_Nacimiento; }
            set { _Fecha_Nacimiento = value; }
        }

        public DateTime Fecha_Ingreso
        {
            get { return _Fecha_Ingreso; }
            set { _Fecha_Ingreso = value; }
        }

        public string Correo_Electronico
        {
            get { return _Correo_Electronico; }
            set { _Correo_Electronico = value; }
        }

        public string Nacionalidad
        {
            get { return _Nacionalidad; }
            set { _Nacionalidad = value; }
        }

        public string Estatus
        {
            get { return _Estatus; }
            set { _Estatus = value; }
        }

        public string AñoEscolar
        {
            get { return _AñoEscolar; }
            set { _AñoEscolar = value; }
        }

        public int IdCurso
        {
          get { return _IdCurso; }
          set { _IdCurso = value; }
        }

        public int IdAreas
        {
          get { return _IdAreas; }
          set { _IdAreas = value; }
        }

        public int IdAsignatura
        {
          get { return _IdAsignatura; }
          set { _IdAsignatura = value; }
        }

        public int IdProfesor
        {
          get { return _IdProfesor; }
          set { _IdProfesor = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }


        //Constructor vacio
        public DatosEstudiantes()
        { 
        
        }
        //Constructor
        public DatosEstudiantes(int idestudiante, string nombre, string apellido, string telefono, string direccion, string cedula, string genero, string condicionmedica, DateTime fechanacimiento, DateTime fechaingreso, string correo, string nacionalidad, string estatus, string añoescolar, int idcurso, int idareas, int idasignatura, int idprofesor, string textobuscar)
        {
            this.IdEstudiante = idestudiante;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Cedula = cedula;
            this.Genero = genero;
            this.Condicion_Medica = condicionmedica;
            this.Fecha_Nacimiento = fechanacimiento;
            this.Fecha_Ingreso = fechaingreso;
            this.Correo_Electronico = correo;
            this.Nacionalidad = nacionalidad;
            this.Estatus = estatus;
            this.AñoEscolar = añoescolar;
            this.IdCurso = idcurso;
            this.IdAreas = idareas;
            this.IdAsignatura = idasignatura;
            this.IdProfesor = idprofesor;
            this.TextoBuscar = textobuscar;
        }

        //Metodo Insertar
        public string Insertar(DatosEstudiantes Estudiante)
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
                Command.CommandText = "spinsertar_estudiante";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdEstudiante = new SqlParameter();
                ParametroIdEstudiante.ParameterName = "@idestudiante";
                ParametroIdEstudiante.SqlDbType = SqlDbType.Int;
                ParametroIdEstudiante.Direction = ParameterDirection.Output;
                Command.Parameters.Add(ParametroIdEstudiante);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 20;
                ParametroNombre.Value = Estudiante.Nombre;
                Command.Parameters.Add(ParametroNombre);

                SqlParameter ParametroApellido = new SqlParameter();
                ParametroApellido.ParameterName = "@apellido";
                ParametroApellido.SqlDbType = SqlDbType.NVarChar;
                ParametroApellido.Size = 20;
                ParametroApellido.Value = Estudiante.Apellido;
                Command.Parameters.Add(ParametroApellido);

                SqlParameter ParametroTelefono = new SqlParameter();
                ParametroTelefono.ParameterName = "@telefono";
                ParametroTelefono.SqlDbType = SqlDbType.NVarChar;
                ParametroTelefono.Size = 12;
                ParametroTelefono.Value = Estudiante.Telefono;
                Command.Parameters.Add(ParametroTelefono);

                SqlParameter ParametroDireccion = new SqlParameter();
                ParametroDireccion.ParameterName = "@direccion";
                ParametroDireccion.SqlDbType = SqlDbType.NVarChar;
                ParametroDireccion.Size = 50;
                ParametroDireccion.Value = Estudiante.Direccion;
                Command.Parameters.Add(ParametroDireccion);

                SqlParameter ParametroCedula = new SqlParameter();
                ParametroCedula.ParameterName = "@cedula";
                ParametroCedula.SqlDbType = SqlDbType.NVarChar;
                ParametroCedula.Size = 13;
                ParametroCedula.Value = Estudiante.Cedula;
                Command.Parameters.Add(ParametroCedula);

                SqlParameter ParametroGenero = new SqlParameter();
                ParametroGenero.ParameterName = "@genero";
                ParametroGenero.SqlDbType = SqlDbType.Char;
                ParametroGenero.Size = 1;
                ParametroGenero.Value = Estudiante.Genero;
                Command.Parameters.Add(ParametroGenero);

                SqlParameter ParametroCondicionMedica = new SqlParameter();
                ParametroCondicionMedica.ParameterName = "@condicion_medica";
                ParametroCondicionMedica.SqlDbType = SqlDbType.NVarChar;
                ParametroCondicionMedica.Size = 50;
                ParametroCondicionMedica.Value = Estudiante.Condicion_Medica;
                Command.Parameters.Add(ParametroCondicionMedica);

                SqlParameter ParametroFechaNacimiento = new SqlParameter();
                ParametroFechaNacimiento.ParameterName = "@fecha_nacimiento";
                ParametroFechaNacimiento.SqlDbType = SqlDbType.DateTime;
                ParametroFechaNacimiento.Value = Estudiante.Fecha_Nacimiento;
                Command.Parameters.Add(ParametroFechaNacimiento);

                SqlParameter ParametroFechaIngreso = new SqlParameter();
                ParametroFechaIngreso.ParameterName = "@fecha_ingreso";
                ParametroFechaIngreso.SqlDbType = SqlDbType.DateTime;
                ParametroFechaIngreso.Value = Estudiante.Fecha_Ingreso;
                Command.Parameters.Add(ParametroFechaIngreso);

                SqlParameter ParametroCorreoElectronico = new SqlParameter();
                ParametroCorreoElectronico.ParameterName = "@correo_electronico";
                ParametroCorreoElectronico.SqlDbType = SqlDbType.NVarChar;
                ParametroCorreoElectronico.Size = 30;
                ParametroCorreoElectronico.Value = Estudiante.Correo_Electronico;
                Command.Parameters.Add(ParametroCorreoElectronico);

                SqlParameter ParametroNacionalidad = new SqlParameter();
                ParametroNacionalidad.ParameterName = "@nacionalidad";
                ParametroNacionalidad.SqlDbType = SqlDbType.NVarChar;
                ParametroNacionalidad.Size = 20;
                ParametroNacionalidad.Value = Estudiante.Nacionalidad;
                Command.Parameters.Add(ParametroNacionalidad);

                SqlParameter ParametroEstatus = new SqlParameter();
                ParametroEstatus.ParameterName = "@estatus";
                ParametroEstatus.SqlDbType = SqlDbType.NVarChar;
                ParametroEstatus.Size = 20;
                ParametroEstatus.Value = Estudiante.Estatus;
                Command.Parameters.Add(ParametroEstatus);

                SqlParameter ParametroAñoEscolar = new SqlParameter();
                ParametroAñoEscolar.ParameterName = "@añoescolar";
                ParametroAñoEscolar.SqlDbType = SqlDbType.NVarChar;
                ParametroAñoEscolar.Size = 20;
                ParametroAñoEscolar.Value = Estudiante.AñoEscolar;
                Command.Parameters.Add(ParametroAñoEscolar);

                SqlParameter ParametroIdCurso = new SqlParameter();
                ParametroIdCurso.ParameterName = "@idcurso";
                ParametroIdCurso.SqlDbType = SqlDbType.Int;
                ParametroIdCurso.Value = Estudiante.IdCurso;
                Command.Parameters.Add(ParametroIdCurso);

                SqlParameter ParametroIdAreas = new SqlParameter();
                ParametroIdAreas.ParameterName = "@idareas";
                ParametroIdAreas.SqlDbType = SqlDbType.Int;
                ParametroIdAreas.Value = Estudiante.IdAreas;
                Command.Parameters.Add(ParametroIdAreas);

                SqlParameter ParametroIdAsignatura = new SqlParameter();
                ParametroIdAsignatura.ParameterName = "@idasignatura";
                ParametroIdAsignatura.SqlDbType = SqlDbType.Int;
                ParametroIdAsignatura.Value = Estudiante.IdAsignatura;
                Command.Parameters.Add(ParametroIdAsignatura);

                SqlParameter ParametroIdProfesor = new SqlParameter();
                ParametroIdProfesor.ParameterName = "@idprofesor";
                ParametroIdProfesor.SqlDbType = SqlDbType.Int;
                ParametroIdProfesor.Value = Estudiante.IdProfesor;
                Command.Parameters.Add(ParametroIdProfesor);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se insertó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Insertar CapaDatos Estudiante.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        //Metodo Editar
        public string Editar(DatosEstudiantes Estudiante)
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
                Command.CommandText = "speditar_estudiante";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdEstudiante = new SqlParameter();
                ParametroIdEstudiante.ParameterName = "@idestudiante";
                ParametroIdEstudiante.SqlDbType = SqlDbType.Int;
                ParametroIdEstudiante.Value = Estudiante.IdEstudiante;
                Command.Parameters.Add(ParametroIdEstudiante);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 20;
                ParametroNombre.Value = Estudiante.Nombre;
                Command.Parameters.Add(ParametroNombre);

                SqlParameter ParametroApellido = new SqlParameter();
                ParametroApellido.ParameterName = "@apellido";
                ParametroApellido.SqlDbType = SqlDbType.NVarChar;
                ParametroApellido.Size = 20;
                ParametroApellido.Value = Estudiante.Apellido;
                Command.Parameters.Add(ParametroApellido);

                SqlParameter ParametroTelefono = new SqlParameter();
                ParametroTelefono.ParameterName = "@telefono";
                ParametroTelefono.SqlDbType = SqlDbType.NVarChar;
                ParametroTelefono.Size = 12;
                ParametroTelefono.Value = Estudiante.Telefono;
                Command.Parameters.Add(ParametroTelefono);

                SqlParameter ParametroDireccion = new SqlParameter();
                ParametroDireccion.ParameterName = "@direccion";
                ParametroDireccion.SqlDbType = SqlDbType.NVarChar;
                ParametroDireccion.Size = 50;
                ParametroDireccion.Value = Estudiante.Direccion;
                Command.Parameters.Add(ParametroDireccion);

                SqlParameter ParametroCedula = new SqlParameter();
                ParametroCedula.ParameterName = "@cedula";
                ParametroCedula.SqlDbType = SqlDbType.NVarChar;
                ParametroCedula.Size = 13;
                ParametroCedula.Value = Estudiante.Cedula;
                Command.Parameters.Add(ParametroCedula);

                SqlParameter ParametroGenero = new SqlParameter();
                ParametroGenero.ParameterName = "@genero";
                ParametroGenero.SqlDbType = SqlDbType.Char;
                ParametroGenero.Size = 1;
                ParametroGenero.Value = Estudiante.Genero;
                Command.Parameters.Add(ParametroGenero);

                SqlParameter ParametroCondicionMedica = new SqlParameter();
                ParametroCondicionMedica.ParameterName = "@condicion_medica";
                ParametroCondicionMedica.SqlDbType = SqlDbType.NVarChar;
                ParametroCondicionMedica.Size = 50;
                ParametroCondicionMedica.Value = Estudiante.Condicion_Medica;
                Command.Parameters.Add(ParametroCondicionMedica);

                SqlParameter ParametroFechaNacimiento = new SqlParameter();
                ParametroFechaNacimiento.ParameterName = "@fecha_nacimiento";
                ParametroFechaNacimiento.SqlDbType = SqlDbType.DateTime;
                ParametroFechaNacimiento.Value = Estudiante.Fecha_Nacimiento;
                Command.Parameters.Add(ParametroFechaNacimiento);

                SqlParameter ParametroFechaIngreso = new SqlParameter();
                ParametroFechaIngreso.ParameterName = "@fecha_ingreso";
                ParametroFechaIngreso.SqlDbType = SqlDbType.DateTime;
                ParametroFechaIngreso.Value = Estudiante.Fecha_Ingreso;
                Command.Parameters.Add(ParametroFechaIngreso);

                SqlParameter ParametroCorreoElectronico = new SqlParameter();
                ParametroCorreoElectronico.ParameterName = "@correo_electronico";
                ParametroCorreoElectronico.SqlDbType = SqlDbType.NVarChar;
                ParametroCorreoElectronico.Size = 30;
                ParametroCorreoElectronico.Value = Estudiante.Correo_Electronico;
                Command.Parameters.Add(ParametroCorreoElectronico);

                SqlParameter ParametroNacionalidad = new SqlParameter();
                ParametroNacionalidad.ParameterName = "@nacionalidad";
                ParametroNacionalidad.SqlDbType = SqlDbType.NVarChar;
                ParametroNacionalidad.Size = 20;
                ParametroNacionalidad.Value = Estudiante.Nacionalidad;
                Command.Parameters.Add(ParametroNacionalidad);

                SqlParameter ParametroEstatus = new SqlParameter();
                ParametroEstatus.ParameterName = "@estatus";
                ParametroEstatus.SqlDbType = SqlDbType.NVarChar;
                ParametroEstatus.Size = 20;
                ParametroEstatus.Value = Estudiante.Estatus;
                Command.Parameters.Add(ParametroEstatus);

                SqlParameter ParametroAñoEscolar = new SqlParameter();
                ParametroAñoEscolar.ParameterName = "@añoescolar";
                ParametroAñoEscolar.SqlDbType = SqlDbType.NVarChar;
                ParametroAñoEscolar.Size = 20;
                ParametroAñoEscolar.Value = Estudiante.AñoEscolar;
                Command.Parameters.Add(ParametroAñoEscolar);

                SqlParameter ParametroIdCurso = new SqlParameter();
                ParametroIdCurso.ParameterName = "@idcurso";
                ParametroIdCurso.SqlDbType = SqlDbType.Int;
                ParametroIdCurso.Value = Estudiante.IdCurso;
                Command.Parameters.Add(ParametroIdCurso);

                SqlParameter ParametroIdAreas = new SqlParameter();
                ParametroIdAreas.ParameterName = "@idareas";
                ParametroIdAreas.SqlDbType = SqlDbType.Int;
                ParametroIdAreas.Value = Estudiante.IdAreas;
                Command.Parameters.Add(ParametroIdAreas);

                SqlParameter ParametroIdAsignatura = new SqlParameter();
                ParametroIdAsignatura.ParameterName = "@idasignatura";
                ParametroIdAsignatura.SqlDbType = SqlDbType.Int;
                ParametroIdAsignatura.Value = Estudiante.IdAsignatura;
                Command.Parameters.Add(ParametroIdAsignatura);

                SqlParameter ParametroIdProfesor = new SqlParameter();
                ParametroIdProfesor.ParameterName = "@idprofesor";
                ParametroIdProfesor.SqlDbType = SqlDbType.Int;
                ParametroIdProfesor.Value = Estudiante.IdProfesor;
                Command.Parameters.Add(ParametroIdProfesor);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó ningun registro.";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Editar CapaDatos Estudiante.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        //Metodo Eliminar
        public string Eliminar(DatosEstudiantes Estudiante)
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
                Command.CommandText = "speliminar_estudiante";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdEstudiante = new SqlParameter();
                ParametroIdEstudiante.ParameterName = "@idestudiante";
                ParametroIdEstudiante.SqlDbType = SqlDbType.Int;
                ParametroIdEstudiante.Value = Estudiante.IdEstudiante;
                Command.Parameters.Add(ParametroIdEstudiante);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se eliminó ningun registro.";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Eliminar CapaDatos Estudiante.";
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) 
                    SqlCon.Close();
            }
            return Respuesta;
        }

        //Metodo Mostrar
        public DataTable Mostrar()
        {
            DataTable DataTableResultado = new DataTable("Estudiante");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spmostrar_estudiante";
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

        //Metodo Buscar Nombre
        public DataTable BuscarNombre(DatosEstudiantes Estudiante)
        {
            DataTable DataTableResult = new DataTable("Estudiante");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spbuscarnombre_estudiante";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroTextoBuscar = new SqlParameter();
                ParametroTextoBuscar.ParameterName = "@textobuscar";
                ParametroTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParametroTextoBuscar.Size = 20;
                ParametroTextoBuscar.Value = Estudiante.TextoBuscar;
                Command.Parameters.Add(ParametroTextoBuscar);

                SqlDataAdapter SQLAdapter = new SqlDataAdapter(Command);
                SQLAdapter.Fill(DataTableResult);
            }
            catch (Exception)
            {
                DataTableResult = null;
            }
            return DataTableResult;
        }

        //Metodo Buscar Cedula
        public DataTable BuscarCedula(DatosEstudiantes Estudiante)
        {
            DataTable DataTableResult = new DataTable("Estudiante");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spbuscarcedula_estudiante";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroTextoBuscar = new SqlParameter();
                ParametroTextoBuscar.ParameterName = "@textobuscar";
                ParametroTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParametroTextoBuscar.Size = 20;
                ParametroTextoBuscar.Value = Estudiante.TextoBuscar;
                Command.Parameters.Add(ParametroTextoBuscar);

                SqlDataAdapter SQLAdapter = new SqlDataAdapter(Command);
                SQLAdapter.Fill(DataTableResult);
            }
            catch (Exception)
            {
                DataTableResult = null;
            }
            return DataTableResult;
        }
    }
}
