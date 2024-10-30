using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System;

public class Program
{
    private static void Main(string[] args)
    {
        /* 32.Se desea obtener el valor de la matrícula de un estudiante cuyo valor se calcula de
 la siguiente manera:
 • Si toma 20 o menos créditos, paga el crédito al valor normal. Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de
 valor normal.
 • Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:
 -Si el estrato es 1, el descuento es del 80 %.
 - Si el estrato es 2, el descuento es del 50 %.
 - Si el estrato es 3, el descuento es del 30 %.
 Además, los estratos 1 y 2 reciben subsidio de alimentación y transporte de la
 siguiente manera:
 • Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
 • Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.
 Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio.
 La aplicación debe preguntar al usuario si quiere volver al inicio o no para calcular la
 matrícula de un nuevo estudiante.
 Hacer uso de todos los elementos de programación que hemos visto hasta el
 momento, incluyendo POO(clases, propiedades, métodos)*/

        //DECLARO MIS VARIABLES Y VALORES A PEDIR
        Console.WriteLine("¿Cuantos creditos tomo para este semestre? ");
        double num_creditos_tomados = Convert.ToDouble(Console.ReadLine());
        const decimal creditos = 1000;












































































       /* Console.Write(" ingrese el primer número ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write(" ingrese el segundo  número ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double opcion_menu, resultado;
        bool continuar = true;
        string continuar2;


        do
        {
            Console.WriteLine(" -----------------------------------");
            Console.WriteLine(" -- 1 sumar                      ---");
            Console.WriteLine(" -- 2 restar                     ---");
            Console.WriteLine("  -- 3 multiplicar               ---");
            Console.WriteLine(" -- 0 devilver                   ---");
            Console.WriteLine(" -----------------------------------");
            Console.WriteLine(" elija una opcion ");
            opcion_menu = Convert.ToDouble(Console.ReadLine());


            switch (opcion_menu)
            {
                case 0:
                    continuar = false;
                    Console.WriteLine(" adios");
                    break;

                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($" la suma de {num1}+ {num2} es {resultado}");
                    break;



                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($" la resta de {num1} - {num2} es {resultado}");

                    break;

                case 3:

                    resultado = num1 * num2;
                    Console.WriteLine($" la multiplicacion de {num1} x {num2} es {resultado}");
                    break;
                default:
                    Console.WriteLine(" opcion no valida");

                    break;




                    Console.WriteLine(" desea continuar ?? (s/n) ");
                    continuar2 = Console.ReadLine();
                    if (continuar2 == "n")
                    {
                        continuar = false;FF
       QRFQFQFQ
                    }















            }


        } while (continuar );

        */


































    }
}