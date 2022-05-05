using System;

class Program
{
    static void Main() {
        Console.WriteLine("Today is "+DateTime.Now.ToString("MMMM dd, yyyy"));
        
        Console.Write("Enter month of birth: ");
        int m = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter day of birth: ");
        int d = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter year of birth: ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        DateTime bd = new DateTime(y, m, d);
        
        int[] age = new int[3] {
            DateTime.Today.Year - bd.Year,
            DateTime.Today.Month + bd.Month+1,
            DateTime.Today.Day+(DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) - bd.Day)
        };
        
        Console.WriteLine("Your Birthday is "+bd.ToString("MMMM dd, yyyy"));
        
        if(DateTime.Today.Month<=bd.Month && DateTime.Today.Day<bd.Day)
            age[0] -=1;
        
        Console.Write("Your exact age is {0} year/s", age[0]);
        Console.Write(", {0} month/s", age[1]);
        Console.Write(", {0} day/s", age[2]);
        
    }
}
