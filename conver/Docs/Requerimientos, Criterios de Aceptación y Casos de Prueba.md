# Requerimientos, Criterios de Aceptación y Casos de Prueba

## Requerimientos
Un requerimiento es aquello que debe de cumplir un aplicacion.

### Requerimientos funiconales:

Los requisitos funcionales describen lo que debe hacer un sistema de software. Define, por tanto, una función de un sistema de software.

En el caso del **convertidor de numeros indoarábigos a romanos**, estos requisitos pueden ser los siguientes:

- Los numeros proporcionandos son utilizados de manera eficaz. 
- La aplicacion no se cae ante ninguna circunstancia (si introducimos letras, por ejemplo).

### Requerimientos funiconales:

El requisito no funcional da el comportamiento general del sistema o su componente y no en función. Es decir, dice sobre 'qué debería ser un sistema' en lugar de 'qué debería hacer un sistema'.

Entre los requerimientos no funcionales:

- Eficiencia en la ejecucion. Al tratarse de una aplicacion sencilla, esta suele ser rapida.
- La aplicacion es muy entendible e intiuitiva.
- La aplicacion, al contemplar todos sus posibles caidas al ser muy simple, resulta ser muy fiable.
---

## Criterios de Aceptación

Los criterios de aceptación definen los requisitos del Product Owner sobre cómo debe comportarse la aplicación para que una determinada acción se pueda llevar a cabo, normalmente por parte de un usuario de la aplicación.

Por ejemplo:

- **Dado** que el usuario está en la parte de la introducir el numero **cuando** introduzca el numero **entonces** se el proporciona el numero convertido a su forma romana.

- **Dado** que el usuario está en la parte en la que se le pregunta si desea salir **cuando** seleccione que desee salir **entonces** se le notificará que ha salido.

---
## Casos de Prueba

Un caso de prueba es un conjunto de acciones que se ejecutan para verificar una característica o funcionalidad particular de una aplicación de software. 

Caso de prueba:
1. 
- **ID del caso de prueba:** 01
- **Parte del escenario de prueba:** Introducir datos
- **Pasos de prueba a realizar:**
~~~
    1. Ejecutar la aplicacion.
    2. Introducir datos.
    3. Esperar al output de la aplicacion.
    4. Comprobar si la salida es valida. 
~~~
- **Datos de prueba:** 14
- **Resultados esperados:** XIV
- **Resultados reales:** XIV
- **Resultado de la prueba (exitoso o no):** Exitoso

2. 
- **ID del caso de prueba:** 02
- **Parte del escenario de prueba:** Salir de la aplicación.
- **Pasos de prueba a realizar:**
~~~
    1. Ejecutar la aplicacion.
    2. Introducir datos.
    3. Esperar al output de la aplicacion.
    4. Esperar a que se nos pregunte si deseamos salir.
    5. Seleccionar la opcion de salir de aplicacion.
~~~
- **Datos de prueba:** Y
- **Resultados esperados:** Un output que notifique que se ha salido de la aplicacion
- **Resultados reales:** Un output que notificó que se ha salido de la aplicacion
- **Resultado de la prueba (exitoso o no):** Exitoso
