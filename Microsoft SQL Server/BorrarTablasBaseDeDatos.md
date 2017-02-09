# Borrar todas la tablas y omitir errores de Refenrencias de Integridad

El procedimiento almacenado sp_MSForEachTable nos ayuda a ejecutar comandos en una datos aplicandolo solo a las tablas.
En este caso usaros el sp_MSForEachTable para borrar todas las tablas desactivando las **Refenrencias de Integridad** (_**CONSTRAINT**_) 

Seleccionamos la base de datos con la cual vamos a trabajar

```
USE [BaseDeDatos]
GO
```

Desactivamos los Refenrencias de Integridad en la base de datos

```
EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
GO
```

Bye Bye tablas

```
EXEC sp_MSforeachtable @command1 = "DROP TABLE ?"
GO
```

Otra vez, Bye Bye tablas. 
**Esta parte es, para asegurarnos que se borraron las tablas**

```
EXEC sp_MSforeachtable @command1 = "DROP TABLE ?"
GO
```

Activamos los Refenrencias de Integridad en la base de datos

```
EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'
GO
```
