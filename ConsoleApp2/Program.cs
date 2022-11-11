namespace ejercicio4
{
    internal class program
    {
        static void Main()
        {
            //ejercicio para saber si un numeroe s mayor o menor 
            double num1;
            Console.WriteLine("ingrese un numero");
            num1 = double.Parse(Console.ReadLine());
            if (num1 > 0)
            {
                Console.WriteLine("el numero es positivo ");

            }
            else if (num1 < 0)
            {
                Console.WriteLine("el numero es negativo ");
            }

        }
    }
}