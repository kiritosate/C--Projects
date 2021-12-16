using System;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            One();
            Two();
            Three();
            Four();
            Five();
        }
        static void One()
        {
            int num = 1;
            while(num<=10){
                Console.Write($"{num} ");
                num++;
            }
        }
        static void Two()
        {
            int num = 1, temp = 0;
            Console.Write("the first 10 real numbers: ");
            while(num<=10){
                Console.Write($"{num} ");
                temp += num;
                num++;
            }
            Console.WriteLine($"\nthe sum is: {temp}");
        }

        static void Three()
        {
            Console.Write("nth term: ");
            int data = Convert.ToInt32(Console.ReadLine());
            int temp = 0;

            Console.Write($"The First {data} Natural Number: ");
            for(int i=1;i<=data;i++){
                Console.Write($"{i} ");
                temp += i;
            }
            Console.WriteLine($"\nThe Sum of Natural Number up to {data} terms: {temp}");
        }
        static void Four()
        {
            double temp = 0;
            Console.WriteLine("Input 10 Numbers:\n");
            for(int i=1;i<=10;i++)
            {
                Console.Write($"Number {i}: ");
                temp += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"\nThe Sum of the 10 no is: {temp}");
            Console.WriteLine($"The Average is: {Convert.ToDecimal(temp/10)}");
        }
        static void Five()
        {
            Console.Write("Input number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=terms;i++){
                Console.WriteLine($"Number is: {i} and cube of the {i} is: {(i*i*i)}");
            }
        }
    }
}
