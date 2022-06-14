using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class PersonalCientifico
    {
        private int legajo { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private double documento { get; set; }
        private string correoInstitucional { get; set; }
        private string correoPersonal { get; set; }
        private double telefono { get; set; }
        private Usuario usuario { get; set; }

        public PersonalCientifico(int legajo, string nombre, string apellido, double documento, 
            string correoInstitucional, string correoPersonal, double telefono, Usuario usuario)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
            this.correoInstitucional = correoInstitucional;
            this.correoPersonal = correoPersonal;
            this.telefono = telefono;
            this.usuario = usuario;
        }

        public Usuario getUsuario()
        {
            return usuario;
        }
        public String GetCorreoPersonal()
        {
            return this.correoPersonal;
        }
    }
}
