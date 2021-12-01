using System;


class Program
{
    static void Main()
    {
        int odd = 0;
        int even = 0;
        int entries = 0;
        int i = 1;
        int number = 0;
        char choice;

        Console.Write("Enter Number of Entries: ");
        entries = Convert.ToInt32(Console.ReadLine());
    
        while(entries>=i){
            Console.Write("Number{0}: ", i);
            number = Convert.ToInt32(Console.ReadLine());
            
            if(number % 2 == 0){
                even+=number;
            }else{
                odd+=number;
            }
            i++;
        }

        Console.WriteLine("Total Odd: {0}\nTotal Even: {1}", odd, even);

        while(true){
            Console.Write("Try again[Yy/Nn]?___");

            choice = Convert.ToChar(Console.ReadLine());

            if(choice=='y' || choice=='Y'){
                Main();
            }else if(choice=='n' || choice=='N'){
                break;
            }else{
                Console.WriteLine("invalid key try again..");
            }
        }
        
    }
}
