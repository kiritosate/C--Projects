using System.Globalization;
using System;

namespace tesproj
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;

            while(start)
            {
                Console.Clear();
                Console.WriteLine("Teacher List Menu:");
                Console.WriteLine("1 - teacher");
                Console.WriteLine("2 - teacher");
                Console.WriteLine("3 - teacher");
                Console.WriteLine("4 - teacher");
                Console.WriteLine("5 - teacher");
                Console.WriteLine("6 - teacher");
                Console.WriteLine("7 - teacher");
                Console.WriteLine("9 - teacher");
                Console.WriteLine("10 - teacher");
                Console.WriteLine("11 - teacher");
                Console.WriteLine("12 - teacher");
                Console.Write("Who do you want to evaluate?: ");
                string choice = Console.ReadLine();

                //teachers personal data
                string tName = "", tSex = "", tStatus = "", tSubject = ""; 
                double tMonthlyIncome = 0.00;

                switch(choice){
                    case "1":
                        Console.WriteLine(choice);
                        break;
                    case "2":
                        Console.WriteLine(choice);
                        break;
                    case "3":
                        Console.WriteLine(choice);
                        break;
                    case "4":
                        Console.WriteLine(choice);
                        break;
                    case "5":
                        Console.WriteLine(choice);
                        break;
                    case "6":
                        Console.WriteLine(choice);
                        break;
                    case "7":
                        Console.WriteLine(choice);
                        break;
                    case "8":
                        Console.WriteLine(choice);
                        break;
                    case "9":
                        Console.WriteLine(choice);
                        break;
                    case "10":
                        Console.WriteLine(choice);
                        break;
                    case "11":
                        Console.WriteLine(choice);
                        break;
                    case "12":
                        Console.WriteLine(choice);
                        break;
                    default:
                        start = false;
                        break;
                }
                Console.ReadKey(true);
            }
        }
    }
}
