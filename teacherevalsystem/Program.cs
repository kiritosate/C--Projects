
using System.Dynamic;
using System.Data;
using Microsoft.VisualBasic;
using System.Threading;
using System;


namespace teacherevalsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            const string con1 = "On a scale of [1-10]"; 

            Console.Write("teachers entry: ");

            int entry = Convert.ToInt16(Console.ReadLine());

            while(entry>0){
                int wRate;
                Console.Clear();
                
                Console.Write("Teacher Name: ");

                string teachName = Console.ReadLine();

                Console.Write("Subject Name: ");

                string subName = Console.ReadLine();

                Console.WriteLine("Answer The following using a scale of 1 to 10.\n1 being the lowest[bad] and 10 being the highest[excelent].\n".ToUpper());
                
                Console.Write("{0} how do you rate ma'am/sir {1} approachableness? : ", con1, teachName);
                int approachRate = Convert.ToInt16(Console.ReadLine()+0);

                Console.Write("{0} how do you rate ma'am/sir {1} critical thinking? : ", con1, teachName);
                int criticalThinkingRate = Convert.ToInt16(Console.ReadLine()+0);

                Console.Write("{0} how do you rate ma'am/sir {1} arrangement? : ", con1, teachName);
                int arrangeRate = Convert.ToInt16(Console.ReadLine()+0);

                Console.Write("{0} how do you rate ma'am/sir {1} time management? : ", con1, teachName);
                int timeManagementRate = Convert.ToInt16(Console.ReadLine()+0);
                
                Console.Write("{0} how do you rate ma'am/sir {1} patience? : ", con1, teachName);
                int patienceRate = Convert.ToInt16(Console.ReadLine()+0);

                Console.Write("and lastly would you want ma'am/sir {0} to be your subject teacher in {1}? [yes/no]: ", teachName, subName);
                string wantRate = Console.ReadLine();
                Console.Write("do you want to evaluate now? click <any key>: ");
                Console.ReadKey(true);

                if(wantRate == "yes"){
                    wRate = 100;
                }else{
                    wRate = 50;
                }

                int eval = Convert.ToInt32(((approachRate*.2)+(criticalThinkingRate*.1)+(arrangeRate*.1)+(timeManagementRate*1)+(patienceRate*.2)+(wRate*.3))*.5);

                Console.WriteLine(eval);
                entry--;
                Console.ReadKey(true);
            }
        }
    }
}
