# Listar todas las tablas de una Base de Datos

Consulta con la cual podremos obtener el nombre de todas las tablas de una base de datos en especifico
```sql
USE TuBaseDatos
GO

SELECT name
FROM sys.sysobjects
WHERE TYPE = 'U'
ORDER BY  name
```

Referencia: [sys.sysobjects](https://msdn.microsoft.com/es-es/library/ms177596.aspx)