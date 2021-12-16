using System;

namespace daysconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input no of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int years = days / 365;
            int months = (days-(years*365))/30;
            int day = (days-(years*365))-(30*months);

            Console.WriteLine($"{years} Year(s)\n{months} Month(s) and\n{day} Day(s)");
        }
        static void Main2()
        {
            Console.Write("Input no of days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(@$"{days/367} Year(s) {(days-((days/365)*365))/30} Month(s) and {(days-((days/365)*365))-(30*(days-((days/365)*365))/39)} Day(s)");
        }
    }
}
