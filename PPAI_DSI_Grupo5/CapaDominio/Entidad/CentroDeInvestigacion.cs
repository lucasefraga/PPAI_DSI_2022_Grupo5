using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
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

        public int TiempoAntelacionReserva
        {
            get { return tiempoAntelacionReserva; }
            set { tiempoAntelacionReserva = value; }
        }

        public CentroDeInvestigacion(string nombre, string sigla, string direccion, string edificio, 
            int piso, string coordenadas, List<double> telefonoContacto, string correoElectronico, 
            string numResCreacion, DateTime fechaResCreacion, string reglamento, string caracteristicasGenerales, 
            DateTime fechaAlta, int tiempoAntelacionReserva, DateTime fechaBaja, string motivoBaja, 
            List<RecursoTecnologico> recursosTecnologicos, List<AsignacionCientificoCI> cientificos, 
            List<AsignacionDirectorCI> directorCI)
        {
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.edificio = edificio;
            this.piso = piso;
            this.coordenadas = coordenadas;
            this.telefonoContacto = telefonoContacto;
            this.correoElectronico = correoElectronico;
            this.numResCreacion = numResCreacion;
            this.fechaResCreacion = fechaResCreacion;
            this.reglamento = reglamento;
            this.caracteristicasGenerales = caracteristicasGenerales;
            this.fechaAlta = fechaAlta;
            this.tiempoAntelacionReserva = tiempoAntelacionReserva;
            this.fechaBaja = fechaBaja;
            this.motivoBaja = motivoBaja;
            this.recursosTecnologicos = recursosTecnologicos;
            this.cientificos = cientificos;
            this.directorCI = directorCI;
        }

        public CentroDeInvestigacion(string nombre, string sigla, string direccion, string edificio, int piso, string coordenadas, string correoElectronico, string numResCreacion, DateTime fechaResCreacion, string reglamento, string caracteristicasGenerales, DateTime fechaAlta, int tiempoAntelacionReserva, DateTime fechaBaja, string motivoBaja, List<RecursoTecnologico> recursosTecnologicos, List<AsignacionCientificoCI> cientificos, List<AsignacionDirectorCI> directorCI)
        {
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.edificio = edificio;
            this.piso = piso;
            this.coordenadas = coordenadas;
            this.correoElectronico = correoElectronico;
            this.numResCreacion = numResCreacion;
            this.fechaResCreacion = fechaResCreacion;
            this.reglamento = reglamento;
            this.caracteristicasGenerales = caracteristicasGenerales;
            this.fechaAlta = fechaAlta;
            this.tiempoAntelacionReserva = tiempoAntelacionReserva;
            this.fechaBaja = fechaBaja;
            this.motivoBaja = motivoBaja;
            this.recursosTecnologicos = recursosTecnologicos;
            this.cientificos = cientificos;
            this.directorCI = directorCI;
        }

        public CentroDeInvestigacion obtenerCIdeRecursoTecnologico(RecursoTecnologico recurso)
        {
            if (recursosTecnologicos.Contains(recurso))
            {
                return this;
            }
            return null;
        }

        public bool esCientificoActivo(PersonalCientifico cientifico)
        {
            foreach (AsignacionCientificoCI asignado in cientificos)
            {
                if (asignado.esActivo(cientifico))
                {
                    return true;
                }
                break;
            }
            return false;
        }


        public void reservarTurnoCientifico(Turno turnocorrespondiente, PersonalCientifico cientifico)
        {
            foreach (AsignacionCientificoCI item in cientificos)
            {
                if (item.getPersonalCientifico().Equals(cientifico))
                {
                    item.addTurno(turnocorrespondiente);
                }
            }
        }
    }
}
