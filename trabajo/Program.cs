namespace ejercicio5
{
    internal class program
    {

        //programam para saber el precio si por 1000 el precio es de 89
        static void Main()
        {
            double numl, pago;
            Console.WriteLine("ingrese el numero total de lapices ");
            numl = double.Parse(Console.ReadLine());
            if (numl >= 1000)
            {
                pago = numl * 85;
                Console.WriteLine("el total a pagra es de " + pago);
            }

            else if (numl < 1000)
             {
                pago = numl * 90;
                Console.WriteLine("el total a pagar es de " + pago);
             }
        }
    }
}
