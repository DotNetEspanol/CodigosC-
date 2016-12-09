# Repositorio de codigos y scripts DontNet en Espanol

En este Repositorio encontraras y podras compartir cortes de codigo y proyectos con tecnologia .NET

## Como colaborar

*   Fork del repositorio
*   Clonar el repositorio
*   Actualizar la rama master
*   Hacer los cambios
*   Hacer un Pull Request

## Fork del repositorio

El primer paso es hacer "Fork" del repositorio.

Después de tener el repositorio en nuestra cuenta, seleccionar la dirección del repositorio "SSH o HTTP" y clonar:

` git clone git clone https://github.com/User/NombreRepo.git`

Dentro de la carpeta que genera, comprobar la URL del repositorio:

` git remote -v`

Antes de realizar modificaciones agregar la URL del repositorio original del proyecto:

` git remote add update https://github.com/DotNetEspanol/CodigosC-.git`

Y luego la URL de tu repositorio Forkeado

`git remote add origin https://github.com/User/NombreRepo.git`
Comprobar

` git remote -v`

## Hacer cambios

Realizar todos los cambios que se desea hacer al proyecto.

Agregar los archivos y hacer un commit

`git add archivo *`
`git commit -m "descripcion de los cambios"`

Después de realizar el commit hacer el push hacia nuestro repositorio indicando la rama que hemos creado.

`$ git push origin master`

## Para mantener nuestro repositorio Forkeado actualizado con el original

Hacemos para obtener los últimos cambios del Repo Original:

`$ git pull -r update master`


