using System;

namespace assignment156
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number:");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Calculation calc = new Calculation();

            Console.WriteLine(num1 + " + 2 = ");
            Console.WriteLine(calc.Add(num1));

            Console.WriteLine(num1 + " - 2 = ");
            Console.WriteLine(calc.Subtract(num1));

            Console.WriteLine(num1 + " / 2 =");
            Console.WriteLine(calc.Divide(num1));


            Console.Read();

        }
    }
}



 
