using System;
namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class Mantenimiento
    {
        //ATRIBUTOS
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private DateTime fechaInicioPrevista;
        private string motivoMantenimiento;

        //METODOS

        // --> Metodo Constructor
        public Mantenimiento(DateTime fechaFin, DateTime fechaInicio, DateTime fechaInicioPrevista, string motivoMantenimiento)
        {
            this.fechaFin = fechaFin;
            this.fechaInicio = fechaInicio;
            this.fechaInicioPrevista = fechaInicioPrevista;
            this.motivoMantenimiento = motivoMantenimiento;
        }
    }
}