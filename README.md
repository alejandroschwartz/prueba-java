# Prueba de Java

![imagen de proyecto](https://i.imgur.com/PFvDZ38.png)

- Imagen de entrada y salida del proyecto.

---

## Descripcion del ejercicio.

“El alfabeto español contiene 26 caracteres y los teléfonos móviles sólo tienen diez dígitos en el teclado. Varias letras se mapean en cada tecla numérica, como se muestra en la imagen inferior, de forma que se pueda escribir un mensaje con pulsaciones repetitivas. Por ejemplo, para insertar el carácter B, se deberá presionar 22. Para introducir una secuencia de dos caracteres a partir de la misma tecla, el usuario debe hacer una pausa antes de pulsar el botón una segunda vez. Por ejemplo, 2 2 indica AA mientras que 22 indica B (se muestra un "carácter de espacio" para indicar una pausa).
Debes crear un programa que calcule la secuencia de teclas que hay que pulsar para escribir un cierto mensaje.”

---

## Mi idea para la resolución.

1. De entrada recibo un texto y retorno los numeros correspondiente con una separación. Para los espacios del texto de entrada coloque un salto de linea en el resultado.
2. Recibo el dato por parte del usuario.
3. Corto la cadena de texto ingresada con .split( ) y la coloco dentro de un array.
4. Paso ese array por una función con un switch para comparar las letras con los números a devolver en otro array.
5. Por último es array lo convierto nuevamente a cadena de texto para mostrar como resultado en pantalla.  