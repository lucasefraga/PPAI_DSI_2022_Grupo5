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
    internal class InterfazEmailReserva
    {
        public InterfazEmailReserva()
        {

        }

        public void enviarMail(StringBuilder Mensaje, string emailPara, string NombreRecurso, string FechaReserva, out string Error)
        {
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("Recurso reservado: ", NombreRecurso, "Fecha Reserva: {0:dd/MM/yyyy}", FechaReserva, "Horario: {0:HH:mm:ss} Hrs", FechaReserva));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("SecretariaCienciaYTecnica@gmail.com");
                string para = emailPara;
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

        //public void EnviarWP(StringBuilder MensajeWP, string NomRecurso, string FechaTurno, out string InfoError)
        //{
        //    InfoError = "";
        //    try
        //    {
        //        MensajeWP.Append(Environment.NewLine);
        //        MensajeWP.Append(string.Format("Recurso reservado: ", NomRecurso, "Fecha Reserva: {0:dd/MM/yyyy}", FechaTurno, "Horario: {0:HH:mm:ss} Hrs", FechaTurno));
        //        MensajeWP.Append(Environment.NewLine);
        //        var accountSid = "AC8418c64ec3f6446ede7c9a33fb0cd6ba";
        //        var authToken = "[AuthToken]";
        //        TwilioClient.Init(accountSid, authToken);

        //        var messageOptions = new CreateMessageOptions(
        //            new PhoneNumber("whatsapp:+5493516216060"));
        //        messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
        //        messageOptions.Body = MensajeWP.ToString();
        //        //messageOptions.Body = "Recurso reservado: "+ NomRecurso+ "Fecha Reserva: {0:dd/MM/yyyy}" + FechaTurno + "Horario: {0:HH:mm:ss} Hrs" + FechaTurno;

        //        var message = MessageResource.Create(messageOptions);
        //        Console.WriteLine(message.Body);
        //        InfoError = "Éxito";
        //        MessageBox.Show(InfoError);
        //    }
        //    catch (Exception ex)
        //    {
        //        InfoError = "Error: " + ex.Message;
        //        MessageBox.Show(InfoError);
        //        return;
        //    }

        }
    }
}
