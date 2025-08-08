//Condicionales y operadores lógicos

int edadPersona1 = 42;
int edadPersona2 = 75;

/* el if lo que hace realmente es esperar que en esta condicion:

if (true)
   se cumpla la condicion para ejecutar el bloque de codigo que esta dentro de las llaves.
   Si no se cumple, no se ejecuta...y si hay un else, se ejecuta el bloque de codigo que esta dentro del else.
   Si no hay else, simplemente no se ejecuta nada.  
*/

if (edadPersona1 < edadPersona2)
{
    Console.WriteLine("La persona 1 es menor que la persona 2");
}

Console.WriteLine("Ahora al reves");

if (edadPersona1 > edadPersona2)
{
    Console.WriteLine("La persona 1 es mayor que la persona 2");
}

Console.WriteLine("No aparece nada por que la condición no se cumple...y el programa sigue ejecutandose...");

Console.WriteLine("Ahora con un else...");

if (edadPersona1 > edadPersona2)
{
    Console.WriteLine("La persona 1 es mayor que la persona 2");
}
else
{
    Console.WriteLine("Esto es el else...La persona 1 no es mayor que la persona 2");
}

Console.WriteLine("Ahora con una igualdad...");

if (edadPersona1 == edadPersona2)
{
    Console.WriteLine("La persona 1 es igual que la persona 2");
}
else
{
    Console.WriteLine("La persona 1 no es igual que la persona 2");
}

edadPersona1 = 75;
edadPersona2 = 75;

if (edadPersona1 >= edadPersona2)
{
    Console.WriteLine("La persona 1 es mayor o igual que la persona 2");
}


string sexoPersona1 = "hombre";

if ((edadPersona1 >= edadPersona2) && (sexoPersona1 == "hombre"))
{
    Console.WriteLine("La persona 1 es mayor que la persona 2 y es hombre");

}

if ((edadPersona1 > edadPersona2) || (sexoPersona1 == "hombre"))
{
    Console.WriteLine("La persona 1 es mayor que la persona 2 o es hombre");
}

int x = 10;
int y = 5;
int z = 3;

if (x > 5 && (y > 10 || z == 3))
{
    Console.WriteLine("x es mayor que 5 y y es mayor que 10 o z es igual a 3");
}


string sexo = "hombre";

if (sexo != "mujer")
{
    Console.WriteLine("si es distinto de hombre");
}

bool usuarioAlta = true;

if (usuarioAlta)
{
    Console.WriteLine("El usuario está dado de alta");
}

bool usuarioPremium = true;

if (usuarioAlta && usuarioPremium)
{
    Console.WriteLine("El usuario es premium");
}

Console.WriteLine("*************************switch*************************");

string nacionalidad = "uruguayo";

if (nacionalidad == "dominicano")
{
    Console.WriteLine("es dominicano");
}
else if (nacionalidad == "argentino")
{
    Console.WriteLine("es argentino");
}
else if (nacionalidad == "español")
{
    Console.WriteLine("es español");
}
else
{
    Console.WriteLine("nacionalidad desconocida");
}

//Hay una manera mas sencilla de hacer esto que es con un swich... else if esta bien si son pocas condiciones.

nacionalidad = "español";

switch (nacionalidad)
{
    case "dominicano":
        Console.WriteLine("es dominicano");
        break;

    case "argentino":
        Console.WriteLine("es argentino");
        break;

    case "español":
        Console.WriteLine("es español");
        break;

    default:
        Console.WriteLine("nacionalidad desconocida");
        break;
}

/* 
ejercicio1
Escribe un programa que ingrese por teclado la edad, el nombre y el sexo.
si es mayor de 18 y es hombre, que muestre "Felicidades {nombre}, eres mayor de edad y eres hombre".
Si es mayor de 18 y es mujer, que muestre "Felicidades {nombre}, eres mayor de edad y eres mujer".
Si no se cumple ninguna de las condiciones anteriores, que muestre el mensaje "Lo sentomos {nombre}, no eres mayor de edad o no eres hombre/mujer".

ejercicio2
programa que busque en la cadena "esto es una cadena de prueba por que estoy empezando a programar en Csharp" 
las palabras "cadena" y "programar" y muestre un mensaje indicando si las encontró o no.
*/

