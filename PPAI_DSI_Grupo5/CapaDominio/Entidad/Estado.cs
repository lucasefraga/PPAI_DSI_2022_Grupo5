using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class Estado
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private string ambito { get; set; }
        private bool esReservable { get; set; }
        private bool esCancelable { get; set; }


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

        public Estado(string nombre, string descripcion, string ambito, bool esReservable, bool esCancelable)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ambito = ambito;
            this.esReservable = esReservable;
            this.esCancelable = esCancelable;
        }

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
