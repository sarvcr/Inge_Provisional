namespace WebApplication1.Model
{
    public class GestionActivos
    {
        private bool _existe;
        private double _valor;
        private int _idPuestoAsociado;

        public bool Existe { get => _existe; set => _existe = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public int IdPuestoAsociado { get => _idPuestoAsociado; set => _idPuestoAsociado = value; }

        public GestionActivos(bool existe, double valor, int idPuestoAsociado)
        {
            Existe = existe;
            Valor = valor;
            IdPuestoAsociado = idPuestoAsociado;
        }

        public GestionActivos()
        {
            Existe = false;
            Valor = 0;
            IdPuestoAsociado = 0;
        }
    }
}
