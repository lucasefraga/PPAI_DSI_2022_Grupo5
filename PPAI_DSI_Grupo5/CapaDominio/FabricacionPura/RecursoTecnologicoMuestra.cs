using PPAI_DSI_Grupo5.CapaDominio.Entidad;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.FabricacionPura
{
    internal class RecursoTecnologicoMuestra
    {
        private CentroDeInvestigacion centroDeInvestigacion { get; set; }
        private int numeroInventario { get; set; }
        private string marca { get; set; }
        private string modelo { get; set; }
        private string estado { get; set; }
        private int color { get; set; } //No esta programado, pero puede ser util

        public RecursoTecnologicoMuestra(CentroDeInvestigacion centroDeInv, int numeroInventario, string marca, string modelo, string estado)
        {
            centroDeInvestigacion = centroDeInv;
            this.numeroInventario = numeroInventario;
            this.marca = marca;
            this.modelo = modelo;
            this.estado = estado;
        }

        public void setColor(int nroColor)
        {
            this.color = nroColor;
        }

        public CentroDeInvestigacion getCentroInvestigacion()
        {
            return centroDeInvestigacion;
        }

        public string getEstado()
        {
            return estado;
        }
        public string getMarca()
        {
            return marca;
        }
        public string getModelo()
        {
            return modelo;
        }

        public int getNumetoInventario()
        {
            return numeroInventario;
        }
    }
}
