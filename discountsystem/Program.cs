using System;

namespace discountsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Product ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();
            
            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            
            double totalPrice = price * quantity;
            Console.WriteLine($"Total Price is: {totalPrice}");
            
            if(totalPrice>5000){
                Console.WriteLine($"The Discounted Price is: {totalPrice*.2}\nThe Final Price is: {totalPrice-(totalPrice*.2)}");
            }
        }
    }
}