Console.WriteLine("**************************Ejercicios**************************");

Console.WriteLine("**************************Ejercicio 1**************************");

Console.WriteLine("Ingrese su nombre: ");

string nombre = Console.ReadLine()!;

Console.WriteLine("Ingrese su edad: ");

int edad = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ingrese su sexo (hombre/mujer); ");

string sexoo = Console.ReadLine()!;

if (edad >= 18 && sexoo == "hombre")
{
    Console.WriteLine($"Felicidades {nombre}, eres mayor de edad y eres hombre");
}
else if (edad >= 18 && sexoo == "mujer")
{
    Console.WriteLine($"Felicidades {nombre}, eres mayor de edad y eres mujer");
}
else
{
    Console.WriteLine($"Lo sentimos {nombre}, no eres mayor de edad");
}

Console.WriteLine("**************************Ejercicio 2**************************");

string cadena = "esto es una cadena de prueba por que estoy empezando a programar en Csharp";

string palabra1 = "cadena";
string palabra2 = "programar";

if (cadena.Contains(palabra1))
{
    Console.WriteLine($"La palabra {palabra1} fue encontrada en la cadena");
}
if (cadena.Contains(palabra2))
{
    Console.WriteLine($"La palabra {palabra2} fue encontrada en la cadena");
}
if (cadena.Contains(palabra1) && cadena.Contains(palabra2))
{
    Console.WriteLine($"Las palabras {palabra1} y {palabra2} fueron encontradas en la cadena");
}
else
{
    Console.WriteLine($"Las palabras {palabra1} y {palabra2} no fueron encontradas en la cadena");
}

Console.WriteLine("**************************Ejercicio 3**************************");

//Pide al usuario un número y muestra si es positivo, negativo o cero.

Console.WriteLine("Ingrese un Numero: ");

int numero = int.Parse(Console.ReadLine()!);

if (numero > 0)
{
    Console.WriteLine($"El numero {numero} es positivo");
}
else if (numero < 0)
{
    Console.WriteLine($"El numero {numero} es negativo");
}
else
{
    Console.WriteLine($"El numero {numero} es cero");
}

Console.WriteLine("**************************Ejercicio 4**************************");

//Solicita al usuario dos números y muestra cuál es el mayor, o si son iguales.

Console.WriteLine("Ingrese un primer numero");

int numero1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ingrese un segundo numero");

int numero2 = int.Parse(Console.ReadLine()!);

if (numero1 > numero2)
{
    Console.WriteLine($"El numero {numero} es mayor que el numero {numero2}");
}
else if (numero1 < numero2)
{
    Console.WriteLine($"El numero {numero1} es menor que el numero {numero2}");
}
else
{
    Console.WriteLine($"Los numeros {numero1} y {numero2} son iguales");
}

Console.WriteLine("**************************Ejercicio 5**************************");

//Pide al usuario una letra y muestra si es una vocal o una consonante.

Console.WriteLine("Ingrese una letra: ");

char letra = char.Parse(Console.ReadLine()!);

if ((letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u'))
{
    Console.WriteLine($"La letra {letra} es una vocal");
}
else
{
    Console.WriteLine($"La letra {letra} es una consonante");
}

Console.WriteLine("**************************Ejercicio 6**************************");

//Solicita al usuario su año de nacimiento y muestra si es mayor de edad (18 años o más) o no.

Console.WriteLine("Ingrese su año de nacimiento: ");

int anioNacimiento = int.Parse(Console.ReadLine()!);

int anioActual = DateTime.Now.Year;

if ((anioActual - anioNacimiento) >= 18)
{
    Console.WriteLine($"Usted es mayor de edad, tiene {anioActual - anioNacimiento} años");
}
else
{
    Console.WriteLine($"Usted es menor de edad, tiene {anioActual - anioNacimiento} años");
}

Console.WriteLine("**************************Ejercicio 7**************************");

//Pide al usuario un año y muestra si es bisiesto o no.

Console.WriteLine("Ingrese un año: ");

int anio = int.Parse(Console.ReadLine()!);

if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
{
    Console.WriteLine($"El año {anio} es bisiesto");
}
else
{
    Console.WriteLine($"El año {anio} no es bisiesto");
}