namespace DotnetEspanol.TareasProgramadas.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

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
        /// Muestra una página inicial.
        /// </summary>
        /// <remarks>
        /// Esta solo sirve como punto de entrada, el correo se envia desde otra clase.
        /// </remarks>
        /// <returns>Página inicial.</returns>
        public ActionResult Index()
        {
            // Esta página no tiene ninguna lógica.
            return this.View();
        }
    }
}
