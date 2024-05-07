
bool validarContrasenia(string contrasenia)
{
    return contrasenia.Equals("usSystem-2022");
}
string ocultarPass(string pass)
{
    char[] caracteres = pass.ToCharArray();

    for (int i = 0; i < caracteres.Length; i++)
    {
        caracteres[i] = '*';
    }
    string textoModificado = new string(caracteres);
    return textoModificado;
}


void validoingreso()
{

    int intentos = 0;
    string contrasenia;
    bool ingreso = true;

    Console.WriteLine("Ingrese la contraseña");



    while (ingreso)
    {
        contrasenia = Console.ReadLine();
        intentos++;

        if (validarContrasenia(contrasenia))
        {
            string passOculto = ocultarPass(contrasenia);

            Console.WriteLine("Bienvenido a CoderHouse Dev");
            Console.WriteLine("Su contraseña es correcta {0}", passOculto);
            ingreso = false; //break;
        }
        else if (intentos >= 5)
        {
            Console.WriteLine("Su contraseña no fue valida y agotó los intentos");
            //ingreso = false;
            break;
        }
        else
        {
            int restoIntentos = 5 - intentos;
            Console.WriteLine("Su contraseña no fue valida, intente nuevamente. Le quedan {0} intentos.", restoIntentos);
        }
    }
}

validoingreso();
