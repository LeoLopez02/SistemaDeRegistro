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
    public class NegocioArea
    {
        public static string Insertar(string nombre, int idcurso)
        {
            DatosArea Objeto = new DatosArea();
            Objeto.Nombre = nombre;
            Objeto.IdCurso = idcurso;

            return Objeto.Insertar(Objeto);
        }

        public static string Editar(int idareas, string nombre, int idcurso)
        {
            DatosArea Objeto = new DatosArea();
            Objeto.IdAreas = idareas;
            Objeto.Nombre = nombre;
            Objeto.IdCurso = idcurso;

            return Objeto.Editar(Objeto);
        }

        public static string Eliminar(int idareas)
        {
            DatosArea Objeto = new DatosArea();
            Objeto.IdAreas = idareas;

            return Objeto.Eliminar(Objeto);
        }

        public static DataTable Mostrar()
        {
            return new DatosArea().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DatosArea Objeto = new DatosArea();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarNombre(Objeto);
        }
    }
}
