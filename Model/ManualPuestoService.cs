using System.Net;

namespace WebApplication1.Model
{
    public class ManualPuestoService
    {
        private string _manualPuesto;

        public string ManualPuesto { get => _manualPuesto; set => _manualPuesto = value; }

        public ManualPuestoService(string manualPuesto)
        {
            ManualPuesto = manualPuesto;
        }

        public ManualPuestoService()
        {
            ManualPuesto = " ";
        }

        public bool AccederManualPuesto()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(ManualPuesto).Result;

                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }
    }
}
