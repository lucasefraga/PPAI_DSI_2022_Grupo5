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
        public RecursoTecnologico(int numeroRT, TipoRecursoTecnologico tipoRecurso, Modelo modeloDelRT, List<CambioEstadoRT> cambioEstadoRT, List<Turno> turnos)
        {
            this.numeroRT = numeroRT;
            this.tipoRecurso = tipoRecurso;
            this.modeloDelRT = modeloDelRT;
            this.cambioEstadoRT = cambioEstadoRT;
            this.turnos = turnos;
            
        }


        public bool esTipoRecursoSeleccinado(string tipoRecurso)
        {
            return this.tipoRecurso.esSeleccionado(tipoRecurso);
        }

        public bool esReservable()
        {
            return this.cambioEstadoRT.Last().esActual() && this.cambioEstadoRT.Last().esReservable();
        }

        public RecursoTecnologicoMuestra mostrarDatosDeRT(List<Marca> marcas)
        {
            int nroInv = this.getNumeroRT();
            mostrarCentroDeInvest();
            List<String> modeloYMarca = mostrarMarcaYModelo();
            string nombreEstado = getEstadoRT();

            return new RecursoTecnologicoMuestra(centroInvestigacion, nroInv, modeloYMarca[1], modeloYMarca[0], nombreEstado);
        }

        public void mostrarCentroDeInvest()
        {
            //Esto se realiza porque los datos estan Harcodeados
            List<CentroDeInvestigacion> centrosInvestigacion = LoadData.listarCentros();
            centrosInvestigacion[0].setRecursosTecnologicos(LoadData.loadRecursosTecnologicosC1());
            centrosInvestigacion[1].setRecursosTecnologicos(LoadData.loadRecursosTecnologicosC2());
            centrosInvestigacion[2].setRecursosTecnologicos(LoadData.loadRecursosTecnologicosC3());

            foreach (CentroDeInvestigacion centro in centrosInvestigacion)
            {
                if (centro.obtenerCIdeRecursoTecnologico(this) != null)
                {
                    centroInvestigacion = centro.obtenerCIdeRecursoTecnologico(this);
                }

            }
        }

        public List<String> mostrarMarcaYModelo()
        {
            List<String> modeloYMarca = this.modeloDelRT.obtenerModeloYMarca();
            return modeloYMarca;
        }

        public string getEstadoRT() { return cambioEstadoRT.Last<CambioEstadoRT>().getNombreEstado(); }

        public bool esCientificoDeMiCI(PersonalCientifico cientifico)
        {
            return centroInvestigacion.esCientificoActivo(cientifico);
        }

        // Obtencion de lista de turnos, diferenciando los turnos disponibles si es cientifico de centro o no
        public List<Turno> obtenerTurnos(bool esCientificodelCentro, DateTime date) 
        {
            List<Turno> turnosDisponibles = new List<Turno>();
            

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
                    // Se agrega el tiempo de antelacion de reserva
                    if (turno.validarFechaHoraInicio(date.AddDays(centroInvestigacion.getTiempoAntelacionReserva())))
                    {
                        turnosDisponibles.Add(turno);
                    }
            }

            return turnosDisponibles;
        }
        

        public void reservarTurno(Turno turnoSelecc, Estado est, PersonalCientifico cientifico)
        {
            turnoSelecc.reservar(est);
            centroInvestigacion.reservarTurnoCientifico(turnoSelecc, cientifico);
        }

        //Getters&Setters
        public int getNumeroRT() { return numeroRT; }
        

        public string getTipoRecurso() { return tipoRecurso.getNombre(); }

        public string getCentro() { return centroInvestigacion.getNombre(); }


    }
}
