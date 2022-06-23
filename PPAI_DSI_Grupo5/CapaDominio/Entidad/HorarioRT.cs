using System;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class HorarioRT
    {
        //ATRIBUTOS
        private int diaSemana;
        private DateTime horaDesde;
        private DateTime horaHasta;
        private DateTime vigenciaDesde;
        private DateTime vigenciaHasta;

        //METODOS

        // --> Metodo Constructor
        public HorarioRT(int diaSemana, DateTime horaDesde, DateTime horaHasta, DateTime vigenciaDesde, DateTime vigenciaHasta)
        {
            this.diaSemana = diaSemana;
            this.horaDesde = horaDesde;
            this.horaHasta = horaHasta;
            this.vigenciaDesde = vigenciaDesde;
            this.vigenciaHasta = vigenciaHasta;
        }
    }
}