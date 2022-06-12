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
        public static readonly TipoRecursoTecnologico tr1 = new TipoRecursoTecnologico("TipoRecurso1", "Descripcion1");
        public static readonly TipoRecursoTecnologico tr2 = new TipoRecursoTecnologico("TipoRecurso2", "Descripcion2");
        public static readonly TipoRecursoTecnologico tr3 = new TipoRecursoTecnologico("TipoRecurso3", "Descripcion3");
        public static readonly TipoRecursoTecnologico tr4 = new TipoRecursoTecnologico("TipoRecurso4", "Descripcion4");
        public static readonly TipoRecursoTecnologico tr5 = new TipoRecursoTecnologico("TipoRecurso5", "Descripcion5");



        public static readonly DateTime fechaFin = new DateTime(2023, 5, 10, 10, 10, 10);
        public static readonly DateTime fechaInicio = new DateTime(2022, 5, 10, 10, 10, 10);
        public static readonly Usuario us1 = new Usuario("1234", "Cientifico1", true);
        public static readonly Sesion ses1 = new Sesion(fechaFin, fechaInicio, us1);

        public static readonly PersonalCientifico pc1 = new PersonalCientifico(001,"Juan","Perz",111111111,"juan@gmail.com", "juan@gmail.com",111111111,us1);
        public static readonly PersonalCientifico pc2 = new PersonalCientifico(002,"Mario","Perz",222222222,"mario@gmail.com", "juan@gmail.com",222222222,us1);
        public static readonly PersonalCientifico pc3 = new PersonalCientifico(003,"Sol","Perz",333333333,"sol@gmail.com", "juan@gmail.com",333333333,us1);
        public static readonly PersonalCientifico pc4 = new PersonalCientifico(004,"Jose","Perz",444444444,"jose@gmail.com", "juan@gmail.com",444444444,us1);

        public static readonly PersonalCientifico pc5 = new PersonalCientifico(005,"Direc","Perz",555555555,"direc@gmail.com", "juan@gmail.com",555555555,us1);

        public static readonly AsignacionCientificoCI acci1 = new AsignacionCientificoCI(fechaInicio,fechaFin,pc1);
        public static readonly AsignacionCientificoCI acci2 = new AsignacionCientificoCI(fechaInicio,fechaFin,pc2);
        public static readonly AsignacionCientificoCI acci3 = new AsignacionCientificoCI(fechaInicio,fechaFin,pc3);
        public static readonly AsignacionCientificoCI acci4 = new AsignacionCientificoCI(fechaInicio,fechaFin,pc4);

        public static readonly AsignacionDirectorCI adci1 = new AsignacionDirectorCI(fechaInicio,fechaFin,pc5);

        public static readonly Estado e1 = new Estado("Estado1","n","Estado",true,true);
        public static readonly Estado e2 = new Estado("Estado2","n","Estado",true,false);
        public static readonly Estado e3 = new Estado("Estado3","n","Estado",false,true);
        public static readonly Estado e4 = new Estado("Estado4","n","Estado",false,false);

        public static readonly CambioEstadoRT cert1 = new CambioEstadoRT(fechaInicio, fechaFin, e1);
        public static readonly CambioEstadoRT cert2 = new CambioEstadoRT(fechaInicio, fechaFin, e2);
        public static readonly CambioEstadoRT cert3 = new CambioEstadoRT(fechaInicio, fechaFin, e3);
        public static readonly CambioEstadoRT cert4 = new CambioEstadoRT(fechaInicio, fechaFin, e4);

        public static readonly Modelo mod1 = new Modelo("Modelo1");
        public static readonly Modelo mod2 = new Modelo("Modelo2");
        
        public static readonly Modelo mod3 = new Modelo("Modelo3");
        public static readonly Modelo mod4 = new Modelo("Modelo4");

        public static readonly Marca mar1 = new Marca("Marca1", crearModelos());


        public static readonly RecursoTecnologico rt1 = new RecursoTecnologico(1, DateTime.Now, "N", 30, 10, "n", tr1, mod1, crearCambioEstadoRTs());
        public static readonly RecursoTecnologico rt2 = new RecursoTecnologico(2, DateTime.Now, "N", 30, 10, "n", tr2, mod2, crearCambioEstadoRTs());
        public static readonly RecursoTecnologico rt3 = new RecursoTecnologico(3, DateTime.Now, "N", 30, 10, "n", tr3, mod3, crearCambioEstadoRTs());
        public static readonly RecursoTecnologico rt4 = new RecursoTecnologico(4, DateTime.Now, "N", 30, 10, "n", tr4, mod4, crearCambioEstadoRTs());
        public static readonly RecursoTecnologico rt5 = new RecursoTecnologico(5, DateTime.Now, "N", 30, 10, "n", tr5, mod1, crearCambioEstadoRTs());


        public static readonly CentroDeInvestigacion ci1 = new CentroDeInvestigacion("Centro 1","AAA","Direccion1",
            "Edificio1",4,"Coordenadas","centr1@gmail.com","numRes",fechaInicio,"Reglamento","Caracterisitcas",fechaInicio,
            6,fechaFin,"Motivo",crearRecursoTecnologico(),crearAsignacionCientifico(),crearAsignaciondirector());


        public static List<CentroDeInvestigacion> crearCentros()
        {
            crearCambioEstadoRTs();

            var lista = new List<CentroDeInvestigacion>();
            lista.Add(ci1);
            return lista;
        }


        public static List<AsignacionCientificoCI> crearAsignacionCientifico()
        {
            List<AsignacionCientificoCI> list = new List<AsignacionCientificoCI>();
            list.Add(acci1);
            list.Add(acci2);
            list.Add(acci3);
            list.Add(acci4);

            return list;
        }

        public static List<AsignacionDirectorCI> crearAsignaciondirector()
        {
            List<AsignacionDirectorCI> list = new List<AsignacionDirectorCI>();
            list.Add(adci1);
            return list;
        }

        public static List<Modelo> crearModelos()
        {
            List<Modelo> modList1 = new List<Modelo>();
            modList1.Add(mod1);
            modList1.Add(mod2);
            modList1.Add(mod3);
            modList1.Add(mod4);

            return modList1;
        }



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

        public static Sesion getSesionActual()
        {
            return ses1;
        }

        public static List<CambioEstadoRT> crearCambioEstadoRTs()
        {
            List<CambioEstadoRT> listaCambioEstados = new List<CambioEstadoRT>();
            listaCambioEstados.Add(cert4);
            listaCambioEstados.Add(cert3);
            listaCambioEstados.Add(cert2);
            listaCambioEstados.Add(cert1);

            return listaCambioEstados;

        }

        public static List<Marca> crearMarca()
        {
            List<Marca> marcas = new List<Marca>();
            marcas.Add(mar1);
            return marcas;
        }



    }


}
