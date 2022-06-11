using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class Usuario
    {
        private string clave { get; set; }
        private string nombreUsuario { get; set; }
        private bool habilitado { get; set; }

        public Usuario(string clave, string nombreUsuario, bool habilitado)
        {
            this.clave = clave;
            this.nombreUsuario = nombreUsuario;
            this.habilitado = habilitado;
        }
    }
}
