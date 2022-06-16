using PPAI_DSI_Grupo5.CapaDatos;
using PPAI_DSI_Grupo5.CapaDominio.FabricacionPura;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class RecursoTecnologico
    {
        //ATRIBUTOS
        private int numeroRT;
        private DateTime fechaAlta;
        private string imagenes;
        private int periodicidadManPrev;
        private int duracionManPrev;
        private int fraccionHorarioTurnos;
        private List<CaracteristicaRecurso> caracteristicaRecurso;
        private TipoRecursoTecnologico tipoRecurso;
        private Modelo modeloDelRT;
        private List<Mantenimiento> mantenimientos;
        private List<HorarioRT> disponibilidad;
        private List<CambioEstadoRT> cambioEstadoRT;
        private List<Turno> turnos;
        private CentroDeInvestigacion centroInvestigacion;


        //METODOS

        // --> Metodo Constructor
        public RecursoTecnologico(int numeroRT, TipoRecursoTecnologico tipoRecurso, Modelo modeloDelRT, List<CambioEstadoRT> cambioEstadoRT, List<Turno> turnos, CentroDeInvestigacion centro)
        {
            this.numeroRT = numeroRT;
            this.tipoRecurso = tipoRecurso;
            this.modeloDelRT = modeloDelRT;
            this.cambioEstadoRT = cambioEstadoRT;
            this.turnos = turnos;
            this.centroInvestigacion = centro;
        }

        public bool esTipoRecursoSeleccinado(string tipoRecurso)
        {
            return this.tipoRecurso.esSeleccionado(tipoRecurso);
        }

        public bool esReservable()
        {
            return this.cambioEstadoRT.Last().esActual() && this.cambioEstadoRT.Last().esReservable();
        }

        public bool esCientificoDeMiCentro(PersonalCientifico cientifico)
        {
            return centroInvestigacion.esCientificoActivo(cientifico);
        }

        public List<Turno> obtenerTurnos(bool esCientificodelCentro) //Ver observacion 3 y resolver lo q pide
        {
            List<Turno> turnosDisponibles = new List<Turno>();
            DateTime date = DateTime.Now;

            if (esCientificodelCentro)
            {
                foreach (Turno turno in turnos)
                    if (turno.validarFechaHoraInicio(date))
                    {
                        turnosDisponibles.Add(turno);
                    }

            }
            else
            {
                foreach (Turno turno in turnos)
                    if (turno.validarFechaHoraInicio(date.AddDays(centroInvestigacion.getTiempoAntelacionReserva())))
                    {
                        turnosDisponibles.Add(turno);
                    }
            }

            return turnosDisponibles;
        }
        public RecursoTecnologicoMuestra buscarDatosAMostrar(List<Marca> marcas)
        {
            string marca = this.modeloDelRT.getNombreMarca(marcas);
            string modelo = this.modeloDelRT.getNombre();
            string nombreEstado = this.cambioEstadoRT.Last().getNombreEstado();

            return new RecursoTecnologicoMuestra(centroInvestigacion, numeroRT, marca, modelo, nombreEstado);
        }

        public void reservarTurno(Turno turnoSelecc, Estado est, PersonalCientifico cientifico)
        {
            turnoSelecc.reservar(est);
            centroInvestigacion.reservarTurnoCientifico(turnoSelecc, cientifico);
        }

        //Getters&Setters
        public int getNumeroRT() { return numeroRT; }
        public string getEstadoRT() { return cambioEstadoRT.Last<CambioEstadoRT>().getNombreEstado(); }

        public string getTipoRecurso() { return tipoRecurso.getNombre(); }

        public string getCentro() { return centroInvestigacion.getNombre(); }

        public string getModelo() { return modeloDelRT.getNombre(); }

        public string getMarca() { return modeloDelRT.getNombreMarca(LoadData.loadMarcas()); }

    }
}
