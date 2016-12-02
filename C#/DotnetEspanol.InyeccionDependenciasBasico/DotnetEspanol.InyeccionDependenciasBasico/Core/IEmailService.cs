namespace DotnetEspanol.InyeccionDependenciasBasico.Core
{
    /// <summary>
    /// Contiene las funciones necesarias para que se pueda enviar un correo.
    /// </summary>
    public interface IEmailService
    {
        string GetServiceName();
        void SendEmail(string to, string subject, string message);
    }
}
