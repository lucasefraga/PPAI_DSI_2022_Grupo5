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
        private GestorReservaDeTurno gestor;

        internal AltaTurno()
        {
            InitializeComponent();
        }

        internal void setGestor(GestorReservaDeTurno gestor) { this.gestor = gestor; }

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
            gestor.tomarConfirmacionReserva(dgvTurnos.CurrentRow);
            string Error = "";
            StringBuilder MensajeBuilder = new StringBuilder();
            string Message = "Su turno ha sido correctamente reservado";
            MensajeBuilder.Append(Message);
            if (checkBoxEmail.Checked)
                CapaDominio.FabricacionPura.GestorReservaDeTurno.EnviarMail(MensajeBuilder, txtRecurso.Text.Trim(), calendario.SelectedDates[0].ToString().Trim(), out Error);
            if (checkBoxWP.Checked)
                CapaDominio.FabricacionPura.GestorReservaDeTurno.EnviarWP(MensajeBuilder, txtRecurso.Text.Trim(), calendario.SelectedDates[0].ToString().Trim(), out Error);

            MessageBox.Show("Reserva efectuada exitosamente!", "Notificacion enviada.", MessageBoxButtons.OK);

            gestor.finCU();
        }

        internal void MostrarYSolicitarSeleccionTurnos(Dictionary<string, bool> disponibilidadAMostrar)
        {
            foreach (var dia in disponibilidadAMostrar)
            {
                DateItem item = new DateItem();
                if (dia.Value)
                {
                    item.Date = DateTime.Parse(dia.Key);
                    item.BackColor1 = Color.Green;
                    calendario.AddDateInfo(item);
                }
                else
                {
                    item.Date = DateTime.Parse(dia.Key);
                    item.BackColor1 = Color.Red;
                    calendario.AddDateInfo(item);
                }
            }
        }

        private void calendar_DayClick(object sender, DayClickEventArgs e)
        {
            dgvTurnos.Rows.Clear();

            if (calendario.SelectedDates.Count > 0)
            {
                DateTime date = calendario.SelectedDates[0].Date;
                gestor.tomarSeleccionDia(date);
            }
        }

        internal void mostrarDiaSeleccionado(List<TurnoModel> turnoModels)
        {
            foreach (var turno in turnoModels)
            {
                dgvTurnos.Rows.Add(turno.getFechaInicio().ToShortDateString(), turno.getFechaInicio().ToShortTimeString(), turno.getFechaFin().ToShortTimeString(), turno.getEstado());
            }
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gestor.tomarSeleccionTurno(dgvTurnos.CurrentRow);
        }
    }
}
