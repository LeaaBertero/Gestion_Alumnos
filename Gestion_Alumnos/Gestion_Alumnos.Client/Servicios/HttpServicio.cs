﻿using System.Text;
using System.Text.Json;

namespace Gestion_Alumnos.Client.Servicios
{
    public class HttpServicio : IHttpServicio
    {
        private readonly HttpClient http;

        //constructor de la clase HttpServicio
        #region constructor HttpServicio
        public HttpServicio(HttpClient http)
        {
            this.http = http;
        }
        #endregion

        //respuesta del endpoint, (Muestra una lista al usuario)
        #region Get HttpRespuesta
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
        #endregion

        //postear un nuevo elemento
        #region Post HttpRespuesta
        public async Task<HttpRespuesta<object>> Post<T>(string url, T entidad)
        {
            var enviarJson = JsonSerializer.Serialize(entidad);

            var enviarContent = new StringContent(enviarJson,
                                Encoding.UTF8,
                                "application/json");

            var response = await http.PostAsync(url, enviarContent);
           
            if (response.IsSuccessStatusCode)
            {
                var respuesta = await DeScerializar<object>(response);
                return new HttpRespuesta<object>(respuesta, false, response);
            }
            else
            {
                return new HttpRespuesta<object>(default, true, response);
            }
        }
        #endregion

        
        #region Descerializar
        private async Task<T?> DeScerializar<T>(HttpResponseMessage response)
        {
            var respuestaStr = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respuestaStr,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        #endregion
    }
}
