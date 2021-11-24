using System;

namespace odd_even_while
{
    class Program
    {
        static void Main()
        {
            int odd = 0;
            int even = 0;
            int entries = 0;
            int i = 1;
            int temp = 0;
            char again;

            Console.Write("Enter Number of Entries: ");
            entries = Convert.ToInt32(Console.ReadLine());
        
            while(entries>=i){
                Console.Write("Number{0}: ", i);
                temp = Convert.ToInt32(Console.ReadLine());
                
                if(temp % 2 == 0){
                    even++;
                }else{
                    odd++;
                }
                i++;
            }

            Console.WriteLine("Total Odd: {0}", odd);
            Console.WriteLine("Total Even: {0}", even);

            

            while(true){
                Console.Write("Try Again[Yy/Nn]?___");
                again = Convert.ToChar(Console.ReadLine());

                if(again=='y' || again=='Y'){
                Main();
                }else if(again=='n' || again=='N'){
                    break;
                }else{
                    Console.WriteLine("invalid key try again..");
                }
            }
            
        }
    }
}
