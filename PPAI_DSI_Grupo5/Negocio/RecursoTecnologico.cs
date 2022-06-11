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

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, string imagenes, 
            int periodicidadManPrev, int duracionManPrev, string fraccionHorarioTurnos)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.imagenes = imagenes;
            this.periodicidadManPrev = periodicidadManPrev;
            this.duracionManPrev = duracionManPrev;
            this.fraccionHorarioTurnos = fraccionHorarioTurnos;
        }

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, string imagenes, 
            int periodicidadManPrev, int duracionManPrev, string fraccionHorarioTurnos, 
            TipoRecursoTecnologico tipoRecurso, Modelo modeloDelRT, List<HorarioRT> disponibilidad, 
            List<CambioEstadoRT> cambioEstadoRT) : this(numeroRT, fechaAlta, imagenes, periodicidadManPrev, 
                duracionManPrev, fraccionHorarioTurnos)
        {

            this.tipoRecurso = tipoRecurso;
            this.modeloDelRT = modeloDelRT;
            this.disponibilidad = disponibilidad;
            this.cambioEstadoRT = cambioEstadoRT;
        }


    }
}
