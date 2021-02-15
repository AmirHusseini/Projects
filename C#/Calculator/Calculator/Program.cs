using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finito = false;

            while (!finito)
            {
                Console.WriteLine("Simple Calculator!");

                Console.Write("Enter the first number: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double y = Convert.ToDouble(Console.ReadLine());

                
                Console.WriteLine("1. Add: ");
                Console.WriteLine("2. Subtract: ");
                Console.WriteLine("3. Multiply: ");
                Console.WriteLine("4. Divide: ");
                Console.WriteLine("5. Close ");
                Console.Write("Choose your option: ");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 5) { finito = true; Environment.Exit(0); }
                double result;
                
                switch (choose)
                {
                    case 1:
                        result = x + y;
                        Console.Write(x + " + " + y + " = " + result);
                        Console.ReadLine();
                        break;
                    case 2:
                        result = x - y;
                        Console.Write(x + " - " + y + " = " + result);
                        Console.ReadLine();
                        break;
                    case 3:
                        result = x * y;
                        Console.Write(x + " * " + y + " = " + result);
                        Console.ReadLine();
                        break;
                    case 4:
                        result = x / y;
                        Console.Write(x + " / " + y + " = " + result);
                        Console.ReadLine();
                        break;

                }
                Console.Clear();
            }
        }

    }
}
