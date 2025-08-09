// Bucles

using System.Data;

int contador = 0;

Console.WriteLine(contador);

contador = contador + 1;
contador = contador + 1;

Console.WriteLine(contador);

contador++;
Console.WriteLine(contador);

//***************************************************************************************************

for (int i = 0; i < 5; i++)
{
    /* El bucle for inicia en i vale 0
    y el bucle se repite hasta que i sea menor que cinco 5...osea 4
    y lo va incrementando de uno en uno
    */
    int valorDeI = i;
    Console.WriteLine($"Valor de {valorDeI}");
}

//***************************************************************************************************

int j = 0;

while (j < 5)
{
    Console.WriteLine($"Valor de j: {j}");
    j++;
}

//***************************************************************************************************

int k = 0;

do
{
    Console.WriteLine($"Valor de k: {k}");
    k++;
} while (k < 5);

//***************************************************************************************************

Console.WriteLine("**********************Ejercicios bucle for**********************");

Console.WriteLine("**********************Ejercicio 1**********************");

/* Ejercicio 1: bucle for hasta 10 y que indique si el numero (el incremento) es par o impar */

for (int i = 0; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"El numero {i} es par");
    }
    else
    {
        Console.WriteLine($"El numero {i} es impar");
    }
}


Console.WriteLine("**********************Ejercicio 2**********************");

// Muestra los números del 1 al 20 en pantalla usando un bucle

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"Numero {i}");
}

Console.WriteLine("**********************Ejercicio 3**********************");

// Suma todos los números del 1 al 100 y muestra el resultado.

int suma = 0;

for (int i = 1; i <= 100; i++)
{
    suma += i; //suma = suma +i
}

Console.WriteLine($"La suma de los numeros del 1 al 100 es: {suma}");

Console.WriteLine("**********************Ejercicio 4**********************");

//Muestra los números pares del 2 al 50 usando un bucle for

for (int i = 2; i <= 50; i += 2)
{
    Console.WriteLine($"Numero par: {i}");
}

Console.WriteLine("**********************Ejercicio 5**********************");

// Calcula el factorial de un número introducido por el usuario usando un bucle for

Console.WriteLine("Introduce un numero para calcular su factorial: ");

long numero = long.Parse(Console.ReadLine()!);

long factorial = 1;

for (long i = 1; i <= numero; i++)
{
    factorial *= i; // factorial = factorial * i
}

Console.WriteLine($"El factorial de {numero} es: {factorial}");

Console.WriteLine("**********************Ejercicio 6**********************");

// Muestra la tabla de multiplicar de un número introducido por el usuario usando un bucle for

Console.WriteLine("Introduce un numero para mostrar su tabla de multiplicar: ");

int numeroTabla = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
}

Console.WriteLine("**********************Ejercicios bucle while**********************");

Console.WriteLine("**********************Ejercicio 1**********************");

// Pide números al usuario hasta que escriba un número negativo y muestra la suma de todos los números introducidos.

int sumaWhile = 0;

while (true)
{
    Console.WriteLine("Introduce un numero (negativo para salir): ");

    int numeroWhile = int.Parse(Console.ReadLine()!);

    if (numeroWhile < 0)
    {
        break; // Sale del bucle si el numero es negativo
    }

    sumaWhile += numeroWhile; //sumaWhile = sumaWhile + numeroWhile
}

Console.WriteLine($"La suma de los numeros introducidos es: {sumaWhile}");

Console.WriteLine("**********************Ejercicio 2**********************");

//Muestra los números del 10 al 1 en orden descendente usando un bucle while.

int numWhileDescen = 10;

while (numWhileDescen >= 1)
{
    Console.WriteLine($"Numero: {numWhileDescen}");
    numWhileDescen--;
}

Console.WriteLine("**********************Ejercicio 3**********************");

//Pide al usuario una contraseña hasta que escriba la correcta.

string contraseñaCorrecta = "1234";

while (true)
{
    Console.WriteLine("Introduce una contraseña: ");

    string contraseñaUsuario = Console.ReadLine()!;

    if (contraseñaUsuario == contraseñaCorrecta)
    {
        Console.WriteLine("Contraseña correcta, acceso autorizado.");
        break; //Sale del bucle si la contraseña es correcta
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta, intenta de nuevo.");
    }
}

Console.WriteLine("**********************Ejercicio 4**********************");

//Muestra la serie de Fibonacci hasta que el valor supere 1000.

int a = 0, b = 1;

Console.WriteLine("Serie de Fibonacci:");

while (a <= 1000)
{
    Console.WriteLine(a);
    int temp = a + b;
    a = b;
    b = temp;
}

Console.WriteLine("**********************Ejercicio do-while**********************");

Console.WriteLine("**********************Ejercicio 1**********************");

// Pide al usuario un número mayor que 100; repite hasta que lo consiga.

int numeroDoWhile;

do
{
    Console.WriteLine("Introduce un numero mayor que 100: ");

    numeroDoWhile = int.Parse(Console.ReadLine()!);


} while (numeroDoWhile <= 100);

Console.WriteLine($"Has introducido el numero: {numeroDoWhile}, que es mayor que 100");

Console.WriteLine("**********************Ejercicio 2**********************");

//Muestra un menú de opciones y repite hasta que el usuario elija salir.

int opcion;

do
{
    Console.WriteLine("Menú de opciones: ");
    Console.WriteLine("1. Opción 1");
    Console.WriteLine("2. Opción 2");
    Console.WriteLine("3. Opción 3");
    Console.WriteLine("4. Salir");
    Console.Write("Elige una opción: ");
    opcion = int.Parse(Console.ReadLine()!);
} while (opcion != 4);

Console.WriteLine("Has salido del menú");

Console.WriteLine("**********************Ejercicio 3**********************");

// Pide al usuario letras y cuenta cuántas vocales introduce hasta que escriba una ‘x’.

int contarVocal = 0;

char letra;

do
{
    Console.WriteLine("Introduce una letra (escribe 'x' para salir): ");

    letra = Console.ReadLine()![0]; // Lee la primera letra introducida

    if ("aeiouAEIOU".Contains(letra)) // Verifica si la letra es una vocal
    {
        contarVocal++;
    }
} while (char.ToLower(letra) != 'x');

Console.WriteLine($"Has introducido {contarVocal} vocales");

Console.WriteLine("**********************Ejercicio 4**********************");

// Pide al usuario su edad y repite hasta que introduzca un valor válido (mayor que 0).

int edad;

do
{
    Console.WriteLine("Introduce tu edad (mayor que 0): ");

    edad = int.Parse(Console.ReadLine()!);

}while (edad <= 0);

Console.WriteLine($"Tu edad es: {edad} años");

Console.WriteLine("**********************Ejercicio 5**********************");

// Pide al usuario números y muestra el mayor introducido; termina cuando escriba -1.

int numeroMayor = int.MinValue;

int numUsuario;

do
{
    Console.WriteLine("Introduce un numero (-1 para salir): ");

    numUsuario = int.Parse(Console.ReadLine()!);

    if (numUsuario > numeroMayor && numUsuario != -1)
    {
        numeroMayor = numUsuario; // Actualiza el mayor si el número introducido es mayor
    }

} while (numUsuario != -1);

Console.WriteLine($"El numero mayor introducido es: {numeroMayor}");




