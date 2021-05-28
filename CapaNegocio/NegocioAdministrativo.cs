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
    public class NegocioAdministrativo
    {
        public static string Insertar(string nombre, string apellido, 
            string telefono, string direccion, string cedula, string genero, string condicionmedica, 
            DateTime fechanacimiento, DateTime fechaingreso, string correoelectronico, 
            string nacionalidad, string titulo, string estatus, string funcion)
        {
            DatosAdministrativo Objeto = new DatosAdministrativo();
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
            Objeto.Funcion = funcion;

            return Objeto.Insertar(Objeto);
        }

        public static string Editar(int idadministrativo, string nombre, string apellido,
            string telefono, string direccion, string cedula, string genero, string condicionmedica,
            DateTime fechanacimiento, DateTime fechaingreso, string correoelectronico,
            string nacionalidad, string titulo, string estatus, string funcion)
        {
            DatosAdministrativo Objeto = new DatosAdministrativo(); //Agregar Id
            Objeto.IdAdministrativo = idadministrativo;
            Objeto.Nombre = nombre;
            Objeto.Apellido = apellido;
            Objeto.Telefono = telefono;
            Objeto.Direccion = direccion;
            Objeto.Cedula = cedula;
            Objeto.Genero = genero; //Agregar
            Objeto.Condicion_Medica = condicionmedica;
            Objeto.Fecha_Nacimiento = fechanacimiento;
            Objeto.Fecha_Ingreso = fechaingreso;
            Objeto.Correo_Electronico = correoelectronico;
            Objeto.Nacionalidad = nacionalidad;
            Objeto.Titulo = titulo;
            Objeto.Estatus = estatus;
            Objeto.Funcion = funcion;

            return Objeto.Editar(Objeto);
        }

        public static string Eliminar(int idadministrativo)
        {
            DatosAdministrativo Objeto = new DatosAdministrativo();
            Objeto.IdAdministrativo = idadministrativo;

            return Objeto.Eliminar(Objeto);
        }

        public static DataTable Mostrar()
        {
            return new DatosAdministrativo().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DatosAdministrativo Objeto = new DatosAdministrativo();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarNombre(Objeto);
        }

        public static DataTable BuscarCedula(string textobuscar)
        {
            DatosAdministrativo Objeto = new DatosAdministrativo();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarCedula(Objeto);
        }
    }
}
