namespace WebApplication1.Model
{
    public class SolicitudPuestoClave
    {
        private int _id;
        private DateTime _fecha;
        private Puesto _puesto;

        public SolicitudPuestoClave(int id, DateTime fecha, Puesto puesto)
        {
            Id = id;
            Fecha = fecha;
            Puesto = puesto;
        }

        public SolicitudPuestoClave()
        {
            Id = 0;
            Fecha = DateTime.Now;
            Puesto = new Puesto();
        }

        public int Id { get => _id; set => _id = value; }

        public DateTime Fecha { get => _fecha; set => _fecha = value; }

        public Puesto Puesto { get => _puesto; set => _puesto = value; }
    }
}
