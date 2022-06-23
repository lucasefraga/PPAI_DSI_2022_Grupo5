using System;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class Estado
    {
        //ATRIBUTOS
        private string nombre;
        private string descripcion;
        private string ambito;
        private string esCancelable;
        private string es_Reservable;


        //METODOS

        // --> Metodo Constructor
        public Estado(string nombre, string descripcion, string ambito)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ambito = ambito;
        }

        // --> Devuelve si el estado es RESERVADO
        public bool esReservado() { return nombre == "Reservado"; }

        // --> Devuelve si el estado es RESERVABLE
        internal bool esReservable() { return nombre == "Disponible"; }

        // --> Devuelve si el estado es de ambito TURNO
        public bool esAmbitoTurno() { return ambito == "Turno"; }

        //-- > Getters&Setters
        public string getNombre() { return nombre; }
    }
}
