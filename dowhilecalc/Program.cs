
using System;

namespace dowhilecalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result,operand;

            do{
                Console.Write("Menu:\n 1 - Addition\n 2 - Subtraction\n 3 - Multiplication\n 4 - Division\n 5 - Exit\nChoose Operation: ");
                operand = Convert.ToInt32(Console.ReadLine());

                Console.Write("enter first number: ");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("enter second number: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                switch(operand)
                {
                    case 1:
                        result = number1 + number2;
                        break;
                    case 2:
                        result = number1 - number2;
                        break;
                    case 3:
                        result = number1 * number2;
                        break;
                    case 4:
                        result = number1 / number2;
                        break;
                    case 5:
                        result = number1 - number2;
                        break;
                    default:
                        return true;
                }

                Console.WriteLine("The Result in Problem {0} {1} {2} = {3}", number1, operand, number2, result);

            }while(true);
        }
    }
}
