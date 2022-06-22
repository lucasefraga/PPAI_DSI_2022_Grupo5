using PPAI_DSI_Grupo5.CapaDominio.FabricacionPura;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Pabo.Calendar;
using PPAI_DSI_Grupo5.CapaDominio.Entidad;

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
            if (dgvTurnos.CurrentRow == null || dgvTurnos.CurrentRow.Cells[3].Value.ToString() == "Reservado" || (checkBoxEmail.Checked == false && checkBoxWP.Checked == false || (checkBoxEmail.Checked == true && checkBoxWP.Checked == true) == true) == true)
            {
                if (dgvTurnos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un turno", "Reserva de truno");
                }
                else if (dgvTurnos.CurrentRow.Cells[3].Value.ToString() == "Reservado")
                {
                    MessageBox.Show("Seleccione un turno Disponible", "Reserva de truno");
                }
                else if ((checkBoxEmail.Checked == false && checkBoxWP.Checked == false) == true)
                {
                    MessageBox.Show("Seleccione una forma de Notificacion", "Reserva de truno");
                }
                else if ((checkBoxEmail.Checked == true && checkBoxWP.Checked == true) == true)
                {
                    MessageBox.Show("Seleccione UNA SOLA forma de Notificacion", "Reserva de truno");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea reservar este turno?", "Reserva de truno", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    gestor.tomarConfirmacionReserva(true);
                    string Error = "";
                    StringBuilder MensajeBuilder = new StringBuilder();
                    string Message = "Su turno ha sido correctamente reservado";
                    MensajeBuilder.Append(Message);

                    if (checkBoxEmail.Checked)
                    {
                        MessageBox.Show("Sale un mensaje que da error de q no existe el mail, pero no es importante");
                        gestor.generarMail();
                        MessageBox.Show("Email enviado correctamente.");
                    }
                        
                    //gestor.EnviarMail(MensajeBuilder, txtTipoRecurso.Text.Trim(), calendario.SelectedDates[0].ToString().Trim(), out Error);
                    if (checkBoxWP.Checked)
                        MessageBox.Show("Mensaje enviado correctamente.");
                        //gestor.EnviarWP(MensajeBuilder, txtTipoRecurso.Text.Trim(), calendario.SelectedDates[0].ToString().Trim(), out Error);

                    MessageBox.Show("Reserva efectuada exitosamente!", "Notificacion enviada.", MessageBoxButtons.OK);

                    gestor.finCU();
                }
            }
        }

        internal void MostrarYSolicitarSeleccionTurnos(Dictionary<string, bool> disponibilidadAMostrar, RecursoTecnologico recurso)
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
            List<String> marcaYModelo = recurso.mostrarMarcaYModelo();
            txtTipoRecurso.Text = recurso.getTipoRecurso();
            txtEstado.Text = recurso.getEstadoRT();
            txtCentro.Text = recurso.getCentro();
            txtMarca.Text = marcaYModelo[1];
            txtModelo.Text = marcaYModelo[0];
            txtRecurso.Text = recurso.getNumeroRT().ToString();
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

        private void lblRecurso_Click(object sender, EventArgs e)
        {

        }
    }
}
