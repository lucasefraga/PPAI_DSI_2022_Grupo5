using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class Facultad
    {
        private string nombre { get; set; }
        private string domicilio { get; set; }
        private PersonalCientifico responsableCyT { get; set; }
        private List<CentroDeInvestigacion> centrosDeInvestigacion { get; set; }

        public Facultad(string nombre, string domicilio, PersonalCientifico responsableCyT, List<CentroDeInvestigacion> centrosDeInvestigacion)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.responsableCyT = responsableCyT;
            this.centrosDeInvestigacion = centrosDeInvestigacion;
        }
    }
}
