using PPAI_DSI_Grupo5.CapaDatos;
using PPAI_DSI_Grupo5.CapaDominio.Entidad;
using PPAI_DSI_Grupo5.CapaDominio.FabricacionPura;
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
        private GestorReservaDeTurno gestor;
        private AltaTurno ventana;
        public RegistrarTurno()
        {
            InitializeComponent();
            ventana = new AltaTurno();
            Sesion sesion = MainDeDatos.getSesionActual();
            gestor = new GestorReservaDeTurno(this, ventana, sesion);
            gestor.nuevaReservaTurno();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            int selected = (int)dgrRecursos.CurrentRow.Cells[0].Value;
            gestor.tomarSeleccionRTAUtilizar(selected);
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

        internal void mostrarYSolicitarSeleccionTipoRT(List<string> lista)
        {
            cmbTipoRecurso.Items.AddRange(lista.ToArray());
        }

        private void cmbTipoRecurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestor.tomarSeleccionTipoRecursoTecnologico(cmbTipoRecurso.SelectedItem.ToString());
        }

        internal void MostrarYSolicitarRTAUtilizar(List<RecursoTecnologicoMuestra> listaRecursosMuestra)
        {
            dgrRecursos.Rows.Clear();
            foreach (var recurso in listaRecursosMuestra)
            {
                dgrRecursos.Rows.Add(recurso.getNumetoInventario(), recurso.getCentroInvestigacion().getNombre(), recurso.getMarca(), recurso.getModelo(), recurso.getEstado());
            };
        }
    }
}
