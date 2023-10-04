namespace WebApplication1.Model
{
    public class FuncionesPuesto
    {

        private string _descripcion;
        private bool _afectaAJefatura;
        private string _afectacion;
        private int _idPuestoAsociado;

        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool AfectaAJefatura { get => _afectaAJefatura; set => _afectaAJefatura = value; }
        public string Afectacion { get => _afectacion; set => _afectacion = value; }
        public int IdPuestoAsociado { get => _idPuestoAsociado; set => _idPuestoAsociado = value; }

        public FuncionesPuesto(string descripcion, bool afectaAJefatura, string afectacion, int idPuestoAsociado)
        {
            Descripcion = descripcion;
            AfectaAJefatura = afectaAJefatura;
            Afectacion = afectacion;
            IdPuestoAsociado = idPuestoAsociado;
        }

        public FuncionesPuesto()
        {
            Descripcion = "";
            AfectaAJefatura = false;
            Afectacion = "";
            IdPuestoAsociado = 0;
        }
    }
}
