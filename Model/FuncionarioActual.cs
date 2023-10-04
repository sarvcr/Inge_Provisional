namespace WebApplication1.Model
{
    public class FuncionarioActual
    {
        private string _id;
        private string _nombre;
        private int _edad;
        private int _anniosEnInstitucion;

        public FuncionarioActual(string id, string nombre, int edad, int anniosEnInstitucion)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            AnniosEnInstitucion = anniosEnInstitucion;
        }

        public FuncionarioActual()
        {
            Id = "";
            Nombre = "";
            Edad = 0;
            AnniosEnInstitucion = 0;
        }

        public string Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public int AnniosEnInstitucion { get => _anniosEnInstitucion; set => _anniosEnInstitucion = value; }
    }
}
