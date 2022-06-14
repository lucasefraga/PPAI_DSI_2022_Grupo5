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
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private string ambito { get; set; }
        private bool esReservable { get; set; }
        private bool esCancelable { get; set; }

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
        public bool EsReservable
        {
            get { return esReservable; }
            set { esReservable = value; }
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
