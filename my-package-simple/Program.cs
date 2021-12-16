
using System.ComponentModel;
using System;
using my_package_simple;

namespace my_package_simple
{
    class Program
    {
        static void Main()
        {
            foreach(string i in Users.user())
            {
                if(i is not null){
                    Console.Write($"{i}, ");
                }
                
            }
        }
    }
}
