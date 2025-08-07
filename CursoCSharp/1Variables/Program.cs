// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string miCadena = "Hola, esto es una cadena";
Console.WriteLine(miCadena);

miCadena = string.Empty;
Console.WriteLine(miCadena);

/*Console.WriteLine("Meta su nombre por consola...");
string tuNombre = Console.ReadLine()!;

Console.WriteLine("Tu nombre es " + tuNombre);

Console.WriteLine("Escribe tu edad");
string tuEdad = Console.ReadLine()!;
int edad = Convert.ToInt32(tuEdad);

Console.WriteLine("Tu edad es " + edad + " y tu nombre es " + tuNombre);

string nombre = "Juan";
string apellido = "perez";

Console.WriteLine(nombre + apellido);*/

Console.WriteLine("................Numeros..................");

int numero1 = 23;
int numero2 = 44;

int resultado = numero1 + numero2;
Console.WriteLine(resultado);

Console.WriteLine("resultado: " + numero1 + numero2);

Console.WriteLine("resultado: " + Convert.ToInt32(numero1 + numero2));

Console.WriteLine(numero1 - numero2);

Console.WriteLine(numero1 * numero2);

Console.WriteLine(numero1 / numero2);

string num1 = "10";
string num2 = "10";

Console.WriteLine(num1 + num2); // Concatenación de cadenas
Console.WriteLine(Convert.ToInt32(num1) + Convert.ToInt32(num2)); // Suma de enteros

float f = 1f / 3f;
double d = 1.0 / 3.0;
decimal dec = 1m / 3m;

Console.WriteLine("Float: " + f);
Console.WriteLine("Double: " + d);
Console.WriteLine("Decimal: " + dec);

decimal salario = 1205.25m;
decimal aumentoSalarial = 10.10m;
Console.WriteLine("Aumento mal hecho: " + salario + aumentoSalarial);

float resultadoFinal = (float)(salario + aumentoSalarial);

Console.WriteLine("Aumento bien hecho: " + resultadoFinal);

Console.WriteLine("................Bools and Var..................");

bool esMayorDeEdad = false;
Console.WriteLine("Es mayor de edad: " + esMayorDeEdad);
esMayorDeEdad = true;
Console.WriteLine("Es mayor de edad: " + esMayorDeEdad);

var edad = 23; // var infiere el tipo de dato

var variableCualquiera = "Esto es una variable cualquiera";

var esHombre = true;

Console.WriteLine("...................Ejercicios..................");

/* Ejercicio 1: Un programita que pida dos numeros por pantalla , los sume y muestre su
resultado por consola. */

Console.WriteLine("Ejercicio 1: Suma de dos numeros");

//Primer metodo 

Console.WriteLine("Ingrese el primer numero: ");
string primerNumero = Console.ReadLine()!;

Console.WriteLine("Ingrese el segundo numero: ");
string segundoNumero = Console.ReadLine()!;

int resultadoSuma = Convert.ToInt32(primerNumero) + Convert.ToInt32(segundoNumero);

Console.WriteLine("El resultado de la suma es: " + resultadoSuma);

//Segundo metodo

Console.WriteLine("Ingrese el primer numero: ");
string numSuma1 = Console.ReadLine()!;

Console.WriteLine("Ingrese el segundo numero: ");
string numSuma2 = Console.ReadLine()!;

int entero1 = Convert.ToInt32(numSuma1);

int entero2 = Convert.ToInt32(numSuma2);

int resultadoSum = entero1 + entero2;

Console.WriteLine("El resultado de la suma es: " + resultadoSum);

// Ejercicio 2: Un programita igual que el anterior pero que pida tres numeros

Console.WriteLine("Ejercicio 2: Suma de tres numeros");

Console.WriteLine("Ingrese el primer numero: ");
string firstNum = Console.ReadLine()!;

Console.WriteLine("Ingrese el segundo numero: ");
string secondNum = Console.ReadLine()!;

Console.WriteLine("Ingrese el tercer numero: ");
string thirtdNum = Console.ReadLine()!;

