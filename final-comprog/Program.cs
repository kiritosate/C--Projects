using System;

namespace final_comprog
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tries = true;
            while(tries){
                int letters=0, numbers=0;

                Console.Write("Enter any string: ");
                string str = Console.ReadLine();

                for(int i=0;i<str.Length;i++){
                    if(str[i] >= 'a' && str[i] <='z' || str[i] >= 'A' && str[i] <='Z'){
                        letters++;
                    }else if(str[i] >= '0' && str[i] <= '9'){
                        numbers++;
                    }
                }

                Console.WriteLine("Length of the string: "+str.Length);
                Console.WriteLine("Numbers of Letters in the string: "+letters);
                Console.WriteLine("Number of Digits in the string: "+numbers);

                Console.Write("Want to try again?: ");
                string again = Console.ReadLine();

                if(again == "y" || again == "Y"){
                    tries = true;
                }else{
                    tries = false;
                }
            }
            
        }
    }
}
