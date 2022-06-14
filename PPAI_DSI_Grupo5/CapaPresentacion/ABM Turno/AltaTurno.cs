using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_Grupo5.Presentacion.ABM_Turno
{
    public partial class AltaTurno : Form
    {
        public AltaTurno()
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
            if (checkBoxEmail.Checked)
                Negocio.GestorReservaDeTurno.EnviarMail(MensajeBuilder, txtRecurso.Text.Trim(), txtFecha.Text.Trim(), out Error);
            if (checkBoxWP.Checked)
                Negocio.GestorReservaDeTurno.EnviarWP(MensajeBuilder, txtRecurso.Text.Trim(), txtFecha.Text.Trim(), out Error);
        }
    }
}
