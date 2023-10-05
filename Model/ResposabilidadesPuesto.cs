namespace WebApplication1.Model
{
    public class ResposabilidadesPuesto
    {
        private bool _existe;
        private List<string> _responsabilidaddes;
        private string _idPuestoAsociado;

        public bool Existe { get => _existe; set => _existe = value; }
        public List<string> Responsabilidaddes { get => _responsabilidaddes; set => _responsabilidaddes = value; }
        public string IdPuestoAsociado { get => _idPuestoAsociado; set => _idPuestoAsociado = value; }

        public ResposabilidadesPuesto(bool existe, List<string> responsabilidaddes, string idPuestoAsociado)
        {
            Existe = existe;
            Responsabilidaddes = responsabilidaddes;
            IdPuestoAsociado = idPuestoAsociado;
        }

        public ResposabilidadesPuesto()
        {
            Existe = false;
            Responsabilidaddes = new List<string> ();
            IdPuestoAsociado = "";
        }
    }
}
