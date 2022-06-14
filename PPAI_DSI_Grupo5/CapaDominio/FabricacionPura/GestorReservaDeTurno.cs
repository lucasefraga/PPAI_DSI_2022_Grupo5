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

namespace PPAI_DSI_Grupo5.CapaDominio.FabricacionPura
{
    internal class GestorReservaDeTurno
    {
        
        private List<TipoRecursoTecnologico> listaTipoRTDisponibles { get; set; } //Todos los TipoRecurso Disponibles
        private TipoRecursoTecnologico tipoRecursoTecnologicoSeleccionado { get; set; } //TipoRecurso Seleccionado por Cientifico   
        private List<RecursoTecnologico> listaRecursosTecnologicosValidos { get; set; } //Lista de RecursosTecnologicos correspondientes al TipoRecurso seleccionado
        private List<RecursoTecnologicoMuestra> listaRecursosMuestra { get; set; } //Lista con datos necesarios a mostrar de los RecursosTecnologicos
        private RecursoTecnologico recursoTecnologicoSeleccionado { get; set;} //RecursoTecnologico seleccionado por el Cientifico

        private Sesion sesionActual = CapaDatos.MainDeDatos.getSesionActual(); // Sesion del Cientifico actual
        private PersonalCientifico cientificoLogueado { get; set; } //Personal Cientifico Logeado

        private bool esCientificodelCentro = false;



        List<RecursoTecnologico> listaRecursoTecnologicosDisponibles = CapaDatos.MainDeDatos.crearRecursoTecnologico(); //Busca Los RecursosTecnologicos


        public void obtenerTipoRecursoTecnologico()
        {
            listaTipoRTDisponibles = CapaDatos.MainDeDatos.crearTipoRecursoTecnologico(); //Busca Los Recursos Tecnologicos Disponibles
        }

        public void tomarSeleccionTipoRecursoTecnologico(TipoRecursoTecnologico tipoRecursoSeleccionado)
        {
            //falta la implamentacion de este metodo
            tipoRecursoTecnologicoSeleccionado = listaTipoRTDisponibles[0]; //simplemente para testear
        }

        public void buscarRTPorTipoRTValido()
        {
            
            
            listaRecursosTecnologicosValidos = new List<RecursoTecnologico>();
            
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
            listaRecursosMuestra = new List<RecursoTecnologicoMuestra>();

            foreach (RecursoTecnologico recurso in listaRecursosTecnologicosValidos) //Crea objetos con los datos a mostrar
            {
                listaRecursosMuestra.Add(recurso.buscarDatosAMostrar());
            }
        }

        public void tomarSeleccionRTAUtilizar(RecursoTecnologicoMuestra recursoTecnologicoSelecc)
        {

            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.getNumeroRT() == recursoTecnologicoSelecc.getNumetoInventario())
                {
                    recursoTecnologicoSeleccionado = recurso;
                }
            }
            //recursoTecnologicoSeleccionado = listaRecursosTecnologicosValidos[0];
            
        }

        public void verificarCIDelUsuario()
        {
            cientificoLogueado = sesionActual.obtenerCientificoLogueado();

            esCientificodelCentro = recursoTecnologicoSeleccionado.esCientificoDeMiCentro(cientificoLogueado);
        }

        public void obtenerTurnos()
        {
            //Falta implementar 'rtseleccionado.obtenerTurnos()'
        }
        // ver si  va el static





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
