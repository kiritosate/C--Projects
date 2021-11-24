using System;

namespace odd_even_while
{
    class Program
    {
        static void Main()
        {
            //initializing variables

            int odd = 0; //total odd number in entries

            int even = 0; //total even number in entries

            int entries = 0; // number of entries you want to check

            int i = 1; //used to compare in entries or loop. 

            int temp = 0; //this is where the entered number.

            char again; //char variable to ask for yes/y or no/n to try again.

            /*ask the user to enter number of entries, for example 3 entries will result to
                Number1: 
                Number2:
                Number3:
            */
            Console.Write("Enter Number of Entries: ");

            entries = Convert.ToInt32(Console.ReadLine());

            /* 
                this is where the number loop happens. and will ask number from user,
                will loop until integer i, is equal to entries which the user enteres;

            */

            while(entries>=i){

                Console.Write("Number{0}: ", i);

                temp = Convert.ToInt32(Console.ReadLine());
                
                if(temp % 2 == 0){ //checks whether the entered number is even, and if not then its odd
                    even++; // increase the total even if true
                }else{
                    odd++;  //increases the total number of odd if false
                }
                i++; //increments variable i every loop until it is equals to number of entries
            }

            /*
                writes in the console the total odds, and evens
            */
            Console.WriteLine("Total Odd: {0}", odd);

            Console.WriteLine("Total Even: {0}", even);

            /*
                a loop that asks the user if they want to try again, choices are yes or no;
                if not equals to either y or n, then continue the loop
            */

            while(true){
                
                Console.Write("Try Again[Yy/Nn]?___");

                again = Convert.ToChar(Console.ReadLine());

                if(again=='y' || again=='Y'){

                    Main();

                }else if(again=='n' || again=='N')
                {
                    break;
                }else
                {
                    Console.WriteLine("invalid key try again..");
                }
            }
            
        }
    }
}
