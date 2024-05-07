namespace DesafioCrearUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mayorEdad;
            string nuevaDireccion;
            bool gmail;

            Usuario usuario_1 = new Usuario("Juan", "Bida", 28123123, "bida@gmail.com", 44, "Cabildo 2668");
            Usuario usuario_2 = new Usuario("Daiana", "Bifiger", 45000000, "bida@hotmail.com", 17, "papa 2668");

            mayorEdad = usuario_1.EsMayorDeEdad();
            Console.WriteLine("Usuario 1 es mayor de edad: " + mayorEdad);

            mayorEdad = usuario_2.EsMayorDeEdad();
            Console.WriteLine("Usuario 2 es mayor de edad: " + mayorEdad);

            gmail = usuario_1.EsGmail();
            Console.WriteLine("Usuario 1 tiene correo gmail: " + gmail);
            gmail = usuario_2.EsGmail();
            Console.WriteLine("Usuario 2 tiene correo gmail: " + gmail);

            nuevaDireccion = usuario_1.CambiarDireccion("Congreso 2500");
            Console.WriteLine("Usuario 1 tiene nueva direccion: " + nuevaDireccion);
            nuevaDireccion = usuario_2.CambiarDireccion("Avellaneda 500");
            Console.WriteLine("Usuario 2 tiene nueva direccion: " + nuevaDireccion);
        }
    }
}