int firstNumInt = Convert.ToInt32(firstNum);

int secondNumInt = Convert.ToInt32(secondNum);

int thirtdNumInt = Convert.ToInt32(thirtdNum);

int resTresNum = firstNumInt + secondNumInt + thirtdNumInt;

Console.WriteLine("El resultado de la suma de tres numeros es: " + resTresNum);

/* Ejercicio 3: Un programita pide al usuario dos números por consola, 
súmalos, réstalos, multiplícalos y divídelos. Muestra cada resultado en pantalla*/

Console.WriteLine("Ejercicio 3: Operaciones con dos numeros");

Console.WriteLine("Introduce el primer numero: ");
string num1Oper = Console.ReadLine()!;

Console.WriteLine("Introduce el segundo numero: ");
string num2Oper = Console.ReadLine()!;

int num1OperInt = Convert.ToInt32(num1Oper);

int num2OperInt = Convert.ToInt32(num2Oper);

int suma = num1OperInt + num2OperInt;

int resta = num1OperInt - num2OperInt;

int multi = num1OperInt * num2OperInt;

int div = num1OperInt / num2OperInt;

int resto = num1OperInt % num2OperInt;

Console.WriteLine("La Suma es: " + suma);
Console.WriteLine("La Resta es: " + resta);
Console.WriteLine("La Multiplicación es: " + multi);
Console.WriteLine("La División es: " + div);
Console.WriteLine("El Resto es: " + resto);

Console.WriteLine("Ejercicio 4 Concatenación y conversión");

/* Ejercicio 4: Un programita que pida al usuario dos números como texto, 
concaténalos y luego súmalos como enteros. Muestra ambos resultados.*/

Console.WriteLine("Introduce el primer numero: ");
string num1Concat = Console.ReadLine()!;

Console.WriteLine("Introduce el segundo numero: ");
string num2Concat = Console.ReadLine()!;

Console.WriteLine("Concatenación mal hecha: " + num1Concat + num2Concat);

int num1ConcatInt = Convert.ToInt32(num1Concat);
int num2ConcatInt = Convert.ToInt32(num2Concat);

Console.WriteLine("Concatenación bien hecha: " + (num1ConcatInt + num2ConcatInt));

/* Ejercicio 5: Un programita que declara una variable de tipo float, 
una de tipo double y una de tipo decimal con el valor 1 dividido entre 3. 
Muestra los resultados y observa las diferencias.*/

Console.WriteLine("Ejercicio 5: Tipos de datos Float, Double y Decimal");

float floatValue = 1f / 3f;
double doubleValue = 1.0 / 3.0;
decimal decimalValue = 1m / 3m; 

Console.WriteLine("Float: " + floatValue);
Console.WriteLine("Double: " + doubleValue);
Console.WriteLine("Decimal: " + decimalValue);

/* Ejercicio 6: Un programita que Pide al usuario su edad. 
Si es mayor o igual a 18, muestra "Eres mayor de edad", si no, muestra "Eres menor de edad".*/

Console.WriteLine("Ejercicio 6: Verificación de edad");

Console.WriteLine("Introduce tu edad: ");
string edadUsuario = Console.ReadLine()!;

int edadInt = Convert.ToInt32(edadUsuario);

if (edadInt <= 18)
{
    Console.WriteLine("Eres menor de edad");
}
else
{
    Console.WriteLine("Eres mayor de edad");
}

/* Ejercicio 7: Un programita que Declara tres variables usando var: una cadena,
 un número y un booleano. Muestra sus valores y tipos usando GetType().*/

Console.WriteLine("Ejercicio 7: Variables con var");

var cadenaVar = "Hola, soy una cadena";
var numeroVar = 42;
var booleanoVar = true; 

Console.WriteLine("Cadena: " + cadenaVar + ", Tipo: " + cadenaVar.GetType());
Console.WriteLine("Número: " + numeroVar + ", Tipo: " + numeroVar.GetType());
Console.WriteLine("Booleano: " + booleanoVar + ", Tipo: " + booleanoVar.GetType());

