using ConsoleApp1.DataBase;
using System.Data.SqlClient;

namespace ConsoleApp1.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();

            try
            {
                // Eliminaria el usuario de id 10 pero yo no lo tengo agregado
                //if (gestorBaseDeDatos.DeleteUser(10))
                //{
                //    Console.WriteLine("Usuario eliminado");
                //}

                //Agregar susuario
                //Usuario newUser = new Usuario("Carlos", "Perez", "perez32", "324234", "carlospe@gmail.com");
                //if (gestorBaseDeDatos.CreateUser(newUser))
                //{
                //    Console.WriteLine("Usuario creado");
                //}

                //actualizar usuario
                Usuario editUser = new Usuario("Carlos", "Villegas", "ville32", "324234", "carlosv@gmail.com");
                if (gestorBaseDeDatos.UpdateUser(3, editUser))
                {
                    Console.WriteLine("Usuario actualizado");
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}