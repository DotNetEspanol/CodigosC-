# Consultar información acerca de objetos de una base de datos

El procedimiento almacenado sp_help nos ayuda a conocer la información acerca de objetos, como tablas, procedimientos almacenados, funciones, trigger, etc.

Mostrando cierta información como:
* Cuando fue creado un objeto
* Quién es el propietario
* El tipo de objeto

Si hablamos de tablas nos muestra información acerca de sus columnas:
* Nombre de la columna
* Tipo de datos
* Si es un calculado o no
* Tamaño
* Precisión
* Escala

Entre otras informaciones. Es muy útil, especialmente con las tablas.

Para utilizarlo solo tenemos que llamar el procedimiento sp_help seguido del nombre del objeto entre comillas simples (no es obligatorio, pero si recomendado).

```sql
sp_help 'NombreObjeto'
```

Referencia del Store Procedure [sp_help](https://msdn.microsoft.com/es-es/library/ms187335.aspx)
