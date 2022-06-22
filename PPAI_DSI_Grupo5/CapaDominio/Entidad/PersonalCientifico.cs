namespace PPAI_DSI_Grupo5.CapaDominio.Entidad
{
    public class PersonalCientifico
    {
        //ATRIBUTOS
        private int legajo;
        private string nombre;
        private string apellido;
        private double documento;
        private string correoInstitucional;
        private string correoPersonal;
        private double telefono;

        //METODOS

        // --> Metodo Constructor
        public PersonalCientifico(int legajo, string nombre, string apellido, double documento,
            string correoInstitucional, string correoPersonal, double telefono)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
            this.correoInstitucional = correoInstitucional;
            this.correoPersonal = correoPersonal;
            this.telefono = telefono;
        }

        //Getters&Setters
        public string getMail() { return correoPersonal; }
        public int getLegajo() { return legajo; }
        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public double getDocumento() { return documento; }
        public string getCorreoInstitucional() { return correoInstitucional; }
        public double getTelefono() { return telefono; }

    }
}
