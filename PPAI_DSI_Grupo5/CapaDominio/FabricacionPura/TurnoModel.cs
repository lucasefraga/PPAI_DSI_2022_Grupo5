using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.FabricacionPura
{
    // Clase de fabricacion pura para los datos necesarios al obtener los Turnos
    public class TurnoModel
    {
        //ATRIBUTOS
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private string estado;

        //METODOS

        // --> Metodo Constructor
        public TurnoModel(DateTime fechaHoraInicio, DateTime fechaHoraFin, string v)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.estado = v;
        }

        //Getters&Setters
        public DateTime getFechaInicio() { return fechaHoraInicio; }
        public DateTime getFechaFin() { return fechaHoraFin; }
        public string getEstado() { return estado; }
    }
}
