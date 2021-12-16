using System;

namespace application_beginner
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
            for(int i=1;i<=10;i++){
                Console.Write(i + " ");
            }
        }
        static void Two()
        {
            int temp = 0;
            Console.Write("The First 10 Real No: ");
            for(int num=1;num<=10;num++){
                Console.Write(num + " ");
                temp += num;
            }
            Console.WriteLine("");
            Console.WriteLine("The Sum is: " + temp);
        }
        static void Three()
        {
            int term = 0;
            int sum = 0;
            Console.Write("Input the nth term: ");
            term = Convert.ToInt32(Console.ReadLine());

            Console.Write("The First {0} Natural Number: ", term);
            for(int i=1;i<=term;i++){
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine("");
            Console.WriteLine("The Sum of Natural Number up to {0} terms is: {1}", term, sum);

        }
        static void Four()
        {
            double sum = 0;
            double average = 0;
            Console.WriteLine("Input 10 Numbers: ");
            for(int i=1;i<=10;i++){
                Console.Write("Number {0}: ", i);
                double number = Convert.ToDouble(Console.ReadLine());
                sum += number;
            }
            average = sum / 10;
            Console.WriteLine("The Sum of the 10 No is: "+ sum);
            Console.WriteLine("The Average is: "+average);
        }
        static void Five()
        {
            int term, cube;
            Console.Write("Input term: ");
            term = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=term;i++){
                cube = (i*i*i);
                Console.WriteLine("Number is: {0} and cube of the {1} is: {2}", term, term, cube);
            }
        }
    }
}
