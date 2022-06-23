using PPAI_DSI_Grupo5.CapaDominio.Entidad;
using PPAI_DSI_Grupo5.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using PPAI_DSI_Grupo5.Presentacion.Transacciones;
using PPAI_DSI_Grupo5.Presentacion.ABM_Turno;

namespace PPAI_DSI_Grupo5.CapaDominio.FabricacionPura
{
    // CONTROLLER
    internal class GestorReservaDeTurno
    {
        //ATRIBUTOS
        private List<TipoRecursoTecnologico> listaTipoRTDisponibles;
        private List<RecursoTecnologico> listaRecursosTecnologicosValidos;
        private List<RecursoTecnologicoMuestra> listaRecursosMuestra;
        private RecursoTecnologico recursoTecnologicoSeleccionado;
        private List<Estado> listaEstados;
        private Sesion sesionActual;
        private Dictionary<string, List<TurnoModel>> turnosOrdenados;
        private PersonalCientifico cientificoLogueado;
        private Turno turnoSeleccionado;
        private List<RecursoTecnologico> listaRecursoTecnologicosDisponibles; 
        private List<Turno> listaTurnosRTSeleccionado;
        private RegistrarTurno ventanaRegistrarTurno;
        private AltaTurno ventanaAltaTurno;
        private InterfazEmailReserva interfazNotificacion;
        private AsignacionCientificoCI asignCientificoCI;
        private DateTime fechaHoraActual;

        //METODOS

        // --> Metodo Constructor
        public GestorReservaDeTurno(RegistrarTurno registrarTurno, AltaTurno altaTurno, Sesion sesion)
        {
            this.ventanaRegistrarTurno = registrarTurno;
            this.ventanaAltaTurno = altaTurno;
            this.sesionActual = sesion;
            altaTurno.setGestor(this);

            listaTipoRTDisponibles = LoadData.loadTiposRecursoTecnologico();
            listaRecursoTecnologicosDisponibles = LoadData.loadRecursosTecnologicos();
            listaEstados = LoadData.loadEstados();
        }

        // --> Nueva Reserva de Turno, llamada a boundary
        public void nuevaReservaTurno()
        {
            List<string> lista = obtenerRT();
            ventanaRegistrarTurno.mostrarYSolicitarSeleccionTipoRT(lista);
        }

        // --> Retorna lista con los tipos de RT disponibles
        public List<string> obtenerRT()
        {
            List<string> lista = new List<string>();
            foreach (var rt in listaTipoRTDisponibles)
            {
                lista.Add(rt.getNombre());
            }

            return lista;
        }

        // --> Toma seleccion de Tipo, y busca por Tipo
        public void tomarSeleccionTipoRecursoTecnologico(string tipoRecursoSeleccionado)
        {
            buscarRTPorTipoRTValido(tipoRecursoSeleccionado);
        }

        // --> Busca por Tipo de RT, conecta con Boundary
        public void buscarRTPorTipoRTValido(string tipoRecursoSeleccionado)
        {

            listaRecursosTecnologicosValidos = new List<RecursoTecnologico>();

            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.esTipoRecursoSeleccinado(tipoRecursoSeleccionado))
                {
                    //listaRecursosTecnologicosValidos.Add(recurso); --> MOSTRAR RT QUE NO ESTAN DISPONIBLES - COLORES

                    if (recurso.esReservable())
                    {
                        listaRecursosTecnologicosValidos.Add(recurso);
                    }
                }
            }

            listaRecursosMuestra = new List<RecursoTecnologicoMuestra>();

            foreach (RecursoTecnologico recurso in listaRecursosTecnologicosValidos)
            {
                listaRecursosMuestra.Add(recurso.mostrarDatosDeRT(LoadData.loadMarcas()));
            }

            agruparRTPorCentroInvestigacion();
            asignarColorPorEstadoDeRT();

