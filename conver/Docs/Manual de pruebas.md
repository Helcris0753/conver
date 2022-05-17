# Test Manual

This testing manual for the Hindu-Arabic to Roman number converter has the objective of showing how the application will be tested. Under this premise, the application must meet the following requirements:

1. Letters cannot be entered.

The code will detect if you want to enter letters, so it will inform the user that it is not allowed, for obvious reasons, and that he proceeds to make a new entry.
For example:
~~~
Bienvenido al convertidor de numeros indoarábigos a romanos.
Por favor, introduzca un numero: A

Entrada no valida!
Letra(s) detectada(s)!
~~~
2. Negative numbers cannot be entered.

Nor can we enter negative numbers.

For example:

~~~
Bienvenido al convertidor de numeros indoarábigos a romanos.
Por favor, introduzca un numero: -1234

Entrada no valida!
El valor no puede ser negativo.
~~~

3. Numbers greater than 99,999 or 0 cannot be entered.
If for another case, we enter numbers greater than 99,999 or 0, the code will alert us of this.

For example:
~~~
Bienvenido al convertidor de numeros indoarábigos a romanos.
Por favor, introduzca un numero: 0

Entrada no valida!
El valor no puede ser '0' o ser mayor que '99,999'.
~~~

Or:

~~~
Bienvenido al convertidor de numeros indoarábigos a romanos.
Por favor, introduzca un numero: 123.456,6789

Entrada no valida!
El valor no puede ser '0' o ser mayor que '99,999'.
~~~