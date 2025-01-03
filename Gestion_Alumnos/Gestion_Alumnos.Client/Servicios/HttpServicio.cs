using System.Text.Json;

namespace Gestion_Alumnos.Client.Servicios
{
    public class HttpServicio
    {
        private readonly HttpClient http;

        #region constructor HttpServicio
        public HttpServicio(HttpClient http)
        {
            this.http = http;
        }
        #endregion

        public async Task<HttpRespuesta<T>> Get<T>(string url) 
        {
            var response = await http.GetAsync(url);

            if (response.IsSuccessStatusCode) 
            {
                var respuesta = await DeScerializar<T>(response);
                return new HttpRespuesta<T>(respuesta, false, response);
            }   
            else
            {
                return new HttpRespuesta<T>(default, true, response);
            }
        }

        private async Task<T?> DeScerializar<T>(HttpResponseMessage response)
        {
            var respuestaStr = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respuestaStr, 
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
