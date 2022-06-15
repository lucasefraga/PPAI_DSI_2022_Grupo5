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

        // --> devuelve si el tipo pasado por parametro es igual a este objeto
        public bool esSeleccionado(string tipo)
        {
            return nombre == tipo;
        }

        //Getters&Setters
        public string getNombre() { return nombre; }
    }
}
