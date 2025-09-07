//Declara dos números enteros, asígnales valores y muestra su suma, resta, multiplicación y división.

int numeroUno = 46;
int numeroDos = 34;

int resultado = numeroUno + numeroDos;

Console.WriteLine($"La suma de {numeroUno} y {numeroDos} es: {resultado}");

int resultado1 = numeroUno - numeroDos;

Console.WriteLine($"La resta de {numeroUno} y {numeroDos} es: {resultado1}");

int resultado2 = numeroUno * numeroDos;

Console.WriteLine($"La multiplicacion de {numeroUno} y {numeroDos} es: {resultado2}");

int resultado3 = numeroUno / numeroDos;

Console.WriteLine($"La division de {numeroUno} y {numeroDos} es: {resultado3}");

int resultado4 = numeroUno % numeroDos;

Console.WriteLine($"El resto del {numeroUno} y {numeroDos} es: {resultado4}");

//Pide al usuario su edad y muestra un mensaje diciendo: “Eres mayor de edad” si es >= 18. “Eres menor de edad” si no lo es.

Console.WriteLine("Introduce tu edad");

int edad = int.Parse(Console.ReadLine()!);

if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}
else
{
    Console.WriteLine("Eres menor de edad");
}

//Calcula el área de un círculo pidiendo el radio al usuario

Console.WriteLine("Introduce el radio para calcular el area del circulo");

int radio = int.Parse(Console.ReadLine()!);

double area = Math.PI * Math.Pow(radio, 2);

Console.WriteLine($"El area del circulo con radio {radio} es: {area}");

//Pide un número y muestra si es par o impar

Console.WriteLine("Introduce un numero para ver si es par o impar");

int numero = int.Parse(Console.ReadLine()!);

if (numero % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}
