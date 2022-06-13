using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class Sesion
    {
        private DateTime fechaFin { get; set; }
        private DateTime fechaInicio { get; set; }
        private Usuario usuarioActual { get; set; }

        public Sesion(DateTime fechaFin, DateTime fechaInicio, Usuario usuarioActual)
        {
            this.fechaFin = fechaFin;
            this.fechaInicio = fechaInicio;
            this.usuarioActual = usuarioActual;
        }

        public Usuario getNombreUsuario()
        {
            return this.usuarioActual.getUsuario();
        }

        public PersonalCientifico obtenerCientificoLogueado()
        {
            return usuarioActual.GetPersonalCientifico();
        }
    }
}
