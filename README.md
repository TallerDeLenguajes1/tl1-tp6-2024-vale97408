# Taller De Lenguajes
## Trabajo Práctico Nro 6

###                            *_Desarrollo_* 

### _¿String es una tipo por valor o un tipo por referencia?_

#### String es un tipo por referencia, pero su comportamiento puede parecerse al de un tipo por valor debido a su inmutabilidad. Aunque internamente es tratado como un tipo por referencia, su uso y manipulación se asemejan al de un tipo por valor.


### _¿Qué secuencias de escape tiene el tipo string?_

#### Las secuencias de escape en el tipo string incluyen:

#### \' : comilla simple
#### \" : comilla doble
#### \ \ : barra invertida
#### \0 : NULL
#### \a : alerta (campanita)
#### \b : retroceso (borra el último carácter)
#### \f : avance de página
#### \n : nueva línea (salta a la línea siguiente)
#### \r : retorno de carro (va al principio de la línea)
####  \t : tabulación horizontal
#### \v : tabulación vertical


### _¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?_
#### Si se utiliza el $ antes de una cadena, indica que es una cadena interpolada. La interpolación permite incluir variables dentro de la cadena, que serán reemplazadas por sus valores en tiempo de ejecución mediante la sintaxis ${}. Por otro lado, si se utiliza el carácter @ antes de una cadena de texto, se crea una cadena literal verbatim. Esto significa que el texto es interpretado literalmente, incluyendo los caracteres de escape como barras invertidas, sin procesar estos caracteres de escape.