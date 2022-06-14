using System;
using System.Collections.Generic;
namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class Turno
    {
        private DateTime fechaGeneracion { get; set; }
        private DayOfWeek diaSemana { get; set; }
        private DateTime fechaHoraInicio { get; set; }
        private DateTime fechaHoraFin { get; set; }
        private List<CambioEstadoTurno> cambioEstadoTurno { get; set; }

        public DateTime FechaGeneracion
        {
            get { return fechaGeneracion; }
            set { fechaGeneracion = value; }
        }
        public DateTime FechaHoraInicio
        {
            get { return fechaHoraInicio; }
            set { fechaHoraInicio = value; }
        }
        public DayOfWeek DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }
        public DateTime FechaHoraFin
        {
            get { return fechaHoraFin; }
            set { fechaHoraFin = value; }
        }
        //public CambioEstadoTurno CambioEstadoTurno
        //{
            // Sin implementar
        //}

        public Turno(DateTime fechaGeneracion, DayOfWeek diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin, List<CambioEstadoTurno> cambioEstadoTurno)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.cambioEstadoTurno = cambioEstadoTurno;
        }

        public bool validarFechaHoraInicio()
        {
            //Simple validacion si la fechaInicio del turno es posterior a la fecha actual
            if (DateTime.Compare(this.fechaHoraInicio, DateTime.Now) > 0)
                return true;
            else
                return false;

        }
        public (DateTime, DateTime, string) mostrarTurnos()
        {
            //Busca el actual, retorna lo pedido
            foreach (CambioEstadoTurno cambioEstadoTurno in this.cambioEstadoTurno)
                if (cambioEstadoTurno.esActual())
                    return (fechaHoraInicio, fechaHoraFin, cambioEstadoTurno.mostrarNombreEstado());

            throw new Exception("Error");

        }

    }

}