using System.Collections.Generic;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class TipoRecursoTecnologico
    {
        //ATRIBUTOS
        private string nombre;
        private string descripcion;
        private List<Caracteristica> caracteristicas;

        //METODOS

        // --> Metodo Constructor
        public TipoRecursoTecnologico(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        // --> Retorna True si el tipo pasado como parametro coincide con el TipoRecursoTecnologico
        public bool esSeleccionado(string tipo)
        {
            return nombre == tipo;
        }

        // --> Getters&Setters
        public string getNombre() { return nombre; }
    }
}
