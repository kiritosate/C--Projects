
using System;

namespace kiritosate
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                int number1, number2, result;
                string operand;

                Console.Write("enter first number: ");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("enter second number: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("use ( + , - , * , /)\nenter the operand to use: ");
                operand = Console.ReadLine();
            
                switch(operand)
                {
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                    default:
                        result = number1 + number2;
                        break;
                }

                Console.WriteLine("The Result in Problem {0} {1} {2} = {3}", number1, operand, number2, result);
                }
        }
    }
}
