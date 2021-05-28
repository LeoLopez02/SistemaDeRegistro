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
    public class NegocioProfesor
    {
        public static string Insertar(string nombre, string apellido, string telefono, string direccion, string cedula, string genero, string condicionmedica,
            DateTime fechanacimiento, DateTime fechaingreso, string correoelectronico, string nacionalidad, string titulo, string estatus, int idcurso)
        {
            DatosProfesor Objeto = new DatosProfesor();
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
            Objeto.Titulo = titulo;
            Objeto.Estatus = estatus;
            Objeto.IdCurso = idcurso;

            return Objeto.Insertar(Objeto);
        }

        public static string Editar(int idprofesor, string nombre, string apellido, string telefono, string direccion, string cedula, string genero, string condicionmedica, DateTime fechanacimiento, DateTime fechaingreso, string correoelectronico, string nacionalidad, string titulo, string estatus, int idcurso)
        {
            DatosProfesor Objeto = new DatosProfesor();
            Objeto.IdProfesor = idprofesor;
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
            Objeto.Titulo = titulo;
            Objeto.Estatus = estatus;
            Objeto.IdCurso = idcurso;

            return Objeto.Editar(Objeto);
        }

        public static string Eliminar(int idprofesor)
        {
            DatosProfesor Objeto = new DatosProfesor();
            Objeto.IdProfesor = idprofesor;

            return Objeto.Eliminar(Objeto);
        }

        public static DataTable Mostrar()
        {
            return new DatosProfesor().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DatosProfesor Objeto = new DatosProfesor();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarNombre(Objeto);
        }

        public static DataTable BuscarCedula(string textobuscar)
        {
            DatosProfesor Objeto = new DatosProfesor();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarCedula(Objeto);
        }
    }
}
