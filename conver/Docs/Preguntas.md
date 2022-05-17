# **PREGUNTAS**

## 1. **¿Qué es un Coding Dojo?**
Es una sesión recreativa cuya primicia es resolver un problema de programación entre un grupo de personas, cuyo nivel de habilidad programación no precisamente debe ser el mismo, de manera divertida, didáctica y sin mucha presión. 
## 2. **Diferencia entre Requerimientos, Criterios de Aceptación y Escenarios de Prueba. Dar ejemplos a partir de un problema distinto a la referencia.**
**Requerimiento:**
Un requerimiento es una condición que posee o poseerá un sistema para satisfacer las necesidades de uno o varios usuarios.

    Ejemplo: El sistema permitirá crear, modificar y eliminar imágenes en una web de imágenes.

**Criterio de aceptación:**
Es el conjunto de lineamientos o pautas a cumplir por un determinado programa para considerarse que este es factible para utilizarse o no. Dichas pautas pueden estar demarcadas por el propio equipo o por su entidad empleadora.

    Ejemplo: La contraseña de un usuario debe estar cifrada en el momento de enviarse para su validación en el core.

**Escenario de pruebas:**
Son el conjunto de pruebas utilizadas para darle valides a los criterios de aceptación.

    Ejemplo: Comprobar que la contraseña efectivamente se envía cifrada.
## 3. **De dos ejemplos de requerimientos no-funcionales, y especifique cual es su categoría (seguridad, performance, portabilidad, etc.)**
Los requerimientos se clasifican en requerimientos funcionales y no-funcionales.

Estos últimos se definen como los atributos generales que poseerá un software. Dichos atributos pueden estar contenidos en las categorías como la eficiencia, seguridad y usabilidad.

Ejemplos:

    Los mensajes de nuestra aplicación de mensajería deben estar cifrados de extremo a extremo (seguridad)

    El sistema debe ser capaz de procesar n transacciones por segundo (eficiencia)
## 4. **¿Qué es TDD?**
Es una técnica de programación (cuyas siglas quieren significar en ingles Test-driven development) que consiste en volver los requisitos del proyecto en casos de prueba antes de que el software esté desarrollado. 

## 5. **¿Que son pruebas unitarias automatizadas?**
Las pruebas automatizadas son la aplicación de herramientas de software para automatizar el proceso manual de pruebas humanas y verificación de productos de software. Hoy en día, la mayoría de los proyectos de software ágiles y DevOps modernos incluyen pruebas automatizadas desde el principio. Pero para comprender completamente el valor de tal evidencia, necesitamos saber cómo era la vida antes de que se generalizara.
## 6. **¿Cuál fue el 1er framework de pruebas unitarias y para cual lenguaje fue creado?**
Un framework es un entorno de creación de software por medio de distintas herramientas. Dando como resultado poder crear herramientas dinámicas, estables y practicas.

Asi mismo, el primero de estos fue **Java Servlet** en 1997, que como su nombre indica fue creado en java. Su objetivo era brindar herramientas útiles para lidiar con servidores.
## 7. **¿Describa los componentes de la arquitectura xUnit? **
XUnit es una herramienta de prueba gratuita que sirve para probar código en c#. Posee además distintos componentes listados a continuación:

- Ejecutor de pruebas: un ejecutor de pruebas es un programa ejecutable que ejecuta pruebas implementadas utilizando el marco xUnit e informa los resultados de las pruebas.
- Casos de prueba: Los casos de prueba son la clase más elemental. Todas las pruebas unitarias se heredan de aquí.
- Dispositivo de prueba: Un dispositivo de prueba (también conocido como contexto de prueba) es un conjunto de requisitos previos o estados necesarios para ejecutar una prueba. Los desarrolladores deben establecer una buena condición conocida antes de realizar la prueba y restaurarla después de la prueba.
- Conjunto de pruebas: un conjunto de pruebas es un conjunto de pruebas que comparten el mismo dispositivo. El orden de las pruebas no es importante.
## 8. **Indique al menos tres desventajas de las pruebas unitarias automatizadas**
- Personal de desarrollo más cualificado.
- Una gran cantidad de tiempo para la implementación de dichas pruebas en aplicaciones complejas.
- Proporcionan un falso sentido de seguridad y calidad.
## 9. **Indique al menos tres ventajas de las pruebas unitarias automatizadas**
- Ayuda en la detección de errores nocontemplados.
- Retroalimentación rápida. 
- Revisión rápida.
