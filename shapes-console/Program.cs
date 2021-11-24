using System;

namespace shapes_console
{
    class Program
    {
        static void Main(string[] args)
        {
            pyramid(5);
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
    }
}
