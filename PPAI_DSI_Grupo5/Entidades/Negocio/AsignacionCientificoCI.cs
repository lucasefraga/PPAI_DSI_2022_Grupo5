using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class AsignacionCientificoCI
    {
        private DateTime fechaDesde { get; set; }
        private DateTime fechaHasta { get; set; }
        private PersonalCientifico personalCientifico { get; set; }
        private List<Turno> turnos { get; set; }

        public AsignacionCientificoCI(DateTime fechaDesde, DateTime fechaHasta, PersonalCientifico personalCientifico)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.personalCientifico = personalCientifico;
        }

        public AsignacionCientificoCI(DateTime fechaDesde, DateTime fechaHasta, PersonalCientifico personalCientifico, List<Turno> turnos) : this(fechaDesde, fechaHasta, personalCientifico)
        {
            this.turnos = turnos;
        }

        public bool esActivo(PersonalCientifico cientifico)
        {
            if (personalCientifico.Equals(cientifico))
            {
                return true;
            }
            return false;
        }



        public PersonalCientifico getPersonalCientifico()
        {
            return personalCientifico;
        }

        public override bool Equals(object obj)
        {
            return obj is AsignacionCientificoCI cI &&
                   fechaDesde == cI.fechaDesde &&
                   fechaHasta == cI.fechaHasta &&
                   EqualityComparer<PersonalCientifico>.Default.Equals(personalCientifico, cI.personalCientifico) &&
                   EqualityComparer<List<Turno>>.Default.Equals(turnos, cI.turnos);
        }
        public string ObtenerMail()
        {
           // return PersonalCientifico.GetCorreoPersonal().ToString();
        }
    }
}
