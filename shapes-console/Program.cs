using System;

namespace shapes_console
{
    class Program
    {
        static void Main(string[] args)
        {
            reversePyramid(10);
        }

        public static void pyramid(int num){
            int Space, Number;

            for (int i = 1; i <= num; i++) // Total number of layer for pramid  
            {  
                for (Space = 1; Space <= (num - i); Space++) // Loop For Space  
                    Console.Write(" ");  
                for (Number = 1; Number <= i; Number++) //increase the value  
                    Console.Write(Number);  
                for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
                    Console.Write(Number);  
                Console.WriteLine();  
            } 
        }
        public static void reversePyramid(int num)
        {
            int space, number;

            for(int i=1;i<=num;i++)
            {
                for(space = 1;space <= (num-i);space++)
                    Console.Write(" ");
                for(number = 1;number<=i;number++)
                    Console.Write(number);
                for(number=(i-i);number>=1;number--)
                    Console.Write(number);
                Console.WriteLine();
            }
        }
        public static void halfPyramid(int num)
        {
            
            for(int i=1;i<=num;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine("");
            }
        }
        public static void reverseHalfPyramid(int num)
        {
            int k = num;
            for(int i=1;i<=num;i++)
            {
                for(int j=1;j<=k;j++)
                {
                    Console.Write(j + " ");
                }
                k--;
                Console.WriteLine();
            }
        }
    }
}
