namespace WebApplication1.Model
{
	public class Puesto
	{
		private int _id;
		private string _estado;
		private InformcionPuesto _informcionPuesto;
		private RequisitosPuesto _requisitosPuesto;

		public int Id { get => _id; set => _id = value; }

		public string Estado { get => _estado; set => _estado = value; }

		public InformcionPuesto InformcionPuesto { get => _informcionPuesto; set => _informcionPuesto = value; }

		public RequisitosPuesto RequisitosPuesto { get => _requisitosPuesto; set => _requisitosPuesto = value; }

		public Puesto(int id, string estado, InformcionPuesto informcionPuesto, RequisitosPuesto requisitosPuesto)
		{
			Id = id;
			Estado = estado;
			InformcionPuesto = informcionPuesto;
			RequisitosPuesto = requisitosPuesto;
		}

		public Puesto()
		{
			Id = 0;
			Estado = "";
			InformcionPuesto = new InformcionPuesto();
			RequisitosPuesto = new RequisitosPuesto();
		}
	}
}
