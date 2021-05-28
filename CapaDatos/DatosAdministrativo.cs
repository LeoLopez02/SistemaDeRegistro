using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosAdministrativo
    {
        //Variables
        private int _IdAdministrativo;
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
        private string _Titulo;
        private string _Estatus;
        private string _Funcion;
        private string _TextoBuscar;
        
        //Propiedades
        public int IdAdministrativo
        {
            get { return _IdAdministrativo; }
            set { _IdAdministrativo = value; }
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

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        public string Estatus
        {
            get { return _Estatus; }
            set { _Estatus = value; }
        }

        public string Funcion
        {
            get { return _Funcion; }
            set { _Funcion = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }


        //Constructor vacio
        public DatosAdministrativo()
        { 
        
        }
        //Constructor
        public DatosAdministrativo(int idadministrativo, string nombre, string apellido, string telefono, 
            string direccion, string cedula, string genero, string condicionmedica, DateTime fechanacimiento, 
                DateTime fechaingreso, string correo, string nacionalidad, string titulo, string estatus, 
            string funcion, string textobuscar)
        {
            this.IdAdministrativo = idadministrativo;
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
            this.Titulo = titulo;
            this.Estatus = estatus;
            this.Funcion = funcion;
            this.TextoBuscar = textobuscar;
        }

        //Metodos
        public string Insertar(DatosAdministrativo Administrativo)
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
                Command.CommandText = "spinsertar_administrativo";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdAdministrativo = new SqlParameter();
                ParametroIdAdministrativo.ParameterName = "@idadministrativo";
                ParametroIdAdministrativo.SqlDbType = SqlDbType.Int;
                ParametroIdAdministrativo.Direction = ParameterDirection.Output;
                Command.Parameters.Add(ParametroIdAdministrativo);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 20;
                ParametroNombre.Value = Administrativo.Nombre;
                Command.Parameters.Add(ParametroNombre);

                SqlParameter ParametroApellido = new SqlParameter();
                ParametroApellido.ParameterName = "@apellido";
                ParametroApellido.SqlDbType = SqlDbType.NVarChar;
                ParametroApellido.Size = 20;
                ParametroApellido.Value = Administrativo.Apellido;
                Command.Parameters.Add(ParametroApellido);

                SqlParameter ParametroTelefono = new SqlParameter();
                ParametroTelefono.ParameterName = "@telefono";
                ParametroTelefono.SqlDbType = SqlDbType.NVarChar;
                ParametroTelefono.Size = 12;
                ParametroTelefono.Value = Administrativo.Telefono;
                Command.Parameters.Add(ParametroTelefono);

                SqlParameter ParametroDireccion = new SqlParameter();
                ParametroDireccion.ParameterName = "@direccion";
                ParametroDireccion.SqlDbType = SqlDbType.NVarChar;
                ParametroDireccion.Size = 50;
                ParametroDireccion.Value = Administrativo.Direccion;
                Command.Parameters.Add(ParametroDireccion);

                SqlParameter ParametroCedula = new SqlParameter();
                ParametroCedula.ParameterName = "@cedula";
                ParametroCedula.SqlDbType = SqlDbType.NVarChar;
                ParametroCedula.Size = 13;
                ParametroCedula.Value = Administrativo.Cedula;
                Command.Parameters.Add(ParametroCedula);

                SqlParameter ParametroGenero = new SqlParameter();
                ParametroGenero.ParameterName = "@genero";
                ParametroGenero.SqlDbType = SqlDbType.Char;
                ParametroGenero.Size = 1;
                ParametroGenero.Value = Administrativo.Genero;
                Command.Parameters.Add(ParametroGenero);
                
                SqlParameter ParametroCondicionMedica = new SqlParameter();
                ParametroCondicionMedica.ParameterName = "@condicion_medica";
                ParametroCondicionMedica.SqlDbType = SqlDbType.NVarChar; //poner varchar
                ParametroCondicionMedica.Size = 50;
                ParametroCondicionMedica.Value = Administrativo.Condicion_Medica;
                Command.Parameters.Add(ParametroCondicionMedica);

                SqlParameter ParametroFechaNacimiento = new SqlParameter();
                ParametroFechaNacimiento.ParameterName = "@fecha_nacimiento";
                ParametroFechaNacimiento.SqlDbType = SqlDbType.DateTime; //Poner datetime
                ParametroFechaNacimiento.Value = Administrativo.Fecha_Nacimiento;
                Command.Parameters.Add(ParametroFechaNacimiento);

                SqlParameter ParametroFechaIngreso = new SqlParameter();
                ParametroFechaIngreso.ParameterName = "@fecha_ingreso";
                ParametroFechaIngreso.SqlDbType = SqlDbType.DateTime;
                ParametroFechaIngreso.Value = Administrativo.Fecha_Ingreso;
                Command.Parameters.Add(ParametroFechaIngreso);

                SqlParameter ParametroCorreoElectronico = new SqlParameter();
                ParametroCorreoElectronico.ParameterName = "@correo_electronico";
                ParametroCorreoElectronico.SqlDbType = SqlDbType.NVarChar;
                ParametroCorreoElectronico.Size = 30;
                ParametroCorreoElectronico.Value = Administrativo.Correo_Electronico;
                Command.Parameters.Add(ParametroCorreoElectronico);

                SqlParameter ParametroNacionalidad = new SqlParameter();
                ParametroNacionalidad.ParameterName = "@nacionalidad";
                ParametroNacionalidad.SqlDbType = SqlDbType.NVarChar;
                ParametroNacionalidad.Size = 20;
                ParametroNacionalidad.Value = Administrativo.Nacionalidad;
                Command.Parameters.Add(ParametroNacionalidad);

                SqlParameter ParametroTitulo = new SqlParameter();
                ParametroTitulo.ParameterName = "@titulo";
                ParametroTitulo.SqlDbType = SqlDbType.NVarChar;
                ParametroTitulo.Size = 20;
                ParametroTitulo.Value = Administrativo.Titulo;
                Command.Parameters.Add(ParametroTitulo);

                SqlParameter ParametroEstatus = new SqlParameter();
                ParametroEstatus.ParameterName = "@estatus";
                ParametroEstatus.SqlDbType = SqlDbType.NVarChar;
                ParametroEstatus.Size = 20;
                ParametroEstatus.Value = Administrativo.Estatus;
                Command.Parameters.Add(ParametroEstatus);

                SqlParameter ParametroFuncion = new SqlParameter();
                ParametroFuncion.ParameterName = "@funcion";
                ParametroFuncion.SqlDbType = SqlDbType.NVarChar;
                ParametroFuncion.Size = 20;
                ParametroFuncion.Value = Administrativo.Funcion;
                Command.Parameters.Add(ParametroFuncion);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se insertó ningun registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Insertar CapaDatos Administrativo."; 
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Editar(DatosAdministrativo Administrativo)
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
                Command.CommandText = "speditar_administrativo";
                Command.CommandType = CommandType.StoredProcedure;

                //Parametros
                SqlParameter ParametroIdAdministrativo = new SqlParameter();
                ParametroIdAdministrativo.ParameterName = "@idadministrativo";
                ParametroIdAdministrativo.SqlDbType = SqlDbType.Int;
                ParametroIdAdministrativo.Value = Administrativo.IdAdministrativo;
                Command.Parameters.Add(ParametroIdAdministrativo);

                SqlParameter ParametroNombre = new SqlParameter();
                ParametroNombre.ParameterName = "@nombre";
                ParametroNombre.SqlDbType = SqlDbType.NVarChar;
                ParametroNombre.Size = 20;
                ParametroNombre.Value = Administrativo.Nombre;
                Command.Parameters.Add(ParametroNombre);

                SqlParameter ParametroApellido = new SqlParameter();
                ParametroApellido.ParameterName = "@apellido";
                ParametroApellido.SqlDbType = SqlDbType.NVarChar;
                ParametroApellido.Size = 20;
                ParametroApellido.Value = Administrativo.Apellido;
                Command.Parameters.Add(ParametroApellido);

                SqlParameter ParametroTelefono = new SqlParameter();
                ParametroTelefono.ParameterName = "@telefono";
                ParametroTelefono.SqlDbType = SqlDbType.NVarChar;
                ParametroTelefono.Size = 12;
                ParametroTelefono.Value = Administrativo.Telefono;
                Command.Parameters.Add(ParametroTelefono);

                SqlParameter ParametroDireccion = new SqlParameter();
                ParametroDireccion.ParameterName = "@direccion";
                ParametroDireccion.SqlDbType = SqlDbType.NVarChar;
                ParametroDireccion.Size = 50;
                ParametroDireccion.Value = Administrativo.Direccion;
                Command.Parameters.Add(ParametroDireccion);

                SqlParameter ParametroCedula = new SqlParameter();
                ParametroCedula.ParameterName = "@cedula";
                ParametroCedula.SqlDbType = SqlDbType.NVarChar;
                ParametroCedula.Size = 13;
                ParametroCedula.Value = Administrativo.Cedula;
                Command.Parameters.Add(ParametroCedula);

                SqlParameter ParametroGenero = new SqlParameter();
                ParametroGenero.ParameterName = "@genero";
                ParametroGenero.SqlDbType = SqlDbType.Char;
                ParametroGenero.Size = 1;
                ParametroGenero.Value = Administrativo.Genero;
                Command.Parameters.Add(ParametroGenero);

                SqlParameter ParametroCondicionMedica = new SqlParameter();
                ParametroCondicionMedica.ParameterName = "@condicion_medica";
                ParametroCondicionMedica.SqlDbType = SqlDbType.NVarChar; //poner varchar
                ParametroCondicionMedica.Size = 50;
                ParametroCondicionMedica.Value = Administrativo.Condicion_Medica;
                Command.Parameters.Add(ParametroCondicionMedica);

                SqlParameter ParametroFechaNacimiento = new SqlParameter();
                ParametroFechaNacimiento.ParameterName = "@fecha_nacimiento";
                ParametroFechaNacimiento.SqlDbType = SqlDbType.DateTime; //Poner datetime
                ParametroFechaNacimiento.Value = Administrativo.Fecha_Nacimiento;
                Command.Parameters.Add(ParametroFechaNacimiento);

                SqlParameter ParametroFechaIngreso = new SqlParameter();
                ParametroFechaIngreso.ParameterName = "@fecha_ingreso";
                ParametroFechaIngreso.SqlDbType = SqlDbType.DateTime;
                ParametroFechaIngreso.Value = Administrativo.Fecha_Ingreso;
                Command.Parameters.Add(ParametroFechaIngreso);

                SqlParameter ParametroCorreoElectronico = new SqlParameter();
                ParametroCorreoElectronico.ParameterName = "@correo_electronico";
                ParametroCorreoElectronico.SqlDbType = SqlDbType.NVarChar;
                ParametroCorreoElectronico.Size = 30;
                ParametroCorreoElectronico.Value = Administrativo.Correo_Electronico;
                Command.Parameters.Add(ParametroCorreoElectronico);

                SqlParameter ParametroNacionalidad = new SqlParameter();
                ParametroNacionalidad.ParameterName = "@nacionalidad";
                ParametroNacionalidad.SqlDbType = SqlDbType.NVarChar;
                ParametroNacionalidad.Size = 20;
                ParametroNacionalidad.Value = Administrativo.Nacionalidad;
                Command.Parameters.Add(ParametroNacionalidad);

                SqlParameter ParametroTitulo = new SqlParameter();
                ParametroTitulo.ParameterName = "@titulo";
                ParametroTitulo.SqlDbType = SqlDbType.NVarChar;
                ParametroTitulo.Size = 20;
                ParametroTitulo.Value = Administrativo.Titulo;
                Command.Parameters.Add(ParametroTitulo);

                SqlParameter ParametroEstatus = new SqlParameter();
                ParametroEstatus.ParameterName = "@estatus";
                ParametroEstatus.SqlDbType = SqlDbType.NVarChar;
                ParametroEstatus.Size = 20;
                ParametroEstatus.Value = Administrativo.Estatus;
                Command.Parameters.Add(ParametroEstatus);

                SqlParameter ParametroFuncion = new SqlParameter();
                ParametroFuncion.ParameterName = "@funcion";
                ParametroFuncion.SqlDbType = SqlDbType.NVarChar;
                ParametroFuncion.Size = 20;
                ParametroFuncion.Value = Administrativo.Funcion;
                Command.Parameters.Add(ParametroFuncion);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó ningun registro.";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message + ex.StackTrace + " Editar CapaDatos Administrativo."; //Agregar
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Eliminar(DatosAdministrativo Administrativo)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "speliminar_administrativo";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroIdAdministrativo = new SqlParameter();
                ParametroIdAdministrativo.ParameterName = "@idadministrativo";
                ParametroIdAdministrativo.SqlDbType = SqlDbType.Int;
                ParametroIdAdministrativo.Value = Administrativo.IdAdministrativo;
                Command.Parameters.Add(ParametroIdAdministrativo);

                //Ejecutamos nuestro comando
                Respuesta = Command.ExecuteNonQuery() == 1 ? "OK" : " No se eliminó correctamente el registro.";
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
            DataTable DataTableResultado = new DataTable("Administrativo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spmostrar_administrativo";
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

        public DataTable BuscarNombre(DatosAdministrativo Administrativo)
        {
            DataTable DataTableResult = new DataTable("Administrativo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn; //Eliminar el SQL Conection.Open()
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spbuscarnombre_administrativo";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroTextoBuscar = new SqlParameter();
                ParametroTextoBuscar.ParameterName = "@textobuscar";
                ParametroTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParametroTextoBuscar.Size = 20;
                ParametroTextoBuscar.Value = Administrativo.TextoBuscar;
                Command.Parameters.Add(ParametroTextoBuscar);

                SqlDataAdapter SQLAdapter = new SqlDataAdapter(Command); //Agregar el Command
                SQLAdapter.Fill(DataTableResult);
            }
            catch (Exception)
            {
                DataTableResult = null;
            }
            return DataTableResult;
        }

        public DataTable BuscarCedula(DatosAdministrativo Administrativo)
        {
            DataTable DataTableResult = new DataTable("Administrativo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo Fuente
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand Command = new SqlCommand();
                Command.Connection = SqlCon;
                Command.CommandText = "spbuscarcedula_administrativo";
                Command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParametroTextoBuscar = new SqlParameter();
                ParametroTextoBuscar.ParameterName = "@textobuscar";
                ParametroTextoBuscar.SqlDbType = SqlDbType.NVarChar;
                ParametroTextoBuscar.Size = 20;
                ParametroTextoBuscar.Value = Administrativo.TextoBuscar;
                Command.Parameters.Add(ParametroTextoBuscar);

                SqlDataAdapter SQLAdapter = new SqlDataAdapter(Command); //Agregar el Command
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
