namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    internal class CaracteristicaRecurso
    {
        //ATRIBUTOS
        private string valor;
        private Caracteristica caracteristica;

        //METODOS

        // --> Metodo Constructor
        public CaracteristicaRecurso(string valor, Caracteristica caracteristica)
        {
            this.valor = valor;
            this.caracteristica = caracteristica;
        }

        // --> Getters&Setters
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