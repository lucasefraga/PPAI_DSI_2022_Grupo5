using System;
using System.Collections.Generic;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
#pragma warning disable CS0659 // 'CambioEstadoRT' invalida Object.Equals(object o) pero no invalida Object.GetHashCode()
    internal class CambioEstadoRT
#pragma warning restore CS0659 // 'CambioEstadoRT' invalida Object.Equals(object o) pero no invalida Object.GetHashCode()
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
            if (this.fechaHoraDesde < DateTime.Now && DateTime.Now < this.fechaHoraHasta)
            {
                return true;
            }
            return false;
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