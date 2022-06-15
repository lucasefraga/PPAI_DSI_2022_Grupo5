using PPAI_DSI_Grupo5.CapaDominio.Entidad;
using PPAI_DSI_Grupo5.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
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

        public List<TipoRecursoTecnologico> listaTipoRTDisponibles { get; set; } //Todos los TipoRecurso Disponibles
        public TipoRecursoTecnologico tipoRecursoTecnologicoSeleccionado { get; set; } //TipoRecurso Seleccionado por Cientifico   
        public List<RecursoTecnologico> listaRecursosTecnologicosValidos { get; set; } //Lista de RecursosTecnologicos correspondientes al TipoRecurso seleccionado
        public List<RecursoTecnologicoMuestra> listaRecursosMuestra { get; set; } //Lista con datos necesarios a mostrar de los RecursosTecnologicos
        public RecursoTecnologico recursoTecnologicoSeleccionado { get; set; } //RecursoTecnologico seleccionado por el Cientifico
        public List<Estado> listaEstados { get; set; }


        internal void tomarConfirmacionReserva(DataGridViewRow dataGridViewRow)
        {
            foreach (var estado in listaEstados)
            {
                if (estado.esAmbitoTurno())
                {
                    if (estado.EsReservado())
                    {
                        recursoTecnologicoSeleccionado.reservarTurno(turnoSeleccionado, estado, cientificoLogueado);
                    }
                }
            }
        }

        public Sesion sesionActual; // Sesion del Cientifico actual

        public Dictionary<string, List<TurnoModel>> turnosOrdenados;
        public PersonalCientifico cientificoLogueado { get; set; } //Personal Cientifico Logeado
        public Turno turnoSeleccionado { get; set; }

        List<RecursoTecnologico> listaRecursoTecnologicosDisponibles = CapaDatos.MainDeDatos.crearRecursoTecnologico(); //Busca Los RecursosTecnologicos
        private RegistrarTurno ventanaRegistrarTurno;
        private AltaTurno ventanaAltaTurno;
        private List<Turno> listaTurnosRTSeleccionado;

        public GestorReservaDeTurno(RegistrarTurno registrarTurno, AltaTurno ventana, Sesion sesion)
        {
            this.ventanaRegistrarTurno = registrarTurno;
            this.ventanaAltaTurno = ventana;
            this.sesionActual = sesion;
            ventana.setGestor(this);
            obtenerTipoRecursoTecnologico();
            listaEstados = MainDeDatos.crearEstados();
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


        public void obtenerTipoRecursoTecnologico()
        {
            listaTipoRTDisponibles = CapaDatos.MainDeDatos.crearTipoRecursoTecnologico(); //Busca Los Recursos Tecnologicos Disponibles
        }

        internal void tomarSeleccionTurno(DataGridViewRow dataGridViewRow)
        {
            foreach (var turnoDisponible in listaTurnosRTSeleccionado)
            {
                string fecha = dataGridViewRow.Cells[0].Value.ToString();
                string horaInicio = dataGridViewRow.Cells[1].Value.ToString();
                string horaFin = dataGridViewRow.Cells[2].Value.ToString();
                string estado = dataGridViewRow.Cells[3].Value.ToString();

                TurnoModel comparable = turnoDisponible.mostrarTurnos();

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

        public void tomarSeleccionTipoRecursoTecnologico(string tipoRecursoSeleccionado)
        {
            buscarRTPorTipoRTValido(tipoRecursoSeleccionado);

            tipoRecursoTecnologicoSeleccionado = listaTipoRTDisponibles[0]; //simplemente para testear
        }

        public void buscarRTPorTipoRTValido(string tipoRecursoSeleccionado)
        {

            listaRecursosTecnologicosValidos = new List<RecursoTecnologico>();

            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.esTipoRecursoSeleccinado(tipoRecursoSeleccionado))
                {
                    if (recurso.esReservable())
                    {
                        listaRecursosTecnologicosValidos.Add(recurso);
                    }
                }

            }

            listaRecursosMuestra = new List<RecursoTecnologicoMuestra>();

            foreach (RecursoTecnologico recurso in listaRecursosTecnologicosValidos) //Crea objetos con los datos a mostrar
            {
                listaRecursosMuestra.Add(recurso.buscarDatosAMostrar());
            }

            agruparRTPorCentroInvestigacion();
            asignarColorPorEstadoDeRT();

            ventanaRegistrarTurno.MostrarYSolicitarRTAUtilizar(listaRecursosMuestra);
        }

        public void agruparRTPorCentroInvestigacion()
        {
            listaRecursosMuestra.OrderBy(x => x.getCentroInvestigacion());   //Maybe funciona, no estoy seguro. Lo q hace es ordenarlos por CI, en la lista.
                                                                             //Supongo que a la hora de mostrarlos va a servir 
        }

        public void asignarColorPorEstadoDeRT() //Hay que ver si esta es la mejor forma, lo dudo
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
                        recurso.setColor(0);//No color Blanco
                        break;
                }
            }
        }

        public void tomarSeleccionRTAUtilizar(int numeroRT)
        {

            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.getNumeroRT() == numeroRT)
                {
                    recursoTecnologicoSeleccionado = recurso;
                }
            }

            listaTurnosRTSeleccionado = recursoTecnologicoSeleccionado.obtenerTurnos(verificarCIDelUsuario());

            turnosOrdenados = ordenarYAgruparTurnos();

            Dictionary<string, bool> disponibilidadAMostrar = determinarDisponibilidadTurnos();

            ventanaAltaTurno.MostrarYSolicitarSeleccionTurnos(disponibilidadAMostrar);
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
                TurnoModel turnoAMostrar = turno.mostrarTurnos();

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
                foreach (var turno in turnosOrdenados[entry])
                {
                    if (turno.getEstado() == "Disponible")
                    {
                        disponibilidad.Add(entry, true);
                        break;
                    }

                    disponibilidad.Add(entry, false);
                }

            }
            return disponibilidad;
        }

        public void registrarReserva()
        {
            List<Estado> listaEstadosDisponibles = CapaDatos.MainDeDatos.crearEstados();

            foreach (Estado estado in listaEstadosDisponibles)
            {
                if (estado.Ambito == "Turno" && estado.Nombre == "Reservado")
                {
                    recursoTecnologicoSeleccionado.reservarTurno(turnoSeleccionado, estado, cientificoLogueado);
                }
                break;
            }
        }

        // ver si  va el static
        //No, no va el static, despues hay q corregir un par de cosas de los metodos de los Form, porque al ser statc estos metodos de afectaron ahi
        public static string obtenerMailCientifico()
        {
            string mailCient = "";
            //falta implementar
            return mailCient;
        }

        public static void EnviarMail(StringBuilder Mensaje, string Recurso, string Fecha, out string Error)
        {
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("Recurso reservado: ", Recurso, "Fecha Reserva: {0:dd/MM/yyyy}", Fecha, "Horario: {0:HH:mm:ss} Hrs", Fecha));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("SecretariaCienciaYTecnica@gmail.com");
                string para = obtenerMailCientifico();
                mail.To.Add(para);
                mail.Subject = "Confirmación de Reserva de Turno";
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("SecretariaCienciaYTecnica@gmail.com", "DSI2022TPI");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Éxito";
                MessageBox.Show(Error);


            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }
        }

        // cada 24hs se inhabilita whatsapp
        public static void EnviarWP(StringBuilder MensajeWP, string NomRecurso, string FechaTurno, out string InfoError)
        {
            InfoError = "";
            try
            {
                MensajeWP.Append(Environment.NewLine);
                MensajeWP.Append(string.Format("Recurso reservado: ", NomRecurso, "Fecha Reserva: {0:dd/MM/yyyy}", FechaTurno, "Horario: {0:HH:mm:ss} Hrs", FechaTurno));
                MensajeWP.Append(Environment.NewLine);
                var accountSid = "AC8418c64ec3f6446ede7c9a33fb0cd6ba";
                var authToken = "[AuthToken]";
                TwilioClient.Init(accountSid, authToken);

                var messageOptions = new CreateMessageOptions(
                    new PhoneNumber("whatsapp:+5493516216060"));
                messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
                messageOptions.Body = MensajeWP.ToString();
                //messageOptions.Body = "Recurso reservado: "+ NomRecurso+ "Fecha Reserva: {0:dd/MM/yyyy}" + FechaTurno + "Horario: {0:HH:mm:ss} Hrs" + FechaTurno;

                var message = MessageResource.Create(messageOptions);
                Console.WriteLine(message.Body);
                InfoError = "Éxito";
                MessageBox.Show(InfoError);
            }
            catch (Exception ex)
            {
                InfoError = "Error: " + ex.Message;
                MessageBox.Show(InfoError);
                return;
            }

        }
    }
}
