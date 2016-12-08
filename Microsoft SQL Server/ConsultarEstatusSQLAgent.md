# Consultar el estatus del SQL Server Agent

El procedimiento almacenado extendido xp_servicecontrol nos puede servir para "controlar" servicios relacionados con SQL Server, en este caso el SQL Server Agent, donde podremos consultar si esta iniciado o no, también se puede iniciar o detener el mismo. 

Este procedimiento almacenado extendido recibe dos parámetros, el primer parámetro recibe uno de estos valores:

* **querystate**: devuelve el estado del servicio
* **start**: inicia el servicio si no está iniciado
* **stop**: detiene el servicio si está iniciado
* **pause**: pausa un servicio que esté iniciado
* **continue**: continua un servicio pausado

El segundo parámetro es el nombre del servicio, en nuestro caso 'SQLSERVERAGENT'

Saber el estatus actual de SQL Server Agent:
```sql
xp_servicecontrol 'querystate','MSSQLServer'
```

En las propiedades del agente es posible configurar alertas para que nos indique cuando el servicio se ha detenido, pero si no somos el administrador del servidor o no tenemos la posibilidad de configurarlo esta consulta nos puede ser útil.

También es posible crear una consulta que inicie un servicio si este no se está ejecutando.
