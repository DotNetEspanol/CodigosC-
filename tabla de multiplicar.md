# Codigo de como obtener la tabla de multiplicar con C#
### Tutorial v.10 www.ymatias.com
  
 Les compartiré el código fuente como obtener las tablas de multiplicar del 1 al 9

## Ejemplo de codigo

```csharp
static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero del 1 al 9");
            try
            {
                numero = Int32.Parse(Console.ReadLine());
                if ( numero >= 1 && numero <= 9 )
                {
                    for (int i = 1; i <= 10; i++)
                    {                        
                        Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
                    }
                }else {
                    Console.WriteLine("El número esta fuera de rango comprendido");
                }

            }
            catch {
                Console.WriteLine("ERROR: debe ingresar un numero entero que comprenda del 1 al 9");                
            }

            Console.WriteLine("Presione cualquier tecla para terminar el programa");
            Console.ReadKey();
        }
```