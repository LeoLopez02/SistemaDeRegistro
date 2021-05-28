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
    public class NegocioCursos
    {
        public static string Insertar(string nombre)
        {
            DatosCursos Objeto = new DatosCursos();
            Objeto.Nombre = nombre;

            return Objeto.Insertar(Objeto);
        }

        public static string Editar(int idcurso, string nombre)
        {
            DatosCursos Objeto = new DatosCursos();
            Objeto.IdCurso = idcurso;
            Objeto.Nombre = nombre;

            return Objeto.Editar(Objeto);
        }

        public static string Eliminar(int idcurso)
        {
            DatosCursos Objeto = new DatosCursos();
            Objeto.IdCurso = idcurso;

            return Objeto.Eliminar(Objeto);
        }

        public static DataTable Mostrar()
        {
            return new DatosCursos().Mostrar();
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            DatosCursos Objeto = new DatosCursos();
            Objeto.TextoBuscar = textobuscar;

            return Objeto.BuscarNombre(Objeto);
        }
    }
}
