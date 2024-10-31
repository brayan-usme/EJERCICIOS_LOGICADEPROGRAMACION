using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System;
using System.Diagnostics.CodeAnalysis;

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
 momento, incluyendo POO(clases, propiedades, métodoss)*/

        
        // desarrollo
          bool continuar = true;

        while (continuar)
        {
            
//DECLARO MIS VARIABLES Y VALORES A PEDIR
        Console.WriteLine("¿Cuantos creditos tomo para este semestre? ");
        decimal num_creditos_tomados = Convert.ToDecimal(Console.ReadLine());
        const decimal creditos = 1000;
        const decimal credito_extra = 2000;

        Console.WriteLine("¿Que estrato eres? ");
        double estratro_estudiante = Convert.ToDouble(Console.ReadLine());
        //descuentos
        const decimal constante_descuento_estrato1 = 80;
        const decimal constante_descuento_estrato2 = 50;
        const decimal constante_descuento_estrato33 = 30;
        // subsicios para estratos 1y 2
        const decimal subsidio_estrato1 = 2000000;
        const decimal subsidio_estrato2 = 1000000;
        // opereaciones para creditos menores a 20
        decimal sumade_matricula_por_preciode_matricula = num_creditos_tomados * creditos;
        decimal operacion_descuento_estrato1 = sumade_matricula_por_preciode_matricula * constante_descuento_estrato1 / 100;
        decimal operacion_descuento_estrato2 = sumade_matricula_por_preciode_matricula * constante_descuento_estrato2 / 100;
        decimal operacion_descuento_estrato3 = sumade_matricula_por_preciode_matricula * constante_descuento_estrato33 / 100;
        // operaciones para creditos mayores a 20
        decimal costo_creditos_normales = 20 * creditos;
        decimal creditos_extras = num_creditos_tomados - 20;
        decimal costos_creditos_extras = creditos_extras + credito_extra;
        decimal total_matricula_creditos_extras = costo_creditos_normales + costos_creditos_extras;
        ///
        decimal operacion_descuento_estrato1_credito_extra = total_matricula_creditos_extras * constante_descuento_estrato1 / 100;
        decimal operacion_descuento_estrato2_credito_extra = total_matricula_creditos_extras * constante_descuento_estrato2 / 100;
        decimal operacion_descuento_estrato3_credito_extra = total_matricula_creditos_extras * constante_descuento_estrato33 / 100;
        // parte para que el programa se repita 
        string respuesta;
        








            if (num_creditos_tomados <= 20)
            {
                if (estratro_estudiante == 1)
                {
                    Console.WriteLine($"El valor de tu matricula es ${sumade_matricula_por_preciode_matricula.ToString("c")} pero con el descuento del 80% queda en ${sumade_matricula_por_preciode_matricula - operacion_descuento_estrato1}\n adicionalmente tienes un subsidio de alimentación y transporte de : ${subsidio_estrato1.ToString("c")}");



                }
                else if (estratro_estudiante == 2)
                {
                    Console.WriteLine($"El valor de tu matricula es ${sumade_matricula_por_preciode_matricula.ToString("c")} pero con el descuento del 50% queda en ${sumade_matricula_por_preciode_matricula - operacion_descuento_estrato2}\n adicionalmente tienes un subsidio de alimentación y transporte de : ${subsidio_estrato2.ToString("c")}");

                }
                else if (estratro_estudiante == 3)
                {
                    Console.WriteLine($"El valor de tu matricula es ${sumade_matricula_por_preciode_matricula.ToString("c")} pero con el descuento del 30% queda en ${sumade_matricula_por_preciode_matricula - operacion_descuento_estrato3}\n No tienes ningun tipo de subsidio");
                }
                else
                {
                    Console.WriteLine(" Tu estrato social no esta permitido ");
                }






            }
            else
            {
                if (estratro_estudiante == 1)
                {
                    Console.WriteLine($"El valor de tu matricula es ${total_matricula_creditos_extras.ToString("c")} pero con el descuento del 80% queda en ${total_matricula_creditos_extras - operacion_descuento_estrato1_credito_extra}\n adicionalmente tienes un subsidio de alimentación y transporte de : ${subsidio_estrato1.ToString("c")}");



                }
                else if (estratro_estudiante == 2)
                {

                    Console.WriteLine($"El valor de tu matricula es ${total_matricula_creditos_extras.ToString("c")} pero con el descuento del 50% queda en % {total_matricula_creditos_extras - operacion_descuento_estrato2_credito_extra}\n adicionalmente tienes un subsidio de alimentación y transporte de : ${subsidio_estrato2.ToString("c")}");
                }
                else if (estratro_estudiante == 3)
                {
                    Console.WriteLine($"El valor de tu matricula es ${total_matricula_creditos_extras.ToString("c")} pero con el descuento del 30% queda en ${total_matricula_creditos_extras - operacion_descuento_estrato3_credito_extra}\n No tienes ningun tipo de subsidio");
                }
                else
                {
                    Console.WriteLine(" Tu estrato social no esta permitido ");
                }


            }
            Console.WriteLine("\n SI DESEAS VOLVER A CALCULAR PRESIONA LA LETRA  ( S ) DE LO CONTRATIO PRESIONA ( N ) PARA FINALIZAR EL PROGRAMA   \n  ");
            respuesta = Console.ReadLine();









            if (respuesta.ToLower() != "s")
            {

                continuar = false;
                Console.WriteLine(" El programa a finalizado, que tengas un exelente dia ;) ");
            }


        }





















































































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