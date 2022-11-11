namespace ejercicio6
{
    internal class program
    {
        static void Main()
        {
            //descuento en los trajes 
            double traje, descuento, valdes;

            Console.WriteLine("ingrese el valor del traje ");
            traje = double.Parse(Console.ReadLine());
            if (traje >= 2500)
            {
                descuento = ((traje * 15) / 100);
                valdes = (traje - descuento);
                Console.WriteLine("el valor a total a pagar es de " + valdes);
                Console.WriteLine("el valor del descuento es de " + descuento);
            }
            else if (traje < 2500)
            {
                descuento = ((traje * 8)/100);
                valdes = (traje-descuento);
                Console.WriteLine("el valor del descuento es de " + descuento);
                Console.WriteLine("el valor a total a pagar es de " + valdes);
            }
        }

    }
}