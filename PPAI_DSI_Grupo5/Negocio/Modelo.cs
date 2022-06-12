using System.Collections.Generic;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class Modelo
    {
        private string nombre { get; set; }


        List<Marca> marcas = new List<Marca>();
        Marca marcaCorrespondiente = null;

        public Modelo(string nombre)
        {
            this.nombre = nombre;
        }

        public void getMarca()
        {
            marcas = Datos.MainDeDatos.crearMarca();
            foreach (Marca marca in marcas)
            {
                if (marca.esDeEstaMarca(this) != null)
                {
                    marcaCorrespondiente = marca.esDeEstaMarca(this);
                }
            }
        }
        public string getNombreMarca()
        {
            getMarca();
            return marcaCorrespondiente.getNombre();
        }


        public string getNombre()
        {
            return this.nombre;
        }

    }
}