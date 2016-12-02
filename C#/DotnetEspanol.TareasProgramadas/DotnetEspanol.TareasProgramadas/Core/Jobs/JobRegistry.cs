namespace DotnetEspanol.TareasProgramadas.Core.Jobs
{
    using FluentScheduler;

    /// <summary>
    /// Registra todas las teras que debe realizar la aplicación de manera continua.
    /// </summary>
    public class JobRegistry : Registry
    {
        /// <summary>
        /// Crea una nueva instancia de la clase <see cref="JobRegistry"/>.
        /// </summary>
        public JobRegistry()
        {
            // Ejecutar el procedimiento al momento de inicializar la aplicación y todos los días a las 10 am.
            // A las 11:00 hrs, es un horario con actividad, así evitamos que por alguna extraña razón no se
            // ejecute. De todas maneras después de 29 horas de que la página esté inactiva se reciclará el 
            // AppDomain, activando nuevamente esta tarea.
            Schedule<SendEmail>().ToRunNow().AndEvery(1).Days().At(11, 00);
        }
    }
}