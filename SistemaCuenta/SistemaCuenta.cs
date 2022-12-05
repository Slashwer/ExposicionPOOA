internal class Program
{
    private static void Main(string[] args)
    {
        //Clase principal funcionamiento
        ISController Usuario1 = new ISController("hola123@gmail.com","wedwffe","Airi","10/03/1900","37328476");
        CCController Usuario2 = new CCController("pablo123@gmail.com","grgbjg","Perez","10/07/1950","98962732");
        int opcion=0;
        Console.WriteLine("Escoga una opcion");
        Console.WriteLine("1. Iniciar sesion");
        Console.WriteLine("2. Crear cuenta");
        opcion=Convert.ToInt16(Console.ReadLine());
         switch(opcion){
            case 1:
            Usuario1.Mostrar();
            break;
            case 2:
            Usuario2.Mostrar();
            break;
            default:
            break;
        }
    }
}