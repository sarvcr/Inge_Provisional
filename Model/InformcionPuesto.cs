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

    }
}
