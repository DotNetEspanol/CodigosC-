namespace DotnetEspanol.TareasProgramadas
{
    using System.Web.Mvc;
    using System.Web.Routing;
    using FluentScheduler;

    /// <summary>
    /// Punto de entrada de la aplicación.
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Evento que es lanzado una vez al iniciar la aplicación.
        /// </summary>
        /// <remarks>
        /// Este evento puede ser lanzada por cada proceso dentro de un grupo de aplicaciones.
        /// Si el grupo de aplicaciones tiene un jardín de servidores, cada uno de los procesos
        /// pueden lanzar este evento varias veces.
        /// </remarks>
        protected void Application_Start()
        {
            // Registrar las rutas para la aplicación web.
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Configurar las tareas programadas del sistema.
            JobManager.Initialize(new Core.Jobs.JobRegistry());
        }
    }
}