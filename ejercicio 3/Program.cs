namespace ejercicio3
{
    internal class program
    {
        static void Main()
        {
            // suma o resta 
            double num1, num2, suma, opc, resta;
            Console.WriteLine("ingrese el primer numero ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("elija una opcion ");
            Console.WriteLine("1=suma");
            Console.WriteLine("2=resta");
            opc = double.Parse(Console.ReadLine());

            if (opc == 1)
            {
                suma = num1 + num2;
                Console.WriteLine("el resultado de la suma es " + suma);


            }
            else if (opc == 2)
            {
                resta = num1 - num2;
                Console.WriteLine("el resultado de la resta es " + resta);

            }
        }
    }
}