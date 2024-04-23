// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string categoria;

Console.WriteLine("Ingrese la categoria A, B, C o D");

categoria = Console.ReadLine();

switch (categoria)
{
    case "A":
    case "D":
        Console.WriteLine("Empleado administrativo");
        break;
    case "B": Console.WriteLine("Empleado profesional");
        break;
    case "C": Console.WriteLine("Empleado maestranza");
        break;
    default:
        Console.WriteLine("Sin categoria");
        break;
}

//Ejemplo escuela

Console.WriteLine("Bienvenidos a la Universidad CoderHouse");
Console.WriteLine("Ingrese su comisión");

string comision;
int calificacion;

comision = Console.ReadLine();

switch (comision)
{
    case "A":
        Console.WriteLine("Turno mañana");
        break;
    case "B":
        Console.WriteLine("Turno tarde");
        break;
    case "C":
        Console.WriteLine("Turno noche");
        break;
    default:
        Console.WriteLine("Sin turno fijo");
        break;
}

Console.WriteLine("Ingrese la nota del alumno");

calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion >= 0 && calificacion < 4)
{
    Console.WriteLine("Recursa");
}
else if (calificacion >= 4 && calificacion <= 7)
{
    Console.WriteLine("Aprobo la cursada");
}
else if (calificacion > 7 && calificacion <= 10)
{
    Console.WriteLine("Promocionó la materia");
}
else
{
    Console.WriteLine("Calificar del 0 al 10");
}

