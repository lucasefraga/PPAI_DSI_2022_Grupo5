using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class AsignacionDirectorCI
    {
        //ATRIBUTOS
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private PersonalCientifico personalCientifico;

        //METODOS

        // --> Metodo Constructor
        public AsignacionDirectorCI(DateTime fechaDesde, DateTime fechaHasta, PersonalCientifico personalCientifico)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.personalCientifico = personalCientifico;
        }
    }
}
