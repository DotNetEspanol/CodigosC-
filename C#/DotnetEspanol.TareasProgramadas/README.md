## Tareas programadas

Una tarea programada es aquella que deseamos que se realice en cierto momento
y que no nos preocupemos por que se ejecute.

En el caso de las aplicaciones web, este tipo de actividades se vuelve
más complicada por el simple hecho de que la vida de una página se mide
por solicitudes, osea que inicia y termina con una solicitud.

Una solución simple es guardar en la base de datos la tarea y su fecha de
"última ejecución" y en el código consultar esa fecha y si es anterior a
la actual, entonces ejecutar la tarea. Pero aún así existe un problema con
esa solución, y es que es posible que se ejecute por cada solicitud, y si
en ese momento entran varios, pues se ejecutará varias veces la misma tarea.

## ¿Cómo programar una tarea?

**FluentSheduler** es un "programador de tareas automáticas" y es el usado en
este ejemplo. Para programar una tarea se debe hacer dos cosas.

- Crear la tarea
- Registrar cuándo se ejecutará.

Para **crear la tarea** observe el archivo [Core\Jobs\SendEmail.cs](DotnetEspanol.TareasProgramadas/Core/Jobs/SendEmail.cs)
y modifique el siguiente bloque de código:

```csharp
/// <summary>
/// Cambia el estado de las solicitudes que no han sido aceptadas al área de oportunidad.
/// </summary>
public class SendEmail : IJob, IRegisteredObject
{
    /// <summary>
    /// Realiza la tarea.
    /// </summary>
    private void DoWork()
    {
        ...
    }
}
```

> La interfaz `IJob` requiere implementar el método `void Execute()`, este
es el que llama a la función `DoWork()`.

> La clase `SendEmail` implementa `IRegisteredObject`, lo cuál permite
controlar cuando IIS está cerrando la aplicación.

Una vez hecho eso, se debe **registrar cuándo se ejecutará** y para ello
usamos una clase llamada [JobRegistry.cs](DotnetEspanol.TareasProgramadas/Core/Jobs/JobRegistry.cs)

Es ahí donde nosotros modificaremos la frecuencia con la que se ejecútará
la tarea programada.

```csharp
// Se ejecuta "ahora" y cada 1 día a las 11:00 horas.
Schedule<SendEmail>().ToRunNow().AndEvery(1).Days().At(11, 00);
```

## Global.asax

El archivo [Global.asax](DotnetEspanol.TareasProgramadas/Global.asax.cs)
es el que contiene la clase de entrada para la aplicación. En el existe el método 
`void Application_Start()`, que es el primero que se ejecutará.

Es ahí donde daremos inicio con todas las tareas programadas con el siguiente
código:

```csharp
// Configurar las tareas programadas del sistema.
JobManager.Initialize(new Core.Jobs.JobRegistry());
```

## Consideraciones

Puede consultar las diferentes formas de configurar las tareas programadas
en la página de [FluentSheduler](https://github.com/fluentscheduler/FluentScheduler).

Una aplicación web se recicla cada 29 horas, eso quiere decir que IIS cierra
los hilos creados para la aplicación y los vuelve a crear. Es por eso que 
es mejor utilizar `ToRunNow()` para ejecutar las tareas. Adicional a esto,
si nadie entra a la página por ~20 minutos, entonces IIS la pone a "dormir".
Por tal motivo es probable que no se ejecute la tarea.

Puede hacer una tarea cada 19 minutos por ejemplo, y que esta llame a cualquier
página de la aplicación usando un `WebClient`, eso mantendrá "despierta" a la aplicación.

Hay aplicaciones que corren en "granjas de servidores" (no es lo mismo que un "jardín")
esto significa que la misma tarea se puede ejecutar varias veces, en ese caso
podemos cambiarnos a [HangFire](hangfire.com) para controlar mejor eso.

---
DotNetEspanol
