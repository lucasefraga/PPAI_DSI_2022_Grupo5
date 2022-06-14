using PPAI_DSI_Grupo5.Presentacion.Transacciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_Grupo5.Presentacion.Menú
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void reservarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarTurno ventana = new RegistrarTurno();
            ventana.ShowDialog();
        }
    }
}
