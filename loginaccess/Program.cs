using System;
using System.Data.OleDb;

namespace loginaccess
{
    class Program
    {
        static void Main(string[] args)
        {
            /* OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pydb.accdb"); */
            Console.WriteLine(OleDbConnection);

            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pydb.accdb;Persist Security Info=True");
        //set up connection string
            OleDbCommand command = new OleDbCommand("select * from Employee where Login=@login", connect);
        }
    }
}
