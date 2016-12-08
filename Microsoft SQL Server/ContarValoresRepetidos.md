# Contar cantidad de veces que se repite un valor en una columna

Consulta con la cual podremos contar la cantidad de veces que se repite los valores de una columna en una tabla puede ser utilizada de diferentes maneras, dependiendo de nuestro caso, por ejemplo, puede ser útil para:
* Contar las ventas que han realizado los vendedores (si es una tabla de ventas)
* Encontrar valores duplicados, lo cual podría ser una oportunidad de mejora en el diseño de la Base de Datos si, según el negocio no debería aceptar valores duplicados en esa columna.

También en la cláusula SELECT Y GROUP BY puedes colocar campos relevantes para agrupar y tener una información más completa.


```sql
SELECT COUNT(Columna_a_contar)
FROM Tabla
GROUP BY Columna_a_contar
HAVING COUNT(Columna_a_contar)> 1
```
