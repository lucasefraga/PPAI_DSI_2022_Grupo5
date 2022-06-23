using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class CambioEstadoTurno
    {
        //ATRIBUTOS
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;
        private Estado estado;

        //METODOS

        // --> Metodo Constructor
        public CambioEstadoTurno(DateTime fechaHoraDesde, DateTime fechaHoraHasta, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
        }

        // --> Metodo Constructor sin incluir fechaHoraHasta, toma default
        public CambioEstadoTurno(DateTime fechaHoraDesde, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.estado = estado;
        }


        // Corroboracion si es actual
        public bool esActual()
        {
            // Si se instancia sin generar fechaHoraHasta toma por default minValue
            if (fechaHoraHasta.ToShortDateString() == "1/1/0001")
                return true;
            else
                return false;
        }


        // --> Getters&Setters
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
    }
}
