

using System;

class Program
{
    static void Main() {
        int num1, num2;
        
        Console.Write("enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if(num1 == num2){
            Console.WriteLine("the numbers are equal...");
        }else{
            Console.WriteLine("the numbers are not equal...");
        }
    }
}