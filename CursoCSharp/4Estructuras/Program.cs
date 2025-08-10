// Estructuras

using System.ComponentModel;

Console.WriteLine("*************************Array*************************");

string[] frutas = { "manzana", "banana", "cereza" };

// frutas[0] = "manzana";
// frutas[1] = "banana";
// frutas[2] = "cereza";
/*
Console.WriteLine(frutas[0]);
Console.WriteLine(frutas[1]);
Console.WriteLine(frutas[2]);
*/
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(frutas[i]);
}

Console.WriteLine("***********");

int[] edades = { 25, 5, 10, 2 };

int edadAcumulada = 0;

for (int i = 0; i < edades.Length; i++)
{
    edadAcumulada = edadAcumulada + edades[i];
}
Console.WriteLine($"Edad acumulada: {edadAcumulada}");

Console.WriteLine("***********");

Console.WriteLine("*************************Listas*************************");

List<string> nombres = new List<string>();

nombres.Add("Juan");
nombres.Add("Pedro");
nombres.Add("Maria");

Console.WriteLine(nombres[2]);

if (nombres.Contains("Pedro"))
{
    nombres.Remove("Pedro");
}

// Console.WriteLine(nombres[2]);

//nombres.Clear();

List<string> cantantes = new List<string>();

cantantes.Add("Maddona");
cantantes.Add("Cerati");

List<string> personas = new List<string>();

personas.AddRange(cantantes);
personas.AddRange(nombres);

Console.WriteLine("Fin lista");

Console.WriteLine("*************************Foreach*************************");

foreach (string nombre in personas)
{
    Console.WriteLine($"persona: {nombre}");
}

int elementosEnLista = personas.Capacity;

Console.WriteLine($"Elementos en la lista: {elementosEnLista}");

personas.Clear();

Console.WriteLine("*************************Diccionario*************************");

Dictionary<string, int> edadesPersonas = new Dictionary<string, int>();

edadesPersonas.Add("Ana", 30);
edadesPersonas.Add("Luis", 25);
edadesPersonas.Add("Pedro", 40);
edadesPersonas.Add("Maria", 35);

Dictionary<string, List<double>> notasEstudiantes = new Dictionary<string, List<double>>();

//Aqui agregamos el nombre y las notas todo a la vez
notasEstudiantes.Add("Ana", new List<double> { 8.5, 9.0, 7.5 });
notasEstudiantes.Add("Luis", new List<double> { 6.0, 7.5, 8.0 });
notasEstudiantes.Add("Pedro", new List<double> { 9.0, 8.5, 9.5 });

//Aqui creamos una lista de un alumno y luego la agregamos
List<double> notasMaria = new List<double>();

notasMaria.Add(7.0);
notasMaria.Add(8.0);
notasMaria.Add(6.5);

double promedioMaria = notasMaria.Average();

notasEstudiantes.Add("Maria", notasMaria);


foreach (var estudiante in notasEstudiantes)
{
    double promedio = estudiante.Value.Average();
    Console.WriteLine($"El promedio de {estudiante.Key} es: {promedio}");
}

Console.WriteLine("*************************Ejercicios*************************");

Console.WriteLine("*************************Arrys*************************");

Console.WriteLine("*************************Ejercicio1*************************");

// Escribe código para sumar todos los elementos e imprimir el resultado

int[] numeros = { 3, 47, 27, 17, 5 };

int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma = suma + numeros[i];
}

Console.WriteLine($"La suma es: {suma}");

Console.WriteLine("*************************Ejercicio2*************************");

// Encuentra y muestra el mayor elemento de un array de enteros

int[] numInt = { 3, 45, 73, 2, 4 };

int mayor = numInt[0];

for (int i = 1; i < numInt.Length; i++)
{
    if (numInt[i] > mayor)
    {
        mayor = numInt[i];
    }
}

Console.WriteLine($"El mayor es: {mayor}");

Console.WriteLine("*************************Ejercicio3*************************");

// programa que pida 3 numeros por consola, guardarlos en un array de enteros y finalmente recorrer el array y sumarlos mostrando el resultado por pantalla

Console.WriteLine("Introduce 3 numeros enteros:");

int[] numerosEnteros = new int[3];

for (int i = 0; i < numerosEnteros.Length; i++)
{
    Console.Write($"Numero {i + 1}: ");

    numerosEnteros[i] = int.Parse(Console.ReadLine());

}

int sumaEnteros = 0;

for (int i = 0; i < numerosEnteros.Length; i++)
{
    sumaEnteros = sumaEnteros + numerosEnteros[i];
}

Console.WriteLine($"La suma de los numeros enteros es: {sumaEnteros}");


Console.WriteLine("*************************Listas*************************");

Console.WriteLine("*************************Ejercicio1*************************");

// Crea una lista con los números del 1 al 10.
// Elimina los números pares de la lista.
// Imprime la lista resultante.


List<int> numerosLista = new List<int>();

for (int i = 1; i <= 10; i++)
{
    numerosLista.Add(i);
}

for (int i = numerosLista.Count - 1; i >= 0; i--)
{
    if (numerosLista[i] % 2 == 0)
    {
        numerosLista.RemoveAt(i);
    }
}

Console.WriteLine($"Lista de numeros impares: {string.Join(", ", numerosLista)}");

Console.WriteLine("*************************Ejercicio2*************************");
// Crea una lista de cadenas de texto.
// Pide al usuario que ingrese 5 nombres y los agrega a la lista.

List<string> nombresLista = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Introduce el nombre {i + 1}:");
    string nombre = Console.ReadLine();
    nombresLista.Add(nombre);
}

Console.WriteLine("Lista de nombres ingresados: " + string.Join(", ", nombresLista));

Console.WriteLine("*************************Diccionarios*************************");

Console.WriteLine("*************************Ejercicio1*************************");

// Crea un diccionario donde la clave sea el nombre de la persona
// y el valor sea su número de teléfono (como string).
// Agrega 3 contactos y muestra la agenda completa.

Dictionary<string, string> agenda = new Dictionary<string, string>();
agenda.Add("Juan", "123-456-789");
agenda.Add("Ana", "987-654-432");
agenda.Add("Pedro", "567-890-123");

Console.WriteLine("Agenda:");

foreach (var contacto in agenda)
{
    Console.WriteLine($"Nombre: {contacto.Key}, Telefono: {contacto.Value}");
}

Console.WriteLine("*************************Ejercicio2*************************");

// Usa el diccionario anterior.
// Pide al usuario que escriba un nombre.
// Si el nombre existe, muestra el teléfono.
// Si no, indica que no está en la agenda.

Console.WriteLine("Introduce un nombre para buscar en la agenda:");
string nombreBuscar = Console.ReadLine();

if (agenda.ContainsKey(nombreBuscar))
{
    Console.WriteLine($"El telefono de {nombreBuscar} es: {agenda[nombreBuscar]}");
}
else
{
    Console.WriteLine($"El nombre {nombreBuscar} no esta en la agenda");
}



