namespace WebApplication1.Model
{
    public class RequisitosPuesto
    {

        private int _experienciaRequerida;
        private string _escolaridadRequerida;
        private int _horasFormTecnica;
        private int _tiempoSupervisionPersonal;
        private int _idPuestoAsociado;

        public RequisitosPuesto(int experienciaRequerida, string escolaridadRequerida, int horasFormTecnica, int tiempoSupervisionPersonal, int idPuestoAsociado)
        {
            ExperienciaRequerida = experienciaRequerida;
            EscolaridadRequerida = escolaridadRequerida;
            HorasFormTecnica = horasFormTecnica;
            TiempoSupervisionPersonal = tiempoSupervisionPersonal;
            IdPuestoAsociado = idPuestoAsociado;
        }

        public RequisitosPuesto()
        {
        }

        public int ExperienciaRequerida { get => _experienciaRequerida; set => _experienciaRequerida = value; }

        public string EscolaridadRequerida { get => _escolaridadRequerida; set => _escolaridadRequerida = value; }

        public int HorasFormTecnica { get => _horasFormTecnica; set => _horasFormTecnica = value; }

        public int TiempoSupervisionPersonal { get => _tiempoSupervisionPersonal; set => _tiempoSupervisionPersonal = value; }

        public int IdPuestoAsociado { get => _idPuestoAsociado; set => _idPuestoAsociado = value; }
    }
}
