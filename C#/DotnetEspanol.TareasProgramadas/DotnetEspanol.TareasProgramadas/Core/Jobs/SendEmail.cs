namespace DotnetEspanol.TareasProgramadas.Core.Jobs
{
    using System;
    using System.Net.Mail;
    using System.Reflection;
    using System.Web.Hosting;
    using FluentScheduler;

    /// <summary>
    /// Cambia el estado de las solicitudes que no han sido aceptadas al área de oportunidad.
    /// </summary>
    public class SendEmail : IJob, IRegisteredObject
    {
        /// <summary>
        /// Instancia para el bloqueo de la solicitud.
        /// </summary>
        private readonly object _lock = new object();

        /// <summary>
        /// Indica que la aplicación se está terminando y debe terminar.
        /// </summary>
        private bool _shuttingDown;

        public SendEmail()
        {
            // Le indica al IIS que esta tarea debe esperar a terminar antes se cierre.
            HostingEnvironment.RegisterObject(this);
        }

        /// <summary>
        /// Ejecuta la tarea.
        /// </summary>
        public void Execute()
        {
            // La idea es bloquear el recurso durante la ejecución
            // de la tarea, para evitar que se termine antes de tiempo.
            lock (_lock)
            {
                // En caso de que IIS esté cerrando (tiene 30 segundos), la 
                // tarea no debe ejecutarse y se finalizará.
                if (_shuttingDown)
                {
                    return;
                }

                // Ejecutar la tarea.
                DoWork();
            }
        }

        /// <summary>
        /// Realiza la tarea.
        /// </summary>
        private void DoWork()
        {
            // Antes de continuar.
            // Este ejemplo envia un correo a una dirección que no existe.
            // El servidor SMTP es localhost.
            // Puedes instalar Papercut (https://github.com/changemakerstudios/papercut) para leer los correos
            // ya que funciona como un servidor SMTP muy sencillo.
            var emailAddress = new MailAddress("foo@bar.xyz", "Cliente.");

            // Crear el correo con su contenido de prueba.
            var mailMessage = new MailMessage {
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

        /// <summary>
        /// Realiza las operaciones de cierre de la instancia de manera segura.
        /// </summary>
        /// <param name="immediate">Un valor que indica que IIS ha esperado los 30 segundos y ahora se cerrará.</param>
        public void Stop(bool immediate)
        {
            // Si IIS quiere terminar el hilo, debería esperar a que se libere el recurso.
            // de esta manera esperaremos de manera seguro a finalizar bien la tarea.
            lock (_lock)
            {
                _shuttingDown = true;
            }

            // Elimino la tarea del IIS, en este punto ya no es necesario.
            HostingEnvironment.UnregisterObject(this);
        }
    }
}