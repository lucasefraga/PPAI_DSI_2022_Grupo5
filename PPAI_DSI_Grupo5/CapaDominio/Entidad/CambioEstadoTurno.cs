using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class CambioEstadoTurno
    {
        //Atributos privados
        private DateTime fechaHoraDesde { get; set; }
        private DateTime fechaHoraHasta { get; set; }
        private Estado estado { get; set; }

        //Get and Set publicos
        public DateTime FechaHoraDesde
        {
            get { return fechaHoraDesde; }
            set { fechaHoraDesde = value; }
        }
        public DateTime FechaHoraHasta
        {
            get { return fechaHoraHasta; }
            set { fechaHoraHasta = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //Generador
        public CambioEstadoTurno(DateTime fechaHoraDesde, DateTime fechaHoraHasta, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
        }

        //Si no tiene fecha de fin el estado es actual
        public bool esActual()
        {
            if (fechaHoraHasta == null)
                return true;
            else
                return false;
        }
    }
}
