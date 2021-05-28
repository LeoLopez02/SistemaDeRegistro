using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioEstudiante
    {
        public static string Insertar(string nombre, string apellido, string telefono, string direccion, string cedula, string genero, string condicionmedica,
            DateTime fechanacimiento, DateTime fechaingreso, string correoelectronico, string nacionalidad, string estatus, string añoescolar, int idcurso, int idareas, int idasignatura, int idprofesor)
        {
            DatosEstudiantes Objeto = new DatosEstudiantes();
            Objeto.Nombre = nombre;
            Objeto.Apellido = apellido;
            Objeto.Telefono = telefono;
            Objeto.Direccion = direccion;
            Objeto.Cedula = cedula;
            Objeto.Genero = genero;
            Objeto.Condicion_Medica = condicionmedica;
            Objeto.Fecha_Nacimiento = fechanacimiento;
            Objeto.Fecha_Ingreso = fechaingreso;
            Objeto.Correo_Electronico = correoelectronico;
            Objeto.Nacionalidad = nacionalidad;
            Objeto.Estatus = estatus;
            Objeto.AñoEscolar = añoescolar;
            Objeto.IdCurso = idcurso;
            Objeto.IdAreas = idareas;
            Objeto.IdAsignatura = idasignatura;
            Objeto.IdProfesor = idprofesor;

            return Objeto.Insertar(Objeto);
        }

        public static string Editar(int idestudiante, string nombre, string apellido, string telefono, string direccion, string cedula, string genero, string condicionmedica, DateTime fechanacimiento, DateTime fechaingreso, string correoelectronico, string nacionalidad, string estatus, string añoescolar, int idcurso, int idareas, int idasignatura, int idprofesor)
        {
            DatosEstudiantes Objeto = new DatosEstudiantes();
            Objeto.IdEstudiante = idestudiante;
            Objeto.Nombre = nombre;
            Objeto.Apellido = apellido;
            Objeto.Telefono = telefono;
            Objeto.Direccion = direccion;
            Objeto.Cedula = cedula;
            Objeto.Genero = genero;
            Objeto.Condicion_Medica = condicionmedica;
            Objeto.Fecha_Nacimiento = fechanacimiento;
            Objeto.Fecha_Ingreso = fechaingreso;
            Objeto.Correo_Electronico = correoelectronico;
            Objeto.Nacionalidad = nacionalidad;
            Objeto.Estatus = estatus;
            Objeto.AñoEscolar = añoescolar;
            Objeto.IdCurso = idcurso;
            Objeto.IdAreas = idareas;
            Objeto.IdAsignatura = idasignatura;
            Objeto.IdProfesor = idprofesor;

            return Objeto.Editar(Objeto);
        }

        public static string Eliminar(int idestudiante)
        {
            DatosEstudiantes Objeto = new DatosEstudiantes();
            Objeto.IdEstudiante = idestudiante;

            return Objeto.Eliminar(Objeto);
        }

        public static DataTable Mostrar()
        {
            return new DatosEstudiantes().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DatosEstudiantes Objeto = new DatosEstudiantes();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarNombre(Objeto);
        }

        public static DataTable BuscarCedula(string textobuscar)
        {
            DatosEstudiantes Objeto = new DatosEstudiantes();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarCedula(Objeto);
        }
    }
}