            ventanaRegistrarTurno.MostrarYSolicitarRTAUtilizar(listaRecursosMuestra);
        }

        // --> Ordena la lista por CI
        public void agruparRTPorCentroInvestigacion()
        {
            listaRecursosMuestra.OrderBy(x => x.getCentroInvestigacion());   
        }

        // --> Asignacion de colores
        public void asignarColorPorEstadoDeRT()
        {
            foreach (RecursoTecnologicoMuestra recurso in listaRecursosMuestra)
            {
                switch (recurso.getEstado())
                {
                    case "Disponible":
                        recurso.setColor(1);//Azul
                        break;
                    case "En mantenimiento":
                        recurso.setColor(2);//Verde
                        break;
                    case "Mantenimiento correctivo"://Gris
                        recurso.setColor(3);
                        break;
                    default:
                        recurso.setColor(0);//No color -> Blanco
                        break;
                }
            }
        }

        // --> Toma el RT seleccionado y obtiene los turnos para ese RT
        public void tomarSeleccionRTAUtilizar(DataGridViewRow dataGridViewRow)
        {

            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.getNumeroRT() == (int)dataGridViewRow.Cells[0].Value)
                {
                    recursoTecnologicoSeleccionado = recurso;
                }
            }
            obtenerTurnosReservables();
        }

        // --> Retorna True si el cientificoLogeado pertenece al CI del RT seleccionado
        public bool verificarCIDelUsuario()
        {
            cientificoLogueado = sesionActual.verificarCientificoLogueado();

            return recursoTecnologicoSeleccionado.esCientificoDeMiCI(cientificoLogueado);
        }

        // --> Obtencion de turnos
        public void obtenerTurnosReservables()
        {
            obtenerFechaYHoraAcual();

            listaTurnosRTSeleccionado = recursoTecnologicoSeleccionado.obtenerTurnos(verificarCIDelUsuario(), fechaHoraActual);

            turnosOrdenados = ordenarYAgruparTurnos();

            Dictionary<string, bool> disponibilidadAMostrar = determinarDisponibilidadTurnos();

            ventanaAltaTurno.MostrarYSolicitarSeleccionTurnos(disponibilidadAMostrar, recursoTecnologicoSeleccionado);
        }

        // --> Fecha y hora actual.......
        public void obtenerFechaYHoraAcual()
        {
            fechaHoraActual = DateTime.Now;
        }

        // --> Ordena y Agrupa TurnoModel
        public Dictionary<string, List<TurnoModel>> ordenarYAgruparTurnos()
        {
            Dictionary<string, List<TurnoModel>> turnosOrdenados = new Dictionary<string, List<TurnoModel>>();
            List<TurnoModel> turnos = new List<TurnoModel>();

            foreach (var turno in listaTurnosRTSeleccionado)
            {
                TurnoModel turnoAMostrar = turno.mostrarTurno();

                if (turnosOrdenados.ContainsKey(turnoAMostrar.getFechaInicio().ToShortDateString()))
                {
                    turnosOrdenados[turnoAMostrar.getFechaInicio().ToShortDateString()].Add(turnoAMostrar);
                }
                else
                {
                    List<TurnoModel> list = new List<TurnoModel>();
                    list.Add(turnoAMostrar);
                    turnosOrdenados.Add(turnoAMostrar.getFechaInicio().ToShortDateString(), list);
                }
            }

            return turnosOrdenados;
        }

        // --> Retorna la disponibilidad de cada turno
        public Dictionary<string, bool> determinarDisponibilidadTurnos()
        {
            Dictionary<string, bool> disponibilidad = new Dictionary<string, bool>();

            foreach (var entry in turnosOrdenados.Keys)
            {
                disponibilidad.Add(entry, false);
                foreach (var turno in turnosOrdenados[entry])
                {
                    if (turno.getEstado() == "Disponible")
                    {
                        disponibilidad[entry] = true;
                        break;
                    }
                }
            }
            return disponibilidad;
        }

        // --> Toma seleccion de Turno
        public void tomarSeleccionTurno(DataGridViewRow dataGridViewRow)
        {
            foreach (var turnoDisponible in listaTurnosRTSeleccionado)
            {
                string fecha = dataGridViewRow.Cells[0].Value.ToString();
                string horaInicio = dataGridViewRow.Cells[1].Value.ToString();
                string horaFin = dataGridViewRow.Cells[2].Value.ToString();
                string estado = dataGridViewRow.Cells[3].Value.ToString();

                TurnoModel comparable = turnoDisponible.mostrarTurno();

                string fechaComparable = comparable.getFechaInicio().ToShortDateString();
                string horaInicioComparable = comparable.getFechaInicio().ToShortTimeString();
                string horaFinComparable = comparable.getFechaFin().ToShortTimeString();
                string estadoComparable = comparable.getEstado();

                if (fecha == fechaComparable && horaInicio == horaInicioComparable && horaFin == horaFinComparable && estado == estadoComparable)
                {
                    turnoSeleccionado = turnoDisponible;
                }
            };
        }

        // Toma seleccion de Dia
        public void tomarSeleccionDia(DateTime date)
        {
            string dateFormatted = date.ToShortDateString();
            if (turnosOrdenados.ContainsKey(dateFormatted))
            {
                ventanaAltaTurno.mostrarDiaSeleccionado(turnosOrdenados[dateFormatted]);
            }
        }//Falta agregar en el Diagrama

        // -->  Registra la reserva si la confirmacion es positiva
        public void tomarConfirmacionReserva(bool confirmacion)
        {
            if (confirmacion)
            {
                registrarReserva();
            }
        }

        // --> Registra la reserva de un turnoSeleccionado, en un estado para un cientifico
        public void registrarReserva()
        {
            foreach (var estado in listaEstados)
            {
                if (estado.esAmbitoTurno())
                {
                    if (estado.esReservado())
                    {
                        recursoTecnologicoSeleccionado.reservarTurno(turnoSeleccionado, estado, cientificoLogueado);
                    }
                }
            }
        }

        // --> Generacion de mail
        public void generarMail()
        {
            interfazNotificacion = new InterfazEmailReserva();
            string email = obtenerMailCientifico();
            string error = "Gmail: acceso denegado.";
            var mensaje = new StringBuilder("Se registro el turno del Recurso");
            interfazNotificacion.enviarMail(mensaje,email,recursoTecnologicoSeleccionado.getNumeroRT().ToString(),turnoSeleccionado.getfechaTurno().ToString(),out error);
        }

        // -> Finaliza Boundary
        public void finCU()
        {
            ventanaAltaTurno.Close();
            ventanaRegistrarTurno.Close();
        }

        // --> Getters&Setters
        public string obtenerMailCientifico()
        {
            return cientificoLogueado.getMail();

        }
    }
}
