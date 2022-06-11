using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.Negocio
{
    internal class CentroDeInvestigacion
    {
        private string nombre { get; set; }
        private string sigla { get; set; }
        private string direccion { get; set; }
        private string edificio { get; set; }
        private int piso { get; set; }
        private string coordenadas { get; set; }
        private List<double> telefonoContacto { get; set; }
        private string correoElectronico { get; set; }
        private string numResCreacion { get; set; }
        private DateTime fechaResCreacion { get; set; }
        private string reglamento { get; set; }
        private string caracteristicasGenerales { get; set; }
        private DateTime fechaAlta { get; set; }
        private int tiempoAntelacionReserva { get; set; }
        private DateTime fechaBaja { get; set; }
        private string motivoBaja { get; set; }
        private List<RecursoTecnologico> recursosTecnologicos { get; set; }
        private List<AsignacionCientificoCI> cientificos { get; set; }
        private List<AsignacionDirectorCI> directorCI { get; set; }
        
        


    }
}
