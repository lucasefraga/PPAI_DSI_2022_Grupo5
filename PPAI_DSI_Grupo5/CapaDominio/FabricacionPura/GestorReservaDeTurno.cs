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
    internal class GestorReservaDeTurno
    {

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

        public void nuevaReservaTurno()
        {
            List<string> lista = obtenerRT();
            ventanaRegistrarTurno.mostrarYSolicitarSeleccionTipoRT(lista);
        }

        public List<string> obtenerRT()
        {
            List<string> lista = new List<string>();
            foreach (var rt in listaTipoRTDisponibles)
            {
                lista.Add(rt.getNombre());
            }

            return lista;
        }

        internal void finCU()
        {
            ventanaAltaTurno.Close();
            ventanaRegistrarTurno.Close();
        }

        public void tomarSeleccionTipoRecursoTecnologico(string tipoRecursoSeleccionado)
        {
            buscarRTPorTipoRTValido(tipoRecursoSeleccionado);
        }

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
                listaRecursosMuestra.Add(recurso.buscarDatosAMostrar(LoadData.loadMarcas()));
            }

            agruparRTPorCentroInvestigacion();
            asignarColorPorEstadoDeRT();

            ventanaRegistrarTurno.MostrarYSolicitarRTAUtilizar(listaRecursosMuestra);
        }

        public void agruparRTPorCentroInvestigacion()
        {
            listaRecursosMuestra.OrderBy(x => x.getCentroInvestigacion());   
        }

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

        public void tomarSeleccionRTAUtilizar(DataGridViewRow dataGridViewRow)
        {

            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.getNumeroRT() == (int)dataGridViewRow.Cells[0].Value)
                {
                    recursoTecnologicoSeleccionado = recurso;
                }
            }

            listaTurnosRTSeleccionado = recursoTecnologicoSeleccionado.obtenerTurnos(verificarCIDelUsuario());

            turnosOrdenados = ordenarYAgruparTurnos();

            Dictionary<string, bool> disponibilidadAMostrar = determinarDisponibilidadTurnos();

            ventanaAltaTurno.MostrarYSolicitarSeleccionTurnos(disponibilidadAMostrar, recursoTecnologicoSeleccionado);
        }

        public bool verificarCIDelUsuario()
        {
            cientificoLogueado = sesionActual.obtenerCientificoLogueado();

            return recursoTecnologicoSeleccionado.esCientificoDeMiCentro(cientificoLogueado);
        }

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

        internal void tomarSeleccionTurno(DataGridViewRow dataGridViewRow)
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

        internal void tomarSeleccionDia(DateTime date)
        {
            string dateFormatted = date.ToShortDateString();
            if (turnosOrdenados.ContainsKey(dateFormatted))
            {
                ventanaAltaTurno.mostrarDiaSeleccionado(turnosOrdenados[dateFormatted]);
            }
        }

        internal void tomarConfirmacionReserva(DataGridViewRow dataGridViewRow)
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

        
        internal string obtenerMailCientifico()
        {          
            return cientificoLogueado.getCorreoPersonal();
            
        }

        internal void EnviarMail(StringBuilder mensaje, string recurso, string fechaTurno)
        {
            interfazNotificacion = new InterfazEmailReserva();
            string email = obtenerMailCientifico();
            string error = "Gmail: acceso denegado.";
            interfazNotificacion.EnviarMail( mensaje, email,  recurso, fechaTurno, out error);
        }

    }
}
