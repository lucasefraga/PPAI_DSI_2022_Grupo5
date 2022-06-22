using System;
using System.Collections.Generic;

namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class AsignacionCientificoCI
    {
        //ATRIBUTOS
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private PersonalCientifico personalCientifico;
        private List<Turno> turnos;


        //METODOS

        // --> Metodo Constructor
        public AsignacionCientificoCI(DateTime fechaDesde, DateTime fechaHasta, PersonalCientifico personalCientifico)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.personalCientifico = personalCientifico;
            this.turnos = new List<Turno>();
        }

        // --> Devuelve si el cientifico esta activo actualmente
        public bool esActivo(PersonalCientifico cientifico) { return (DateTime.Now > fechaDesde && DateTime.Now < fechaHasta); }

        public bool esCientificoActivo(PersonalCientifico cientifico) { return this.personalCientifico == cientifico; }

        // --> Añade un turno a la lista de turnos asignados a el cientifico
        public void setTurno(Turno turnoCorrespondiente) { turnos.Add(turnoCorrespondiente); }

        public string obtenerMail(  PersonalCientifico cientifico )
        {
            return cientifico.getMail();
        }
    }
}