# Inyección de dependencias

La inyección de dependencias no es más que simplemente una forma
de programar sin necesidad de quién realice la tarea ni cómo, 
sólo programar.

Imagine que su código tiene una clase llamada `ConexionDb`. Esa la usa
en cada parte de la aplicación, sin embargo esta usa SqlServer, y esta
fuertemente ligada a SqlServer. Ya ha programado decenas de clases que se
conectan e inclusive no está seguro de dónde se usa.

En algún momento el cliente decide cambiar a MySql, ¿cuánto tiempo le tomaría
cambiar el código?, digamos que en 1 hora. Si hubiera usado la inyección
de dependencias, le tomaría unos segundos (o minutos si su computadora fuera tan lenta como la mía).

El patrón de "inyección de dependencias" sólo establece qué debería de hacer
una clase como `ConexionDb` mas no como lo hace (implementa). Es ahí donde
reside su importancia. Ya que las demás clases, no requieren acoplarse
o vincularse con ninguna en especifico, solamente con la "interfaz".

Hay muchos artículos sobre inyección de dependencias, en este ejemplo no se
trata de enseñar a detalle cómo funciona, pero si observan las clases
contenidas en el proyecto se darán una idea de cómo funciona internamente.

## Paso 1: Definir la actividad.

Una interfaz define el nombre de las actividades. Por lo cual hay que crear
primero una interfaz.

```csharp
public interface IEmailService
{
    string GetServiceName();
    void SendEmail(string to, string subject, string message);
}
```

Ahí estamos definiendo que debe existir una clase que tenga la función
de enviar con esos parametros.

## Paso 2: Implementar la interfaz.

Implementar una interfaz, no es más que crear una clase que "implemente"
dicha interfaz, osea tenga los mismos métodos (firmas) que la interfaz.

```csharp
public class NonEmailService : IEmailService
{
    public void SendEmail(string to, string subject, string message)
    {
        // Esta función no hará nada por el momento.
    }
}
```

## Paso 3: Consumir el servicio.

En este punto, la clase `HomeController` no conoce quién va a implementar
la funcionalidad. Simplemente creamos una instancia por medio de `GetService`.

Observa cómo funciona `ServiceLocator.GetService<T>();`, quizá sea algo complicado,
pero en si no lo es, simplemente crea y devuelve una instancia.

```csharp
public class HomeController : Controller
{
    public ActionResult Index()
    {
        // Obtener la clase que se encargará de realizar el envio de correos.
        var _email = ServiceLocator.GetService<IEmailService>();

        // Enviar el correo.
        _email.SendEmail("foo@bar.com", "Saldo vencido.", "Le informamos que su saldo se ha vencido.");

        // Esta página no tiene ninguna lógica.
        return this.View();
    }
}
```

## Paso 4: Registrar la instancia.

Antes de poder usarlas, las clases deben ser registradas en algo
que se le llama "Contenedor", en este caso, nuestro contenedor se llama
`ServiceLocator` (puede ser cualquier nombre).

Vamos a usar siempre `Global.asax.cs` para registrar los servicios, porque
es lo que se ejecuta siempre de primero.

```csharp
protected void Application_Start()
{
    // Registrar qué instancia enviará el correo.
    ServiceLocator.AddScope<IEmailService>(typeof(NonEmailService));
}
```

## Consideraciones.

Es importante conocer este patrón, con .NET Core, es algo de suma
importancia.

Esta implementación de DI, es una forma básica de aprender sobre cómo
funciona, sin embargo hay bibliotecas más elaboradas y profesionales
como Ninject e inclusive el nuevo DependencyInjection de .NET.

Cambie en el `Global.asax` de `NonEmailService` a `EmailService` para
ver como funciona. 

> Recuerda que puedes instalar [Papercut](https://github.com/changemakerstudios/papercut) 
para recibir y leer los correos.

---------
DotnetEspanol