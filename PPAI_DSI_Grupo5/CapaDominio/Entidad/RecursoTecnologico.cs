﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI_Grupo5.CapaDominio.FabricacionPura;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
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

        public int getNumeroRT()
        {
            return numeroRT;
        }

        public bool esTipoRecursoSeleccinado(TipoRecursoTecnologico tipoRecurso)
        {
            return this.tipoRecurso.Equals(tipoRecurso); ;
        }

        public bool esReservable()
        {
            //Crea los cambio de estados
            cambioEstadoRT = CapaDatos.MainDeDatos.crearCambioEstadoRTs();
            
            //Verifica que sea actual (si la fecha actual esta comprendida entre las del CambioEstadoRT)
            //Y valida si el estado es reservable
            return this.cambioEstadoRT.Last().esActual() && this.cambioEstadoRT.Last().esReservable(); 
        }

        public void conocerCentroInvestigacion()
        {
            centros = CapaDatos.MainDeDatos.crearCentros();//hay q acomodar esto, no va aca creo
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
       
        public List<TurnoEstado> obtenerTurnos(bool esCientifico)
        {
            List<Turno> turnos_disponibles = new List<Turno>();
            List<TurnoEstado> mostrar_turnos = new List<TurnoEstado>();

            if (esCientifico)
                foreach (Turno turno in turnos)
                    if (turno.validarFechaHoraInicio(0))
                        turnos_disponibles.Add(turno);
                    else
                        ;
            else
                //Conozco el CI para poder sacar el tiempo
                conocerCentroInvestigacion();
                foreach (Turno turno in turnos)
                    if (turno.validarFechaHoraInicio(centroInvestigacionCorrespondiente.TiempoAntelacionReserva))
                        turnos_disponibles.Add(turno);


            foreach (Turno turno1 in turnos_disponibles)
                mostrar_turnos.Add(turno1.mostrarTurnos());
            return mostrar_turnos;
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

        public void reservarTurno(Turno turnoSelecc, Estado est, PersonalCientifico cientifico)
        {
            turnoSelecc.reservar(est);
            centroInvestigacionCorrespondiente.reservarTurnoCientifico(turnoSelecc, cientifico);
        }

    }
}
