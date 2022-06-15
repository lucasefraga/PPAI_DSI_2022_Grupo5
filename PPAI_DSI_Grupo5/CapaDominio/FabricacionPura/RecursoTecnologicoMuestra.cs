using PPAI_DSI_Grupo5.CapaDominio.Entidad;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.FabricacionPura
{
    public class RecursoTecnologicoMuestra
    {
        //ATRIBUTOS
        private CentroDeInvestigacion centroDeInvestigacion;
        private int numeroInventario;
        private string marca;
        private string modelo;
        private string estado;
        private int color;

        //METODOS

        // --> Metodo Constructor
        public RecursoTecnologicoMuestra(CentroDeInvestigacion centroDeInv, int numeroInventario, string marca, string modelo, string estado)
        {
            centroDeInvestigacion = centroDeInv;
            this.numeroInventario = numeroInventario;
            this.marca = marca;
            this.modelo = modelo;
            this.estado = estado;
        }

        public void setColor(int nroColor)
        {
            this.color = nroColor;
        }

        public CentroDeInvestigacion getCentroInvestigacion()
        {
            return centroDeInvestigacion;
        }


        //Getters&Setters
        public string getEstado() { return estado; }
        public string getMarca() { return marca; }
        public string getModelo() { return modelo; }
        public int getNumetoInventario() { return numeroInventario; }
    }
}
