# CursosCsharp

# Curso CSharp desde cero

¿Quieres aprender a programar en C# y no sabes por dónde empezar? ¡Este curso de Programación en C# desde CERO es para ti! En este video te enseñamos paso a paso los conceptos fundamentales del lenguaje de programación C#, explicados de forma clara y sencilla, con ejercicios, ideal para quienes no tienen experiencia previa.


[Ir a la carpeta local del curso](./CursoCSharp)

[Video en youtube de este curso](https://youtu.be/UwqYtz9l4Bk)


📘 Temas que cubrimos:

* ✅ Variables: cómo declarar y usar diferentes tipos de datos
* ✅ Condicionales: toma de decisiones con if, else, switch
* ✅ Bucles: estructuras repetitivas como for, while, do-while
* ✅ Estructuras: organización de datos personalizados
* ✅ Métodos: cómo estructurar tu código con funciones
* ✅ Clases: introducción a la programación orientada a objetos
* ✅ Ficheros: lectura y escritura de archivos en C#
* ✅ Excepciones: manejo de errores de forma segura

## Comandos para ejecutar 

```bash
# dentro de la raiz de la solución
dotnet run --project .\1Variables\1Variables.csproj

# dentro de la raiz del proyecto
dotnet run

# compilar 
dotnet build
```

## Comandos vistos en el curso para la creación de proyectos y soluciones

```bash
dotnet new sln -o CursoCSharp
 
dotnet new console -n 1Variables
dotnet sln .\CursoCsharp.sln add .\1Variables\1Variables.csproj


dotnet new console -n 2Condicionales
dotnet sln .\CursoCsharp.sln add .\2Condicionales\2Condicionales.csproj


dotnet new console -n 3Bucles
dotnet sln .\CursoCsharp.sln add .\3Bucles\3Bucles.csproj


dotnet new console -n 4Estructuras
dotnet sln .\CursoCsharp.sln add .\4Estructuras\4Estructuras.csproj


dotnet new console -n 5Metodos
dotnet sln .\CursoCsharp.sln add .\5Metodos\5Metodos.csproj

dotnet new console -n 6Clases
dotnet sln .\CursoCsharp.sln add .\6Clases\6Clases.csproj

dotnet new console -n 7Ficheros
dotnet sln .\CursoCsharp.sln add .\7Ficheros\7Ficheros.csproj

dotnet new console -n 8Exceptions
dotnet sln .\CursoCsharp.sln add .\8Exceptions\8Exceptions.csproj
```

# Curso Construye un Api desde Cero

Construimos un api de alquiler de coches desde cero en .Net con Entity Framework, base de datos MsSql server y uso de migraciones.
No estamos usando clean code, porque la idea es despeés de esta intruducción a las api, ir refactorizandola y llevarla a una arquitectura hexagonal, con testing y demás.

Comandos vistos en el video:
```bash
#creación del proyecto
dotnet new sln -o CarRentalApi1

cd CarRentalApi1
dotnet new webapi --use-controllers -n CarRental.Api
 
dotnet sln  add .\CarRental.Api\

# paquetes
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

# Migraciones de base de datos
dotnet ef migrations add InitialCreate
# creamos la base de datos si no existe 
dotnet ef database update

dotnet ef migrations add AddPriceToRental
dotnet ef database update



```

[Ir a la carpeta local del curso](./CarRentalApi1)

[Video en youtube de este curso](https://youtu.be/w3OgRMPZf9s)