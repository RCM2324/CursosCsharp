//Metodos

//e=MC^2

Console.WriteLine(Math.Pow(3, 3)); // 3^3 = 27

int m = 5;
int c = 300000;
double resultado = m * Math.Pow(c, 2);

Console.WriteLine(resultado); // 4.5E+16

// Si yo quisiera volver a calcular el resultado si no hubiera los metodos...tendria que volver a copiar 
// todo cambiando los valores por los nuevos y asi sucesibamente...pero haciendo un metodo
// podemos reutilizar el codigo y no tener que volver a escribirlo

// Dos formas... una que debuelve un valor con lo cual al final ponemos return
static double CalculoEnergia(int m)
{
    int c = 300000;
    double resultado = m * Math.Pow(c, 2);
    return resultado;
}

Console.WriteLine("Ingrese la masa en Kg: ");
int masa = int.Parse(Console.ReadLine()!);

double energia = CalculoEnergia(masa);

Console.WriteLine($"La energia es: {energia} J");

// Y otra que no devuelve nada, simplemente hace algo con void

static void CalculoEnergia2(int m)
{
    int c = 300000;
    double resultado = m * Math.Pow(c, 2);
    Console.WriteLine($"La energia es: {resultado} J");

}

// Tambien hay metodos que reciben o lo que retorna de Listas o arrays

static List<string> IniciaNombre()
{
    List<string> nombres = new List<string>();
    nombres.Add("Juan");
    nombres.Add("Pedro");
    nombres.Add("pepe");

    return nombres;
}

List<string> listaNombres = IniciaNombre();

foreach (var nombre in listaNombres)
{
    Console.WriteLine(nombre);
}

string primerNombre = listaNombres[0];

Console.WriteLine($"El primer nombre es: {primerNombre}");

// Tambien podemos hacer metodos que reciban parametros y retornen valores

static string Saludar (string nombre)
{
    return $"Hola {nombre}, ¿como estas?";
}

Console.WriteLine("Ingrese su nombre: ");
string nombreUsuario = Console.ReadLine()!;

string saludo = Saludar(nombreUsuario);

Console.WriteLine(saludo);

// Tambien podemos hacer metodos que reciban varios parametros

static string Saludar2(string nombre, string apellido)
{
    return $"Hola {nombre} {apellido}, ¿como estas?";
}

Console.WriteLine("Ingrese su nombre completo: ");
string nombreCompleto = Console.ReadLine()!;

string[] partesNombre = nombreCompleto.Split(' ');

string saludoCompleto = Saludar2(partesNombre[0], partesNombre[1]);

Console.WriteLine(saludoCompleto);

Console.WriteLine("***************************Ejercicios*************************");

// Metodo o funcion que calcule los impuestos de un importe y que retorne el importe + el impuesto

static double CalcularImpuesto(double importe, double porcentajeImpuesto)
{
    double impuesto = importe * (porcentajeImpuesto / 100);
    return importe + impuesto;
}

Console.WriteLine("Ingrese el importe: ");
double importe = double.Parse(Console.ReadLine()!);

Console.WriteLine("Ingrese el porcentaje del impuesto: ");
double porcentajeImpuesto = double.Parse(Console.ReadLine()!);

double importeConImpuesto = CalcularImpuesto(importe, porcentajeImpuesto);

Console.WriteLine($"El importe con el impuesto es: {importeConImpuesto}");

// un progema que pida por teclado en un bucle nombres y no acabe ahsta que se ingrese "fin" como nombre




// el programa debera almacenar en una lista de string los nombres que se han ido ingresadno
// luego debera buscar en esa lista y mostrar si existe o no el nombre "Mario". Utilza funciones



