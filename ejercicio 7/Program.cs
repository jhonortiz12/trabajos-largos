namespace ejercicio7
{
    internal class program
    {

        static void Main()
        {

            //langostafa ahumada 
            double numplatos, totalapagar;
            Console.WriteLine("ingrese el numero de platos ");
            numplatos = double.Parse(Console.ReadLine());
            if (numplatos > 200 && numplatos <= 300)
            {
                totalapagar = numplatos * 85000;
                Console.WriteLine("el valor a pagar es de " + totalapagar);


            }
            else if (numplatos >= 301)
            {
                totalapagar = numplatos * 75000;
                Console.WriteLine("el valor total a pagar es de " + totalapagar);


            }

            // empreza de vinicultores
            double kilo,tipo,valtipo1, total1;
            Console.WriteLine("ingrese el numero de kilos de uva");
            kilo = double.Parse(Console.ReadLine());
            Console.WriteLine("elija el tipo de una ");
            Console.WriteLine("1=tipo A");
            Console.WriteLine("2 =tipo b");
            tipo = double.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.WriteLine("elija el tipo de tamaño de la uva ");
                Console.WriteLine("tamaño 1");
                Console.WriteLine("tamaño 2");
                valtipo1 = double.Parse(Console.ReadLine());
                if (valtipo1 == 1)
                {
                    total1 = kilo * 20;

                    Console.WriteLine("el total a pagar es de  " + total1);

                }
               else  if (valtipo1 == 2)
                {
                    total1 = kilo * 30;

                    Console.WriteLine("el total a pagar es de  " + total1);

                }

            }
            else if (tipo == 2)
            {
                Console.WriteLine("elija el tipo de tamaño de la uva ");
                Console.WriteLine("tamaño 1");
                Console.WriteLine("tamaño 2");
                valtipo1 = double.Parse(Console.ReadLine());
                if (valtipo1 == 1)
                {
                    total1 = kilo * 30;

                    Console.WriteLine("el total a pagar es de  " + total1);

                }
                else if (valtipo1 == 2)
                {
                    total1 = kilo * 50;

                    Console.WriteLine("el total a pagar es de  " + total1);

                }

            }



        }
    }
}