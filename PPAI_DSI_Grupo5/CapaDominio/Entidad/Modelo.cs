using System;
using System.Collections.Generic;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class Modelo
    {
        //ATRIBUTOS
        private string nombre;


        //METODOS

        // --> Metodo Constructor
        public Modelo(string nombre)
        {
            this.nombre = nombre;
        }

        // --> Devuelve el nombre de la marca de estre producto
        public string getNombreMarca(List<Marca> marcas)
        {
            foreach (var marca in marcas)
            {
                if (marca.esDeEstaMarca(this))
                {
                    return marca.getNombre();
                }
            }
            return null;
        }

        //Getters&Setters
        public string getNombre() { return this.nombre; }              
    }
}