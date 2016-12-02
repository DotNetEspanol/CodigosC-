namespace DotnetEspanol.InyeccionDependenciasBasico.Core.DI
{
    using System;

    /// <summary>
    /// Excepción que es provocada por un error cuando un tipo no es resuelto por DI.
    /// </summary>
    public class NotResolvedTypeException : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="NotResolvedTypeException"/>.
        /// </summary>
        public NotResolvedTypeException()
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="NotResolvedTypeException"/> con el mensaje de error especificado.
        /// </summary>
        /// <param name="message">Mensaje de error que explica el motivo de la excepción.</param>
        public NotResolvedTypeException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="NotResolvedTypeException"/> con el mensaje de error especificado y una referencia a la excepción interna que representa la causa de esta excepción.
        /// </summary>
        /// <param name="message">Mensaje de error que explica el motivo de la excepción.</param>
        /// <param name="inner">La excepción que es la causa de la excepción actual o una referencia nula (Nothing en Visual Basic) si no se especifica ninguna excepción interna.</param>
        public NotResolvedTypeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

}