namespace Gestion_Alumnos.Client.Servicios
{
    public class HttpRespuesta<T>
    {
        public T respuesta { get; }
        public bool err { get; }

        public HttpResponseMessage HttpResponseMessage { get; set; }

        #region constructor HttpRespuesta
        public HttpRespuesta(T respuesta, bool err, HttpResponseMessage httpResponseMessage)
        {
            this.respuesta = respuesta;
            this.err = err;
            HttpResponseMessage = httpResponseMessage;
        }
        #endregion


        public async Task<string> ObtenerError() 
        {
            if (!err) 
            {
                return "";
            }

            var statuscode = HttpResponseMessage.StatusCode;

            switch (statuscode)
            {
                case System.Net.HttpStatusCode.BadRequest:
                    return HttpResponseMessage.Content.ReadAsStringAsync().ToString()!;
                //                    return "Error, no se puede procesar la información";
                case System.Net.HttpStatusCode.Unauthorized:
                    return "Error, no está logueado";
                case System.Net.HttpStatusCode.Forbidden:
                    return "Error, no tiene autorización a ejecutar este proceso";
                case System.Net.HttpStatusCode.NotFound:
                    return "Error, dirección no encontrado";
                default:
                    return HttpResponseMessage.Content.ReadAsStringAsync().Result;
            }
        }

    }
}
