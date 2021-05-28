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
    public class NegocioAsignatura
    {
        public static string Insertar(string nombre, string descripcion, int cantidadhoras, int idprofesor, int idcurso)
        {
            DatosAsignatura Objeto = new DatosAsignatura();
            Objeto.Nombre = nombre;
            Objeto.Descripcion = descripcion;
            Objeto.CantidadHoras = cantidadhoras;
            Objeto.IdProfesor = idprofesor;
            Objeto.IdCurso = idcurso;

            return Objeto.Insertar(Objeto);
        }

        public static string Editar(int idasignatura, string nombre, string descripcion, int cantidadhoras, int idprofesor, int idcurso)
        {
            DatosAsignatura Objeto = new DatosAsignatura();
            Objeto.IdAsignatura = idasignatura;
            Objeto.Nombre = nombre;
            Objeto.Descripcion = descripcion;
            Objeto.CantidadHoras = cantidadhoras;
            Objeto.IdProfesor = idprofesor;
            Objeto.IdCurso = idcurso;

            return Objeto.Editar(Objeto);
        }

        public static string Eliminar(int idasignatura)
        {
            DatosAsignatura Objeto = new DatosAsignatura();
            Objeto.IdAsignatura = idasignatura;

            return Objeto.Eliminar(Objeto);
        }

        public static DataTable Mostrar()
        {
            return new DatosAsignatura().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DatosAsignatura Objeto = new DatosAsignatura();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarNombre(Objeto);
        }
    }
}
