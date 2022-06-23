namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class Caracteristica
    {
        //ATRIBUTOS
        private string nombre;
        private string descripcion;

        //METODOS
        
        // --> Metodo Constructor
        public Caracteristica(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}