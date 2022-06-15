using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class Estado
    {
        //Atributos privados
        private string nombre;
        private string descripcion;
        private string ambito;
        private bool esReservable;
        private bool esCancelable;

        //Get and set publicos
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Ambito
        {
            get { return ambito; }
            set { ambito = value; }
        }
        public bool EsReservado()
        {
            return nombre == "Reservado";
        }
        public bool EsCancelable
        {
            get { return esCancelable; }
            set { esCancelable = value; }
        }

        // Generador
        public Estado(string nombre, string descripcion, string ambito, bool esReservable, bool esCancelable)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ambito = ambito;
            this.esReservable = esReservable;
            this.esCancelable = esCancelable;
        }

        internal bool esAmbitoTurno()
        {
            return this.Ambito == "Turno";
        }

        //Estos metodos de get hacen lo mismo que los get de arriba, a la espera de decidir con cual
        //quedarse (los de arriba los saque de la documentacion de C#)
        public bool getEsReservable()
        {
            return esReservable;
        }

        public string getNombre()
        {
            return nombre;
        }
        

    }
}
