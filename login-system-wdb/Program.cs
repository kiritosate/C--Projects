

using System;
using MySql.Data.MySqlClient;

class loginSystem{
    public static void Main(string[] args){

        string cs = @"server=localhost;userid=root;password=root;database=pydb";

        var con = new MySqlConnection(cs);
        con.Open();

        while(true){

            Console.Write("Enter Your Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Your Password: ");
            string password = Console.ReadLine();

            var cmd = new MySqlCommand($"SELECT * FROM users WHERE username='{username}' and password='{password}'", con);

            using MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read()){
                Console.WriteLine($"Welcome {username}!");
            }else{
                Console.WriteLine($"invalid cred...");
            }
            
        }
    }

}
