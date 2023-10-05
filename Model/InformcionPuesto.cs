using System;

namespace WebApplication1.Model
{
    public class InformcionPuesto
    {
        private string _nombre;
        private string _dependencia;
        private int _numeroPlaza;
        private FuncionarioActual _funcionarioActual;
        private List<FuncionesPuesto> _funcionesPuestos;
        private Dictionary<string,string> _conocimientoEnAreas;
        //private ManualDeProcedimiento _manualDeProcedimiento; probablemente esta clase ni se cree
        private ResposabilidadesPuesto _resposabilidades;
        private GestionActivos _activos;
        private int[] _valorVariablesInfluyentes;

        public InformcionPuesto(string nombre, string dependencia, int numeroPlaza, FuncionarioActual funcionarioActual, List<FuncionesPuesto> funcionesPuestos, Dictionary<string, string> conocimientoEnAreas, ResposabilidadesPuesto resposabilidades, GestionActivos activos, int[] valorVariablesInfluyentes)
        {
            Nombre = nombre;
            Dependencia = dependencia;
            NumeroPlaza = numeroPlaza;
            FuncionarioActual = funcionarioActual;
            FuncionesPuestos = funcionesPuestos;
            ConocimientoEnAreas = conocimientoEnAreas;
            Resposabilidades = resposabilidades;
            Activos = activos;
            ValorVariablesInfluyentes = valorVariablesInfluyentes;
        }

        public InformcionPuesto()
        {
            Nombre = "";
            Dependencia = "";
            NumeroPlaza = 0;
            FuncionarioActual = new FuncionarioActual();
            FuncionesPuestos = new List<FuncionesPuesto>();
            ConocimientoEnAreas = new Dictionary<string, string>();
            Resposabilidades = new ResposabilidadesPuesto();
            Activos = new GestionActivos();
            ValorVariablesInfluyentes = new int[0];
        }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Dependencia { get => _dependencia; set => _dependencia = value; }

        public int NumeroPlaza { get => _numeroPlaza; set => _numeroPlaza = value; }

        public FuncionarioActual FuncionarioActual { get => _funcionarioActual; set => _funcionarioActual = value; }

        public List<FuncionesPuesto> FuncionesPuestos { get => _funcionesPuestos; set => _funcionesPuestos = value; }

        public Dictionary<string, string> ConocimientoEnAreas { get => _conocimientoEnAreas; set => _conocimientoEnAreas = value; }

        public ResposabilidadesPuesto Resposabilidades { get => _resposabilidades; set => _resposabilidades = value; }

        public GestionActivos Activos { get => _activos; set => _activos = value; }

        public int[] ValorVariablesInfluyentes { get => _valorVariablesInfluyentes; set => _valorVariablesInfluyentes = value; }
    }
}
