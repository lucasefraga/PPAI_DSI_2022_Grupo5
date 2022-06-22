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

        // Para saber si un recurso es de este centro se revisan todos los recursos de este centro
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

        public int getTiempoAntelacionReserva() { return tiempoAntelacionReserva; }

        // Agrega el turnocorrespondiente a la lista de turnos 
        public void reservarTurnoCientifico(Turno turnocorrespondiente, PersonalCientifico cientifico)
        {
            foreach (AsignacionCientificoCI cientificoIter in cientificos)
            {
                if (cientificoIter.esCientificoActivo(cientifico))
                {
                    cientificoIter.addTurno(turnocorrespondiente);
                }
            }
        }

        //Getters&Setters
        public string getNombre() { return nombre; }
    }
}
