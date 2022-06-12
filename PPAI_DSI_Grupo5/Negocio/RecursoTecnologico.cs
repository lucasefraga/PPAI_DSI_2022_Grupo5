using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class RecursoTecnologico
    {

        private int numeroRT { get; set; }
        private DateTime fechaAlta { get; set; }
        private string imagenes { get; set; }
        private int periodicidadManPrev { get; set; } //En dias
        private int duracionManPrev { get; set; } //En dias
        private string fraccionHorarioTurnos { get; set; }
        private List<CaracteristicaRecurso> caracteristicaRecurso { get; set; }
        private TipoRecursoTecnologico tipoRecurso { get; set; }
        private Modelo modeloDelRT { get; set; }
        private List<Mantenimiento> mantenimientos { get; set; }
        private List<HorarioRT> disponibilidad { get; set; }
        private List<CambioEstadoRT> cambioEstadoRT { get; set; }
        private List<Turno> turnos { get; set; }

        List<CentroDeInvestigacion> centros = new List<CentroDeInvestigacion>();

        CentroDeInvestigacion centroInvestigacionCorrespondiente = null;

        


        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, string imagenes, 
            int periodicidadManPrev, int duracionManPrev, string fraccionHorarioTurnos, 
            List<CaracteristicaRecurso> caracteristicaRecurso, TipoRecursoTecnologico tipoRecurso, 
            Modelo modeloDelRT, List<Mantenimiento> mantenimientos, List<HorarioRT> disponibilidad, 
            List<CambioEstadoRT> cambioEstadoRT, List<Turno> turnos)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.imagenes = imagenes;
            this.periodicidadManPrev = periodicidadManPrev;
            this.duracionManPrev = duracionManPrev;
            this.fraccionHorarioTurnos = fraccionHorarioTurnos;
            this.caracteristicaRecurso = caracteristicaRecurso;
            this.tipoRecurso = tipoRecurso;
            this.modeloDelRT = modeloDelRT;
            this.mantenimientos = mantenimientos;
            this.disponibilidad = disponibilidad;
            this.cambioEstadoRT = cambioEstadoRT;
            this.turnos = turnos;
        }

        public RecursoTecnologico(int numeroRT, TipoRecursoTecnologico tipoRecurso, Modelo modeloDelRT, List<HorarioRT> disponibilidad, List<CambioEstadoRT> cambioEstadoRT, List<Turno> turnos)
        {
            this.numeroRT = numeroRT;
            this.tipoRecurso = tipoRecurso;
            this.modeloDelRT = modeloDelRT;
            this.disponibilidad = disponibilidad;
            this.cambioEstadoRT = cambioEstadoRT;
            this.turnos = turnos;
        }

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, string imagenes, 
            int periodicidadManPrev, int duracionManPrev, string fraccionHorarioTurnos, TipoRecursoTecnologico tipoRecursoTecnologico, Modelo modelo,List<CambioEstadoRT>cambioEstadoRT)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.imagenes = imagenes;
            this.periodicidadManPrev = periodicidadManPrev;
            this.duracionManPrev = duracionManPrev;
            this.fraccionHorarioTurnos = fraccionHorarioTurnos;
            this.tipoRecurso = tipoRecursoTecnologico;
            this.modeloDelRT = modelo;
            this.cambioEstadoRT = cambioEstadoRT;
        }

        

        public bool esTipoRecursoSeleccinado(TipoRecursoTecnologico tipoRecurso)
        {
            return this.tipoRecurso.Equals(tipoRecurso); ;
        }

        public bool esReservable()
        {
            cambioEstadoRT = Datos.MainDeDatos.crearCambioEstadoRTs();//hay q acomodar esto, no va aca creo
            //Creo q busca el ultimo, que supongo que es el actual?
            return this.cambioEstadoRT.Last().esActual() && this.cambioEstadoRT.Last().esReservable(); 
        }

        public void conocerCentroInvestigacion()
        {
            centros = Datos.MainDeDatos.crearCentros();//hay q acomodar esto, no va aca creo
            foreach (CentroDeInvestigacion centro in centros)
            {
                if (centro.obtenerCIdeRecursoTecnologico(this) != null)
                {
                    centroInvestigacionCorrespondiente = centro.obtenerCIdeRecursoTecnologico(this);
                }
            }
        }

        public bool esCientificoDeMiCentro(PersonalCientifico cientifico)
        {
            return centroInvestigacionCorrespondiente.esCientificoActivo(cientifico);
        }


        public RecursoTecnologicoMuestra buscarDatosAMostrar()
        {
            conocerCentroInvestigacion();
            //Explicacion de como obtengo cada cosa, se puede borrar despues
            int nroInventario = numeroRT;
            string marca = this.modeloDelRT.getNombreMarca();
            string modelo = this.modeloDelRT.getNombre();
            string nombreEstado = this.cambioEstadoRT.Last().getNombreEstado();
            

            return new RecursoTecnologicoMuestra(centroInvestigacionCorrespondiente,numeroRT,marca,modelo,nombreEstado);
        }

    }
}
