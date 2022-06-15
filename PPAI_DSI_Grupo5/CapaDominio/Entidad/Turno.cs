using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI_Grupo5.CapaDominio.FabricacionPura;
namespace PPAI_DSI_Grupo5.CapaDominio.Entidad


{
    internal class Turno
    {
        //Atributos privados
        private DateTime fechaGeneracion { get; set; }
        private DayOfWeek diaSemana { get; set; }
        private DateTime fechaHoraInicio { get; set; }
        private DateTime fechaHoraFin { get; set; }
        private List<CambioEstadoTurno> cambioEstadoTurno { get; set; }

        //Set and Get publicos
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

        //Generador
        public Turno(DateTime fechaGeneracion, DayOfWeek diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin, List<CambioEstadoTurno> cambioEstadoTurno)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.cambioEstadoTurno = cambioEstadoTurno;
        }

        public Turno(DateTime fechaGeneracion, DayOfWeek diaSemana, DateTime fechaHoraInicio, List<CambioEstadoTurno> cambioEstadoTurno)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.cambioEstadoTurno = cambioEstadoTurno;
        }



        //Simple validacion si la fechaInicio del turno es posterior a la fecha actual
        public bool validarFechaHoraInicio(DateTime timeInicio)
        {
            if (this.fechaHoraInicio.ToShortDateString() == timeInicio.ToShortDateString())
                return true;
            else
                return false;

            
        }

        public TurnoModel mostrarTurnos()
        {
            //Busca el actual, retorna lo pedido
            foreach (var cambioEstado in cambioEstadoTurno)
                if (cambioEstado.esActual())
                    return new TurnoModel(fechaHoraInicio, fechaHoraFin, cambioEstado.Estado.getNombre());

            return null;
        }

        public void reservar(Estado est)
        {
            cambioEstadoTurno = CapaDatos.MainDeDatos.crearCambioEstadoTurnos();
            
            cambioEstadoTurno.Last().FechaHoraHasta = DateTime.Now;

            var nuevoCambioEstado = new CambioEstadoTurno(this.fechaHoraInicio, est);

            cambioEstadoTurno.Add(nuevoCambioEstado);

        }



    }

}