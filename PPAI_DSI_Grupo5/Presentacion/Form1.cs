using PPAI_DSI_Grupo5.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI_Grupo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private GestorReservaDeTurno gestor { get; set; }

        

        public void test()
        {
            gestor = new GestorReservaDeTurno();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test();

            gestor.obtenerTipoRecursoTecnologico();
            gestor.tomarSeleccionTipoRecursoTecnologico();
            gestor.obtenerRecursoTecnologico();
            gestor.buscarRTPorTipoRTValido();
        }
    }
}
