using System;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class Turno
    {
        private DateTime fechaGeneracion { get; set; }

        private DayOfWeek diaSemana { get; set; }

        private DateTime fechaHoraInicio { get; set; }

        private DateTime fechaHoraFin { get; set;}


        public DateTime fechaInicio { get; set; }
    }

}