using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class GestorReservaDeTurno
    {
        private List<TipoRecursoTecnologico> listaTipoRTDisponibles { get; set; }
        private TipoRecursoTecnologico tipoRecursoTecnologicoSeleccionado { get; set; }
        private List<RecursoTecnologico> listaRecursoTecnologicosDisponibles { get; set; }
        private List<RecursoTecnologico> listaRecursosTecnologicosValidos { get; set; }
        private List<RecursoTecnologicoMuestra> listaRecursosMuestra { get; set; }








        public void obtenerTipoRecursoTecnologico()
        {

            listaTipoRTDisponibles = Datos.MainDeDatos.crearTipoRecursoTecnologico();
        }

        public void tomarSeleccionTipoRecursoTecnologico()
        {
            //falta la implamentacion de este metodo
            tipoRecursoTecnologicoSeleccionado = listaTipoRTDisponibles[0]; //simplemente para testear
        }

        public void obtenerRecursoTecnologico()
        {

            listaRecursoTecnologicosDisponibles = Datos.MainDeDatos.crearRecursoTecnologico();
        }

        public void buscarRTPorTipoRTValido()
        {
            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.esTipoRecursoSeleccinado(tipoRecursoTecnologicoSeleccionado))
                {
                    if (recurso.esReservable())
                    {
                        listaRecursosTecnologicosValidos.Add(recurso);
                    }
                }
                
            }
        }

        public void buscarDatosRecursosTecnologicosValidos()
        {
            foreach (RecursoTecnologico recurso in listaRecursosTecnologicosValidos)
            {
                listaRecursosMuestra.Add(recurso.buscarDatosAMostrar());
            }
        }


    }
}
