using System;
using System.Collections.Generic;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class CambioEstadoRT
    {

        private DateTime fechaHoraDesde { get; set; }
        private DateTime fechaHoraHasta { get; set; }
        private Estado estado { get; set; }

        public CambioEstadoRT(DateTime fechaHoraDesde, DateTime fechaHoraHasta, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
        }

        public override bool Equals(object obj)
        {
            return obj is CambioEstadoRT rT &&
                   fechaHoraDesde == rT.fechaHoraDesde &&
                   fechaHoraHasta == rT.fechaHoraHasta &&
                   EqualityComparer<Estado>.Default.Equals(estado, rT.estado);
        }

        public bool esActual()
        {
            return true;//falta hacer, porque no entiendo que hacer realmente
        }

        public bool esReservable()
        {
            
            return this.estado.getEsReservable();
        }

        public string getNombreEstado()
        {
            return estado.getNombre();
        }
    }
}