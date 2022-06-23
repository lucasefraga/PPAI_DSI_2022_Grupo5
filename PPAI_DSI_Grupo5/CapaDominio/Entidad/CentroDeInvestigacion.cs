using System;
using System.Collections.Generic;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class CentroDeInvestigacion
    {
        //ATRIBUTOS
        private string nombre;
        private string sigla;
        private string direccion;
        private string edificio;
        private int piso;
        private string coordenadas;
        private List<double> telefonoContacto;
        private string correoElectronico;
        private string numResCreacion;
        private DateTime fechaResCreacion;
        private string reglamento;
        private string caracteristicasGenerales;
        private DateTime fechaAlta;
        private int tiempoAntelacionReserva;
        private DateTime fechaBaja;
        private string motivoBaja;
        private List<RecursoTecnologico> recursosTecnologicos;
        private List<AsignacionCientificoCI> cientificos;
        private List<AsignacionDirectorCI> directorCI;


        //METODOS

        // --> Metodo Constructor
        public CentroDeInvestigacion(string nombre, string sigla, string direccion, int tiempoAntelacionReserva, List<RecursoTecnologico> recursosTecnologicos, List<AsignacionCientificoCI> cientificos)
        {
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.tiempoAntelacionReserva = tiempoAntelacionReserva;
            this.recursosTecnologicos = recursosTecnologicos;
            this.cientificos = cientificos;
        }

        // --> Retorna el CI del recurso o null de no encontrarse
        public CentroDeInvestigacion obtenerCIdeRecursoTecnologico(RecursoTecnologico recurso)
        {
            if (recursosTecnologicos.Contains(recurso))
            {
                return this;
            }
            return null;
        }
        
        // --> Retorna True si el cientifico esta asignado y activo
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

        // --> Agrega el turnocorrespondiente a la lista de turnos asignados al cientifico
        public void reservarTurnoCientifico(Turno turnocorrespondiente, PersonalCientifico cientifico)
        {
            foreach (AsignacionCientificoCI cientificoIter in cientificos)
            {
                if (cientificoIter.esCientificoActivo(cientifico))
                {
                    cientificoIter.setTurno(turnocorrespondiente);
                }
            }
        }

        // --> Getters&Setters
        public string getNombre() { return nombre; }

        public void setRecursosTecnologicos(List<RecursoTecnologico> recursos)
        {
            recursosTecnologicos = recursos;
        }

        public int getTiempoAntelacionReserva() { return tiempoAntelacionReserva; }
    }

}
