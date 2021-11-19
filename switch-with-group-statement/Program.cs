using System;

class Program
{
    static void Main() {
        
        int firstnumber, secondnumber, oper;
        
        Console.Write("enter first number: ");
        firstnumber = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("enter second number: ");
        secondnumber = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Menu:\n 1 - Addition\n 2 - Subtraction\n 3 - Multiplication\n 4 - Division\n 5 - Exit\nChoose Operation: ");
        oper = Convert.ToInt32(Console.ReadLine());
        
        switch(oper){
            case 1:
                Console.WriteLine($"The Sum of {firstnumber} and {secondnumber} is: {firstnumber+secondnumber}");
                break;
            case 2:
                Console.WriteLine($"The Difference of {firstnumber} and {secondnumber} is: {firstnumber-secondnumber}");
                break;
            case 3:
                Console.WriteLine($"The Product of {firstnumber} and {secondnumber} is: {firstnumber*secondnumber}");
                break;
            case 4:
                Console.WriteLine($"The Quotient of {firstnumber} and {secondnumber} is: {firstnumber/secondnumber}");
                break;
            default:
                break;
        }
    }
}