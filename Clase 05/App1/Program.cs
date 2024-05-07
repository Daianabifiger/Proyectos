//Para alcanzar una clase de otro archivo
namespace App1
{

    class Program
    {
        static void Main(string[] args)
        {
           Producto producto = new Producto(01, "pañal", "limpieza", 4.5, 3.45);

            if (producto.hayPrecioDeVenta())
            {
                Console.WriteLine("El producto esta a la venta");
            }
            else
            {
                Console.WriteLine("El producto no fue publicado aún");
            }

            producto.categoria = "Limpieza";
            Console.WriteLine(producto.categoria);


        }
    }

}