using PPAI_DSI_Grupo5.CapaDatos;
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
        public List<String> obtenerModeloYMarca()
        {
            //Primero modelo y despues marca
            var modeloYMarca = new List<String>();
            modeloYMarca.Add(nombre);
            var marcas = LoadData.loadMarcas();
            foreach (var marca in marcas)
            {
                if (marca.esDeEstaMarca(this))
                {
                    modeloYMarca.Add(marca.getNombre());
                }
            }

            return modeloYMarca;
        }

        // --> Getters&Setters
        public string getNombre() { return this.nombre; }              
    }
}