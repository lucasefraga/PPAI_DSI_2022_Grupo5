namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class CaracteristicaRecurso
    {
        // Atributos
        private string valor;
        private Caracteristica caracteristica;

        // Constructor
        public CaracteristicaRecurso(string valor, Caracteristica caracteristica)
        {
            this.valor = valor;
            this.caracteristica = caracteristica;
        }

        // Get and Set
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public Caracteristica Caracteristica
        {
            get { return caracteristica; }
            set { caracteristica = value; }
        }
    }
}