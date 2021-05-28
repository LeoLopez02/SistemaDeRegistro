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
    public class NegocioCalificacion
    {
        public static string Insertar(decimal primerperiodo, decimal segundoperiodo, decimal tercerperiodo, decimal cuartoperiodo, int idasignatura, int idestudiante, string añoescolar)
        {
            DatosCalificacion Objeto = new DatosCalificacion();
            Objeto.PrimerPeriodo = primerperiodo;
            Objeto.SegundoPeriodo = segundoperiodo;
            Objeto.TercerPeriodo = tercerperiodo;
            Objeto.CuartoPeriodo = cuartoperiodo;
            Objeto.IdAsignatura = idasignatura;
            Objeto.IdEstudiante = idestudiante;
            Objeto.AñoEscolar = añoescolar;

            return Objeto.Insertar(Objeto);
        }

        public static string Editar(int idcalificacion, decimal primerperiodo, decimal segundoperiodo, decimal tercerperiodo, decimal cuartoperiodo, int idasignatura, int idestudiante, string añoescolar)
        {
            DatosCalificacion Objeto = new DatosCalificacion();
            Objeto.IdCalificacion = idcalificacion;
            Objeto.PrimerPeriodo = primerperiodo;
            Objeto.SegundoPeriodo = segundoperiodo;
            Objeto.TercerPeriodo = tercerperiodo;
            Objeto.CuartoPeriodo = cuartoperiodo;
            Objeto.IdAsignatura = idasignatura;
            Objeto.IdEstudiante = idestudiante;
            Objeto.AñoEscolar = añoescolar;

            return Objeto.Editar(Objeto);
        }

        public static string Eliminar(int idcalificacion)
        {
            DatosCalificacion Objeto = new DatosCalificacion();
            Objeto.IdCalificacion = idcalificacion;

            return Objeto.Eliminar(Objeto);
        }

        public static DataTable Mostrar()
        {
            return new DatosCalificacion().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DatosCalificacion Objeto = new DatosCalificacion();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarNombre(Objeto);
        }

        public static DataTable BuscarNombreEstudiante(string textobuscar)
        {
            DatosCalificacion Objeto = new DatosCalificacion();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarNombreEstudiante(Objeto);
        }
    }
}
