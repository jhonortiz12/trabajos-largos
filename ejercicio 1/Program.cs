namespace ejercici1
{
    internal class program
    {
        static void Main()
        {
            //ejercicio para saber si un numero es mayor que otro
            double num1, num2;
            Console.WriteLine("por favor dijite el primer numero ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("por favor dijite el segundo  numero ");
            num2 = double.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine("el numero mayor es " + num2);
            }
            else if (num1 > num2)
            {
                Console.WriteLine("el numero mayor es " + num1);
            }
        }
    }
}