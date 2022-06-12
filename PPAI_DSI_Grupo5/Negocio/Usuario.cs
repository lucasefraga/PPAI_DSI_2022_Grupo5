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

        List<PersonalCientifico> cientificos = new List<PersonalCientifico>(); 

        public Usuario(string clave, string nombreUsuario, bool habilitado)
        {
            this.clave = clave;
            this.nombreUsuario = nombreUsuario;
            this.habilitado = habilitado;
        }

        public Usuario getUsuario()
        {
            return this;
        }

        public PersonalCientifico GetPersonalCientifico()
        {
            foreach (PersonalCientifico cientifico in cientificos)
            {
                if (cientifico.getUsuario().Equals(this))
                {
                    return cientifico;
                }
            }
            return null;
        }

        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   clave == usuario.clave &&
                   nombreUsuario == usuario.nombreUsuario &&
                   habilitado == usuario.habilitado &&
                   EqualityComparer<List<PersonalCientifico>>.Default.Equals(cientificos, usuario.cientificos);
        }
    }
}
