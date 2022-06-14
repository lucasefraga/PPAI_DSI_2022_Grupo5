using PPAI_DSI_Grupo5.CapaDominio.Entidad;

namespace PPAI_DSI_Grupo5.CapaDominio.FabricacionPura

{
    internal class TurnoEstado
    {
        //Atributos, privados
        private Turno turno { get; set; }
        private Estado estado { get; set; }

        //Get and Set, publicos
        public Turno Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //Generador
        public TurnoEstado(Turno turno, Estado estado)
        {
            this.turno = turno;
            this.estado = estado;
        }
    }

}
