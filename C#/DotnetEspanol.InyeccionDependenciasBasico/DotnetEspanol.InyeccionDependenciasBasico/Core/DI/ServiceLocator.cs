namespace DotnetEspanol.InyeccionDependenciasBasico.Core.DI
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public static class ServiceLocator
    {
        private static IDictionary<Type, Service> services;

        static ServiceLocator()
        {
            services = new Dictionary<Type, Service>();            
        }

        public static void Clear()
        {
            services.Clear();
        }

        public static void AddSingleton<TService>(Type instanceType) where TService : class
        {
            var instance2 = new Service(instanceType, true);
            services.Add(typeof(TService), instance2);
        }

        public static void AddScope<TService>(Type instanceType) where TService : class
        {
            var instance2 = new Service(instanceType, false);
            services.Add(typeof(TService), instance2);
        }

        public static TService GetService<TService>() where TService : class
        {
            try
            {
                var service = services[typeof(TService)];

                if (service.IsSingleton)
                {
                    if (service.Instance == null)
                    {
                        service.Instance = Activator.CreateInstance(service.GetServiceType());
                    }

                    return (TService)service.Instance;
                }

                return (TService)Activator.CreateInstance(service.GetServiceType());
            }
            catch (KeyNotFoundException)
            {
                throw new NotResolvedTypeException("No se puede resolver una instancia para " + typeof(TService).ToString());
            }
        }
    }
}