﻿public class Program
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

        Console.Write("porfavor ingrese el valor de y1");
        Y1= Convert.ToDouble(Console.ReadLine());

        Console.Write("porfavor ingrese el valor de x2 ");
        X2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("porfavor ingrese el valor de y2 ");
        Y2 = Convert.ToDouble(Console.ReadLine());

        // proceso

         proces1 = (X2-X1)* (X2-X1) ;
        proces2 = (Y2 - Y1) * (Y2 - Y1);
       double suma = proces1+proces2;

        D = Math.Sqrt(suma);   
        
        Console.Write("el resultado es :" + D);



















    }
}