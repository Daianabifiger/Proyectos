
int precioCodigo(string codigo)
{
    int precio = 0;
    switch (codigo)
    {
        case "DES":
            precio = 200;
            break;
        case "JP":
            precio = 300;
            break;
        case "DET":
            precio = 250;
            break;
        default:
            precio = 0;
            break;
    }
}

void venta()
{
    string codigo = "";
    int cantProduc;
    int montoPagar = 0;
    string confirmacion = "";

    Console.WriteLine("¡Bienvenido! Esto son nuestros productos");
    Console.WriteLine("Código        Descripción        Precio\r\nDES           Desodorante          200\r\nJP           Jabon en Polvo        300\r\nDET           Detergente           200");

    while (codigo != "FIN")
    {
        Console.WriteLine("Ingrese el codigo que desea comprar");
        codigo = Console.ReadLine().ToUpper();
        
        if (codigo == "FIN")
        {
            break;
        }

        int precio = precioCodigo(codigo);
       
        Console.WriteLine("Ingrese la cantidad");
        cantProduc = int.Parse(Console.ReadLine());

        montoPagar += cantProduc * precio;
    }
    
    Console.WriteLine("El monto a pagar es {0}", montoPagar);
    Console.WriteLine("Desea realizar la compra? Si/No");
    confirmacion = Console.ReadLine().ToUpper();

    if (confirmacion == "SI")
    {
        Console.WriteLine("Gracias por la compra");
    }

}
venta();
