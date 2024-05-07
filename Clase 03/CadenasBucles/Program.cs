// length es una propiedad, ToUpper, ToLower y Trim son funciones

string cadenaNula = null;
string cadenaVacia = string.Empty;
string cadenaSaludo = "Hola, soy una cadena";

Console.WriteLine(cadenaSaludo + cadenaNula + cadenaVacia);

if (cadenaNula == cadenaVacia)
{
    Console.WriteLine("Las cadenas son iguales");
}
else
{
    Console.WriteLine("Las cadenas no son iguales");
}

//Console.WriteLine(cadenaNula.Length); me tira error porque no apunta a nada
Console.WriteLine(cadenaVacia.Length);
Console.WriteLine(cadenaSaludo.Length);

// la funcion trim() borra los espacios cadenaVacia.Trim().Length

string mensaje = "Voy a desarrollar en C#";

Console.WriteLine("mensaje en minusculas: " + mensaje.ToLower());
Console.WriteLine("mensaje en mayusculas: " + mensaje.ToUpper());

int numeroEntero = 22;
double numeroConDecimales = 1.88;
bool numeroBooleano = true;

//Console.WriteLine("La edad de Luis es: " + numeroEntero.ToString() + 
//   " " + numeroConDecimales.ToString() + " " + numeroBooleano.ToString());


string cadena1 = "Soy una cadena ";
string cadena2 = "Soy una cadena";

if (cadena1.Equals(cadena2))
{
    Console.WriteLine("Cadena 1 es igual a cadena 2");
}
else
{
    Console.WriteLine("Las cadenas no son iguales");
}

if (cadena1.Contains(cadena2))
{
    Console.WriteLine("Cadena 1 contine a cadena 2");
}
else
{
    Console.WriteLine("Cadena 1 no contiene a cadena 2");
}

Console.WriteLine("Ingrese un numero para sumar");

string cadena = Console.ReadLine();

double constante = 0.5;
double numeroEnCadenaConvertidoADouble;
double sumaConNumeroDouble;

if (string.IsNullOrEmpty(cadena))
{
    Console.WriteLine("La cadena no se puede parsear ya que esta vacia");
}
else
{
    numeroEnCadenaConvertidoADouble = double.Parse(cadena);
    sumaConNumeroDouble = numeroEnCadenaConvertidoADouble + constante;
    Console.WriteLine("El resultado es: " + sumaConNumeroDouble);
}

