using System;

class Program
{
    static void Main() {
        int total = 0;
        
        Console.WriteLine("VACCINATED: ");
        int[] v = calc();
        
        Console.WriteLine("NON-VACCINATED: ");
        int[] nv = calc();
        
        Console.WriteLine("Number of Vaccinated Students Per Year Level: \n");
        for(int a=0; a<4; a++)
        {
            Console.WriteLine("BSIT {0}:\t{1}", a+1, v[a]);
            total += v[a];
        }
        Console.WriteLine("Total Number of Vaccinated Students: "+total);
        
        total = 0;
        Console.WriteLine("Number of Non-Vaccinated Students Per Year Level: \n");
        for(int b=0; b<4; b++)
        {
            Console.WriteLine("BSIT {0}:\t{1}", b+1, nv[b]);
            total += nv[b];
        }
        Console.WriteLine("Total Number of Non-Vaccinated Students: "+total);
    }
    static int[] calc()
    {
        int[] arr = new int[4] {0,0,0,0};
        string[] s = new string[2] {"A", "B"};
        
        for(int i=0; i<4; i++)
        {
            for(int j=0; j<2; j++)
            {
                Console.Write("\tBSIT {0}-{1}: ",i+1, s[j]);
                arr[i] += Convert.ToInt32(Console.ReadLine());
            }
        }
        return arr;
    }
}
