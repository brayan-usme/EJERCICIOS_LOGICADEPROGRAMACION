internal class Program
{
    private static void Main(string[] args)
    {


        // hacer un algoritmo donde fernanda  escoja un valor de cuanto quiere a brayan del 1 al 10  y dependiendo  de cuanto lo quiera le muestre un mensaje 


        Console.Write(" del uno al 10 cuanto amas a brayan ????");
        double amor = Convert.ToDouble(Console.ReadLine());

        if (amor < 5)
        {
            Console.Write(" pero por que no amaaaaaaaaaaas a tu cosita cuidadaoraaaaaaaaaaaaaaa");

        }
        else if (amor <= 7)
        {
            Console.Write(" jmmmmm eso esta muy suave 😭 ");

        }
        else if (amor > 9 && amor<10)
        {
            Console.Write(" siiiiiiiiiiii cosita muy amadaaaaaaaaaaaa <3");

        }

        if (amor >10 )
        {
            Console.WriteLine(" tu amorrrrrrrr es nivel supremooooooooooooooooo");

        }


        else
        {
            Console.Write("amame mucho maaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaassssssssss");
        }


        Console.Write(" Gracias por amarme cosita , perdoname por hacerte tanto daño pero de verdad quiero volver a hacerte muy feliz como antes y que volvamos a brillar juntos ¿¿ aceptas ?? <3 ");    

















    }
}