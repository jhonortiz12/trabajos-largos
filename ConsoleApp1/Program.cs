namespace ejercicio2
{
    internal class program
    {
        static void Main()
        {
            //ejercicio para saber si un numero es divisor de otro 
            double num1, num2, resultado;
            Console.WriteLine("por favor dijite el primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("por favor dijite el segundo numero");
            num2 = double.Parse(Console.ReadLine());
            resultado = (num1 / num2);
            if (resultado == 0 )
            {
                Console.WriteLine("los numeros dijitados son divisores entre ellos ");
            }
            else if (resultado > 0)
            {
                Console.WriteLine("los numeros dijitados no  son divisores entre ellos ");
            }

        }
    }
}