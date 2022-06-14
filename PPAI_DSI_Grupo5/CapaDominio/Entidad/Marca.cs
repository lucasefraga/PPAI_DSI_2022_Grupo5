using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class Marca
    {
        private string nombre { get; set; }
        private List<Modelo> modelos { get; set; }

        public Marca(string nombre, List<Modelo> modelos)
        {
            this.nombre = nombre;
            this.modelos = modelos;
        }

        public Marca esDeEstaMarca(Modelo modelo)
        {
            if (modelos.Contains(modelo))
            {
                return this;
            }
            return null;
        }

        public string getNombre()
        {
            return nombre;
        }

        public Marca devolverMarca()
        {
            return this;
        }
    }
}
