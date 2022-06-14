using PPAI_DSI_Grupo5.Presentacion.ABM_Turno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_Grupo5.Presentacion.Transacciones
{
    public partial class RegistrarTurno : Form
    {
        public RegistrarTurno()
        {
            InitializeComponent();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            AltaTurno ventana = new AltaTurno();
            ventana.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar reserva de truno", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
