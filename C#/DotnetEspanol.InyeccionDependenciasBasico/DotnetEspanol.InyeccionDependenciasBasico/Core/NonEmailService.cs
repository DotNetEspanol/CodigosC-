namespace DotnetEspanol.InyeccionDependenciasBasico.Core
{
    public class NonEmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string message)
        {
            // No hacer nada.
        }

        public string GetServiceName()
        {
            return "No se envio nada, cambie a EmailService";
        }
    }
}