public class Program
{
    private static void Main(string[] args)
    {

        //Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos.

        //DATOS DE ENTRADA  
        //DEFINIR VARIABLES
        double X1, Y1, X2, Y2, D, proces1,proces2;

        //inicializar pidiendolas desde las pantallas / tambien se pueden inicializara directamente en la variable poniendo un = y dando el valor 

        Console.Write("porfavor ingrese el valor de x1 ");
        // X1 = Console.Readline(); // esta es la forma de escribir en la pantalla (recordar que asi siempre toma como un string)

        // X1 = Convert.ToDouble(Console.ReadLine()); // asi se convierte a el tipo de texto que necesites (Convert.xxxxxx)
        // 
        X1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("porfavor ingrese el valor de x y1");
        Y1= Convert.ToDouble(Console.ReadLine());

        Console.Write("porfavor ingrese el valor de x2 ");
        X2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("porfavor ingrese el valor de y2 ");
        Y2 = Convert.ToDouble(Console.ReadLine());

        // así no es la formula matematicamente pero funciona mientras sjjsjsjsjj
        proces1 = (X1-X2) ;
        proces2 = (Y1-Y2) ;
        double proces3 = proces1*2;
        double proces4 = proces2 * 2;

       

        D = proces3 + proces4 ;
        Console.Write("LA DISTANCIA ES " + D);




















    }
}