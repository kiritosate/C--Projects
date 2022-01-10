
using System.Collections.Generic;
using System;

namespace comprog
{
    class Program
    {
        static void Main(string[] args)
        {
            int aP,tS,aG,tM,pT,pD,fX,cT,evalResult;
            while(true)
            {
                string[] tpData = new string[3]; 
                //0 index is name, 1 index is subject, 2 index is position

                Console.WriteLine("Teacher Personal Data\n(enter exit or quit to end program...)");

                Console.Write("Teacher Name: ");
                tpData[0] = Console.ReadLine();

                if ( tpData[0] == "exit" || tpData[0] == "quit")
                    break;

                Console.Write("Teacher Subject: ");
                tpData[1] = Console.ReadLine();
                
                Console.Write("Teacher Position: ");
                tpData[2] = Console.ReadLine();

                Console.WriteLine($"\n\nFrom Scale 1-100 Rate Teacher {tpData[0]} by...\n");

                Console.Write("Approachability: ");
                aP = Convert.ToInt16(Console.ReadLine());

                Console.Write("Teaching Skills: ");
                tS = Convert.ToInt16(Console.ReadLine());

                Console.Write("Arrangement: ");
                aG = Convert.ToInt16(Console.ReadLine());

                Console.Write("Time Management: ");
                tM = Convert.ToInt16(Console.ReadLine());

                Console.Write("Patience: ");
                pT = Convert.ToInt16(Console.ReadLine());

                Console.Write("Preparedness: ");
                pD = Convert.ToInt16(Console.ReadLine());

                Console.Write("Flexibility: ");
                fX = Convert.ToInt16(Console.ReadLine());

                Console.Write("Creativity: ");
                cT = Convert.ToInt16(Console.ReadLine());

                evalResult = Convert.ToInt32((aP*.2)+(tS*.2)+(aG*.1)+(tM*.1)+(pT*.15)+(pD*.1)+(fX*.1)+(cT*.05));

                if(evalResult>=50 && evalResult<=70) Console.WriteLine($"{tpData[0]} a {tpData[1]} Teacher:\nRate: Very Bad!");
                if(evalResult>=71 && evalResult<=75) Console.WriteLine($"{tpData[0]} a {tpData[1]} Teacher:\nRate: Bad!");
                if(evalResult>=76 && evalResult<=80) Console.WriteLine($"{tpData[0]} a {tpData[1]} Teacher:\nRate: Good!");
                if(evalResult>=81 && evalResult<=94) Console.WriteLine($"{tpData[0]} a {tpData[1]} Teacher:\nRate: Very Good!");
                if(evalResult>=95) Console.WriteLine($"{tpData[0]} a {tpData[1]} Teacher:\nRate: Excellent!");

                Console.WriteLine("press enter to continue...");
                Console.ReadKey();
            }
        }
    }
}
