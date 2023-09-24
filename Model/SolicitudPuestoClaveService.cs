namespace WebApplication1.Model
{
    public class SolicitudPuestoClaveService
    {
        private string _NumPosiblesSucesores;

        public string NumPosiblesSucesores { get => _NumPosiblesSucesores; set => _NumPosiblesSucesores = value; }

        public SolicitudPuestoClaveService(string numPosiblesSucesores)
        {
            NumPosiblesSucesores = numPosiblesSucesores;
        }

        public SolicitudPuestoClaveService()
        {
            NumPosiblesSucesores = " ";
        }

        public bool SeleccionarCantidadPersonas(string cantidad)
        {
            switch (cantidad)
            {
                case "1":
                case "2":
                case "3":
                case "más de 3":
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }
    }
}
