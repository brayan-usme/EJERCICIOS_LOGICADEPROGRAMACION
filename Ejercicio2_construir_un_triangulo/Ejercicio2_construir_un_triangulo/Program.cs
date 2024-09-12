public class Program
{
    private static void Main(string[] args)
    {
        // 2.Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.

        //declarar variables
        double seg1, seg2, seg3;
        bool istriangle;
       
        //pedir datos por pantalla y guardarla en las variables
        Console.WriteLine("INGRESE EL VALOR DEL SEGMENTO 1");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("INGRESE EL VALOR DEL SEGMENTO 2");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("INGRESE EL VALOR DEL SEGMENTO 3");
        seg3 = Convert.ToDouble(Console.ReadLine());


        // proceso - validacion


        // FORMA extensa en cascada del iff
        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {

                if ((seg2 + seg3) > seg1)
                {

                    istriangle = true;

                }
                else
                {
                    istriangle = false;
                }
            }
            else
            {
                istriangle = false;
            }


        }
        else
        {
            istriangle = false;
        }

        

        // froma abreviada  en una sola linea del if 
        if (((seg1 + seg2) > seg3) && ((seg2 + seg3) > seg1) && ((seg2 + seg3) > seg1))
        {
            istriangle = true;
        }
        else
        {
            istriangle = false;

        }
        // mostrar mensaje 
        if (istriangle)
        {
            Console.WriteLine(" los segmentos forman un triangulo");
        }
        else {
            Console.WriteLine(" los segmentos no forman un triangulo");
        }




















    }
}