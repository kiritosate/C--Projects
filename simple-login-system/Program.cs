
using System;

namespace kiritosate
{
    class LoginSystem{
        public static void Main(string[] args){
            
            string username, password;

            Console.Write("input your Username: ");
            username = Console.ReadLine();

            Console.Write("input your Password: ");
            password = Console.ReadLine();

            if(username == "admin" && password == "adminpassword"){
                Console.WriteLine("Welcome Back {0}", admin);
            }else{
                Console.WriteLine("Wrong username or password provided...");
            }

            Console.ReadKey();
        }
    }
}