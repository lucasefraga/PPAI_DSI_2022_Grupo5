using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class TipoRecursoTecnologico
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private List<Caracteristica> caracteristicas { get; set; }

        public TipoRecursoTecnologico(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public TipoRecursoTecnologico(string nombre, string descripcion, List<Caracteristica> caracteristicas)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.caracteristicas = caracteristicas;
        }




        public override bool Equals(object obj)
        {
            return obj is TipoRecursoTecnologico tecnologico &&
                   nombre == tecnologico.nombre &&
                   descripcion == tecnologico.descripcion &&
                   EqualityComparer<List<Caracteristica>>.Default.Equals(caracteristicas, tecnologico.caracteristicas);
        }



    }
}
