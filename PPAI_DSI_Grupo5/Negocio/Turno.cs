using System;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class Turno
    {
        private DateTime fechaGeneracion { get; set; }

        private DayOfWeek diaSemana { get; set; }

        private DateTime fechaHoraInicio { get; set; }

        private DateTime fechaHoraFin { get; set;}


        public DateTime FechaHoraInicio 
        {
            get { return fechaHoraInicio; }
            set { fechaHoraInicio = value; }
        }

        public Turno(DateTime fechaGeneracion, DayOfWeek diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
        }
    }

}