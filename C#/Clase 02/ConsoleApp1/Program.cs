// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int cantidadProdVendidos;
int cantidadProductoDeposito = 50;
int stock;

Console.WriteLine("Ingrese la cantidad de prouctos vendidos");

cantidadProdVendidos = Convert.ToInt32(Console.ReadLine());

stock = cantidadProductoDeposito - cantidadProdVendidos;

if (stock == 0)
{
    Console.WriteLine("Reponer stock");
    cantidadProductoDeposito += 10;
    //cantidadProductoDeposito = cantidadProductoDeposito + 10;
    Console.WriteLine("Productos cargados en el deposito");
}
else
{
    if (stock <= 5)
    {
        Console.WriteLine("Stock minimo, reponer");
        cantidadProductoDeposito += 5;
        Console.WriteLine("Productos caragdos");
        Console.WriteLine("Informar a ventas productos sin vender", stock);
    }
    else
    {
        Console.WriteLine("Informar a ventas los productos sin vender", stock);
    }
    
}

