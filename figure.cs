using System;

class Program
{
    static void Main() {
        int i, j, k=4;
        
        for(i=0; i<k; i++)
        {
            for(j=k;j>i+1;j--)
            {
                Console.Write(" ");
            }
            for(j=1; j<i+2;j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine("\n");
        }
        Console.WriteLine("**********\n");
        
        for(i=0; i<k; i++)
        {
            for(j=0;j<i;j++)
            {
                Console.Write(" ");
            }
            for(j=0; j<k-i;j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine("\n");
        }
    }
}
