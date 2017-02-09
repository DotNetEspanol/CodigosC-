# Sistemas de Administración de Empleados

El proyecto tiene como objetivo motivar las personas que están entrando en el mundo de la ingeniería de software o simplemente quieren poner sus conocimientos, así como tan bien los que no somos tan nuevos en el área.

Trabajemos en nuevas tecnologías. Probar algo que estemos aprendiendo o poner a prueba un conocimiento viejo.

En ese sentido está abierto a cualquier tecnología/lenguaje. 
Por ejemplo: 

Desde

*   Java con Spring,
*   Ruby con el Framework que les dé la gana,
*   ASP.Net con MVC,
*   MEAN.io / MEAN.JS,
*   Python con Flask,
*   PHP con Laravel,
*   Cualquiera con Cual Quieran

hasta ‘chunflai’, por decir algo.

**Como subir tu proyecto:**
*	Hacer un **FORK**.
*	Crear una carpeta dentro de: /Retos/1. Sistemas de Administración de Empleados/**_TU_ Proyecto + Nombre **.

> Ejemplo:
**/Retos/1. Sistemas de Administración de Empleados/Gestion Clientes - Dionny Prensa**

*	Hacer el **PULL REQUEST**.
 
####El mismo comprenderá aspectos tales como:

*   Entender el requerimiento
*   Levantamiento de Información
*   Definir herramientas / tecnologías a utilizar
*   Diseño de la Base de datos (‘Payola’ para el tremendo curso de Elena López. Si no lo estás tomando, te invito. Clic -> [Aprendiendo BD con SQL Server](https://www.facebook.com/groups/1600079906954837)
*	Desarrollo/Programación (CODIGO) **Código documentado**
*	Pruebas de Calidad

####El sistema abarcará una solución completa para el manejo de empleados

*	CRUD Empleados
	*	Empleados divididos en 5 niveles: Nivel 1, Nivel 2, … Nivel 5
*	CRUD Usuarios: Para la gente de RRHH, que también son empleados
	*	Tipos de Usuarios. 
		*	Rol 1 = Analista de RRHH
		*	Rol 2 = Coordinador
		*	Rol 3 = Gerente
*	Pagos por horas trabajadas
	*	Horas NORMALES Semanales
		*	Máximo 35 horas semanales
		*	De lunes a viernes
		*	9am – 4pm
*	Horas por empleados
	*	Nivel 1 = RD$ 250 
		*	35 * 250 = 8,750 Semanal
	*	Nivel 2 = RD$ 350 
		*	35 * 250 = 12,250 Semanal
	*	Nivel 3 = RD$ 400
		*	35 * 250 = 14,000 Semanal
	*	Nivel 4 = RD$ 500
		*	35 * 250 = 17,500 Semanal
	*	Nivel 5 = RD$ 600
		*	35 * 250 = 21,000 Semanal


> Ejemplo:
		Horas semanales **Normales**

| Grupo   | Horas | Precio * Hora | Semanal | Quincenal | Mensual |
| :-----: | :---: | :-----------: | :-----: | :-------: | :-----: |
| Sueldo Nivel 1 | 35 | DOP$ 250 | DOP$ 8,750 | DOP$ 17,500 | DOP$ 35,000 |
| Sueldo Nivel 2 | 35 | DOP$ 350 | DOP$ 12,250 | DOP$ 24,500 | DOP$ 49,000 |
| Sueldo Nivel 3 | 35 | DOP$ 400 | DOP$ 14,000 | DOP$ 28,000 | DOP$ 56,000 |
| Sueldo Nivel 4 | 35 | DOP$ 500 | DOP$ 17,500 | DOP$ 35,000 | DOP$ 70,000 |
| Sueldo Nivel 5 | 35 | DOP$ 600 | DOP$ 21,000 | DOP$ 42,000 | DOP$ 84,000 |

*	Horas Extras Semanales
	*	Máximo 10 Semanales
		*	De sábado a domingo
			*	Hora = RD$ 80 para todos los niveles
			*	9am – 4pm en la hora que quiera el empleado.
			*	La empresa cubre viatico de RD$ 600, si y solo si empleado trabaja más de 4 horas seguidas en el fin de semana.	

> Ejemplo:
		Horas semanales **Extras**

| Grupo   | Horas | Precio * Hora | Semanal | Quincenal | Mensual |
| :-----: | :---: | :-----------: | :-----: | :-------: | :-----: |
| Extra Nivel 1 | 10 | DOP$ 150 | DOP$ 1,500 | DOP$ 3,000 | DOP$ 6,000 |
| Extra Nivel 2 | 10 | DOP$ 195 | DOP$ 1,950 | DOP$ 3,900 | DOP$ 7,800 |
| Extra Nivel 3 | 10 | DOP$ 215 | DOP$ 2,150 | DOP$ 4,300 | DOP$ 8,600 |
| Extra Nivel 4 | 10 | DOP$ 260 | DOP$ 2,600 | DOP$ 5,200 | DOP$ 10,400 |
| Extra Nivel 5 | 10 | DOP$ 300 | DOP$ 3,000 | DOP$ 6,000 | DOP$ 12,000 |

*	Sueldo 13
	*	Completo: Solo aplica a personas que tengan mínimo 1 año, cumplido
	*	Mitad: Solo aplica a personas que tengan 6 Meses cumplidos
	*	%:  Cantidad de Meses * 10
Ejemplo:
4½ Meses = 4.5*10 = 45% de su sueldo actual

*	Comida:
	*	La empresa subsidia el 60% del almuerzo, desayuno consumido en la cafetería/comedor de la empresa.

