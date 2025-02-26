namespace Gestion_Alumnos.Client.Servicios
{
    public class ServicioMostrarMenu
    {
        public bool MostrarMenu { get; set; } = false;

        public event Action? OnChange;

        public void ActualizarEstado(bool mostrarMenu)
        {
            MostrarMenu = mostrarMenu;
            NotificarCambio();
        }

        private void NotificarCambio() => OnChange?.Invoke();
    }
}
