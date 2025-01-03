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

    }
}
