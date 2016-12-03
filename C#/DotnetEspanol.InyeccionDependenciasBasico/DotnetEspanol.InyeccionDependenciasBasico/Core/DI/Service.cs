namespace DotnetEspanol.InyeccionDependenciasBasico.Core.DI
{
    using System;

    internal class Service
    {
        private readonly Type type;

        internal Service(Type type, bool isSingleton)
        {
            this.type = type;
            this.IsSingleton = isSingleton;
        }

        internal object Instance { get; set; }

        internal bool IsSingleton { get; set; }

        internal Type GetServiceType()
        {
            return this.type;
        }
    }
}