using PPAI_DSI_Grupo5.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.Datos
{
    internal static class MainDeDatos
    {
        static readonly TipoRecursoTecnologico tr1 = new TipoRecursoTecnologico("TipoRecurso1", "Descripcion1");
        static readonly TipoRecursoTecnologico tr2 = new TipoRecursoTecnologico("TipoRecurso2", "Descripcion2");
        static readonly TipoRecursoTecnologico tr3 = new TipoRecursoTecnologico("TipoRecurso3", "Descripcion3");
        static readonly TipoRecursoTecnologico tr4 = new TipoRecursoTecnologico("TipoRecurso4", "Descripcion4");
        static readonly TipoRecursoTecnologico tr5 = new TipoRecursoTecnologico("TipoRecurso5", "Descripcion5");
        static readonly RecursoTecnologico rt1 = new RecursoTecnologico(1, DateTime.Now, "N", 30, 10, "n", tr1);




        public static List<TipoRecursoTecnologico> crearTipoRecursoTecnologico()
        {

            List<TipoRecursoTecnologico> listaTipoRecursos = new List<TipoRecursoTecnologico>();
            listaTipoRecursos.Add(tr1);
            listaTipoRecursos.Add(tr2);
            listaTipoRecursos.Add(tr3);
            listaTipoRecursos.Add(tr4);
            listaTipoRecursos.Add(tr5);

            return listaTipoRecursos;

        }

        public static List<RecursoTecnologico> crearRecursoTecnologico()
        {
            RecursoTecnologico rt1 = new RecursoTecnologico(1, DateTime.Now, "N", 30, 10, "n",tr1);


            List<RecursoTecnologico> listaRecursos = new List<RecursoTecnologico>();
            listaRecursos.Add(rt1);

            return listaRecursos;
        }






    }


}
