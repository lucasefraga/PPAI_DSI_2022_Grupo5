using System;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class Sesion
    {
        //ATRIBUTOS
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private Usuario usuarioActual;

        //METODOS

        // --> Metodo Constructor
        public Sesion(DateTime fechaFin, DateTime fechaInicio, Usuario usuarioActual)
        {
            this.fechaFin = fechaFin;
            this.fechaInicio = fechaInicio;
            this.usuarioActual = usuarioActual;
        }

        //--> Obtener el cientifico logueado
        public PersonalCientifico obtenerCientificoLogueado() { return usuarioActual.getPersonalCientifico(); }
    }
}
