using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace DotnetEspanol.InyeccionDependenciasBasico.Core
{
    /// <summary>
    /// Esta clase si envia los correos.
    /// </summary>
    public class EmailService : IEmailService
    {
        public string GetServiceName()
        {
            return "Envio real de correos.";
        }

        public void SendEmail(string to, string subject, string message)
        {
            // Antes de continuar.
            // Este ejemplo envia un correo a una dirección que no existe.
            // El servidor SMTP es localhost.
            // Puedes instalar Papercut (https://github.com/changemakerstudios/papercut) para leer los correos
            // ya que funciona como un servidor SMTP muy sencillo.
            var emailAddress = new MailAddress(to);

            // Crear el correo con su contenido de prueba.
            var mailMessage = new MailMessage
            {
                IsBodyHtml = true,
                Body = "<strong>Hola cliente</strong><p>Le avisamos que tiene atrasada una factura."
            };

            // Configuramos el correo de destino.
            mailMessage.To.Add(emailAddress);

            // Y enviamos el correo.
            try
            {
                var smtpClient = new SmtpClient();
                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {
                // Algo no pudo funcionar.
            }
        }
    }
}