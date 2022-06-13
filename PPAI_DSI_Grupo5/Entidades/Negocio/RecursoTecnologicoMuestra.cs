using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class RecursoTecnologicoMuestra
    {
        private CentroDeInvestigacion CentroDeInvestigacion { get; set; }
        public int numeroInventario { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string estado { get; set; }

        public RecursoTecnologicoMuestra(CentroDeInvestigacion centroDeInvestigacion, int numeroInventario, string marca, string modelo, string estado)
        {
            CentroDeInvestigacion = centroDeInvestigacion;
            this.numeroInventario = numeroInventario;
            this.marca = marca;
            this.modelo = modelo;
            this.estado = estado;
        }
    }
}
