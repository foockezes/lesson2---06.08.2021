using System;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
                        //• Задание 2
            Console.Write("введите целое чесло:  ");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.Write("введите целое чесло:  ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != b) 
            {
                if(a > b)
                {
                    b = a;
                    Console.WriteLine($"a = {a}, b = {b}");
                }
                else
                {
                    a = b;
                    Console.WriteLine($"a = {a}, b = {b}");
                }
            }
            else
            {
                a = 0;
                b = 0;
                Console.WriteLine($"a = {a}, b = {b}");
            }


            //• Задание 3
            Console.Write("введите чесло:  ");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите чесло:  ");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите математический символ:  ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("нельзя делить на ноль");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2); 
                    }
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                default:
                    Console.WriteLine("something is wrong");
                    break;
            }



            //• Задание 4
            Console.WriteLine("введите целое число");
            int pr = Convert.ToInt32(Console.ReadLine());
            if (pr < 15) Console.WriteLine("вы в промежутке: [0 - 14]");
            else if (pr < 36) Console.WriteLine("вы в промежутке: [15 - 35]");
            else if (pr < 51) Console.WriteLine("вы в промежутке: [36 - 50]");
            else if (pr < 101) Console.WriteLine("вы в промежутке: 50 - 100]");
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
