using System.Collections.Generic;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class Marca
    {
        //ATRIBUTOS
        private string nombre;
        private List<Modelo> modelos;

        //METODOS

        // --> Metodo Constructor
        public Marca(string nombre, List<Modelo> modelos)
        {
            this.nombre = nombre;
            this.modelos = modelos;
        }

        // --> Devuelve si un modelo es de esta marca
        public bool esDeEstaMarca(Modelo modelo)
        {
            return modelos.Contains(modelo);
        }

        //Getters&Setters
        public string getNombre() { return nombre; }
    }
}
