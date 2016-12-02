namespace DotnetEspanol.InyeccionDependenciasBasico.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Core;
    using Core.DI;

    /// <summary>
    /// Este es el controlador principal del sitio web.
    /// </summary>
    /// <remarks>
    /// Al acceder a la página principal se redirigirá a este controlador.
    /// Para cambiar este comportamiento se debe modificar la clase <see cref="RouteConfig"/>.
    /// </remarks>
    public class HomeController : Controller
    {
        /// <summary>
        /// Envia un correo usando el servicio definido en <see cref="MvcApplication.Application_Start"/>.
        /// </summary>
        /// <returns>Página inicial.</returns>
        public ActionResult Index()
        {
            // Obtener la clase que se encargará de realizar el envio de correos.
            var _email = ServiceLocator.GetService<IEmailService>();

            // Enviar el correo.
            _email.SendEmail("foo@bar.com", "Saldo vencido.", "Le informamos que su saldo se ha vencido.");

            // Mostrar en la vista quien ha enviado el correo.
            ViewBag.Sender = _email.GetServiceName();

            // Esta página no tiene ninguna lógica.
            return this.View();
        }
    }
}
