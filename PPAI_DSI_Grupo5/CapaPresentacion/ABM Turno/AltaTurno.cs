using PPAI_DSI_Grupo5.CapaDominio.FabricacionPura;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Pabo.Calendar;

namespace PPAI_DSI_Grupo5.Presentacion.ABM_Turno
{
    public partial class AltaTurno : Form
    {

        internal AltaTurno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar reserva de truno", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea reservar este turno?", "Reserva de truno", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                this.Close();
            }
            string Error = "";
            StringBuilder MensajeBuilder = new StringBuilder();
            string Message = "Su turno ha sido correctamente reservado";
            MensajeBuilder.Append(Message);
            //if (checkBoxEmail.Checked)
            //    CapaDominio.FabricacionPura.GestorReservaDeTurno.EnviarMail(MensajeBuilder, txtRecurso.Text.Trim(), txtFecha.Text.Trim(), out Error);
            //if (checkBoxWP.Checked)
            //    CapaDominio.FabricacionPura.GestorReservaDeTurno.EnviarWP(MensajeBuilder, txtRecurso.Text.Trim(), txtFecha.Text.Trim(), out Error);
        }

        internal void MostrarYSolicitarSeleccionTurnos(Dictionary<string, bool> disponibilidadAMostrar)
        {
            List<DateItem> lista = new List<DateItem>();
            foreach (var dia in disponibilidadAMostrar)
            {
                DateItem item = new DateItem();
                if (dia.Value)
                {
                    item.Date = DateTime.Parse(dia.Key);
                    item.BackColor1 = Color.Green;
                    lista.Add(item);
                }
                else
                {
                    item.Date = DateTime.Parse(dia.Key);
                    item.BackColor1 = Color.Red;
                    lista.Add(item);
                }
            }
            calendar.AddDateInfo(lista.ToArray());
        }
    }
}
