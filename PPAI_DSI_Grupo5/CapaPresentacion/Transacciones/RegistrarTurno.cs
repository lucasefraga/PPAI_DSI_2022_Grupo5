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
        private RecursoTecnologico recurso;
        private GestorReservaDeTurno gestor;

        public RegistrarTurno()
        {
            InitializeComponent();
        }
        private void RegistrarTurno_Load(object sender, EventArgs e)
        {
            RellenarCmb(gestor.obtenerTipoRecursoTecnologico(), " ");

           // cmbTipoRecurso.Items.Add("Todos");
            //cmbTipoRecurso.Items.Add("Microscopios");
            //cmbTipoRecurso.Items.Add("Balanzas de precisión");
            //cmbTipoRecurso.Items.Add("Resonadores magnéticos");
            //cmbTipoRecurso.Items.Add("Equip. de Cómputo de alto rendimiento");
            //cmbTipoRecurso.Items.Insert(0, "Seleccionar");
            //cmbTipoRecurso.SelectedIndex = 0;
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

        public void MostrarTarifasVigentes(List<List<string>> recursos, out string Error)
        {           
            Error = "";
            try
            {
     
               // lblTarifas.Visible = true;
                //dgrRecursos.Visible = true;
                //btnTomarTarifa.Visible = true;
                //btnTomarTarifa.Enabled = false;
                int rowNumber = 0;
                foreach (var recurso in recursos)
                {
                    dgrRecursos.Rows.Add();
                    dgrRecursos.Rows[rowNumber].Cells[0].Value = recurso[0];
                    dgrRecursos.Rows[rowNumber].Cells[2].Value = recurso[1];
                    dgrRecursos.Rows[rowNumber].Cells[1].Value = recurso[2];
                    dgrRecursos.Rows[rowNumber].Cells[3].Value = rowNumber;
                    rowNumber += 1;
                }

            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }           

        }

        //para despues
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //string cmbTipoRecurso = cmbTipoRecurso.GetItemText(cmbTipoRecurso.SelectedItem);

        public void RellenarCmb(List<List<string>> recursos, out string Error)
        {
            Error = "";
            try
            {
                // lblTarifas.Visible = true;
                //dgrRecursos.Visible = true;
                //btnTomarTarifa.Visible = true;
                //btnTomarTarifa.Enabled = false;
                //int rowNumber = 0;
                foreach (var recurso in recursos)
                {
                    cmbTipoRecurso.Items.Add(recurso);

                }
                cmbTipoRecurso.Items.Insert(0, "Seleccionar");
                cmbTipoRecurso.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }

        }
    }
}
