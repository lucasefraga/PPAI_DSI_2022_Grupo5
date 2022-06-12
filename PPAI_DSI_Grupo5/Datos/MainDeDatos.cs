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
        static readonly RecursoTecnologico rt2 = new RecursoTecnologico(2, DateTime.Now, "N", 30, 10, "n", tr2);
        static readonly RecursoTecnologico rt3 = new RecursoTecnologico(3, DateTime.Now, "N", 30, 10, "n", tr3);
        static readonly RecursoTecnologico rt4 = new RecursoTecnologico(4, DateTime.Now, "N", 30, 10, "n", tr4);
        static readonly RecursoTecnologico rt5 = new RecursoTecnologico(5, DateTime.Now, "N", 30, 10, "n", tr5);


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

            List<RecursoTecnologico> listaRecursos = new List<RecursoTecnologico>();
            listaRecursos.Add(rt1);
            listaRecursos.Add(rt2);
            listaRecursos.Add(rt3);
            listaRecursos.Add(rt4);
            listaRecursos.Add(rt5);

            return listaRecursos;
        }






    }


}
