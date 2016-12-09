# Consultar el tamaño de una Base de Datos o tabla

El procedimiento almacenado sp_spaceused nos ayuda a conocer información como el espacio en disco utilizado y el espacio reservado de una Base de Datos o Tabla, en el caso de las tablas, nos indica la cantidad de registros que esta tiene.

Espacio de la base de datos en uso:
```sql
USE BaseDatos
GO

sp_spaceused
```

Espacio utilizado de la tabla indicada:
```sql
USE BaseDatos
GO

sp_spaceused 'NombreTabla'
```

Referencia del Store Procedure [sp_spaceused](https://msdn.microsoft.com/es-es/library/ms188776.aspx)

