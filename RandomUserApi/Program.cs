using System.Net;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace RandomUserApi
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRandomUser(2);
        }
        public static void GetUserData()
        {
            using(var client = new HttpClient())
            {
                var url = new Uri("https://jsonplaceholder.typicode.com/users");
                var result = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                
                List<userData> post_data = JsonConvert.DeserializeObject<List<userData>>(result);

                foreach(var item in post_data)
                {
                    Console.WriteLine($"[ {item.name} {item.email} ]");
                }
                
            }
        }
        public static void GetPost()
        {
            using(var client = new HttpClient())
            {
                var url = new Uri("https://jsonplaceholder.typicode.com/posts");

                var result = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;

                var json_data = JsonConvert.SerializeObject(result);
                List<Data> post_data = JsonConvert.DeserializeObject<List<Data>>(result);

                foreach(var item in post_data)
                {
                    Console.WriteLine($"[ {item.Title} {item.Body} ]");
                }
            }
        }
        public static void GetRandomUser(int user_times=1)
        {
            using(var client = new HttpClient())
            {
                var url = new Uri("https://randomuser.me/api");

                for(var i=0;user_times>i;i++)
                {
                    var result = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                    var result_data = JsonConvert.SerializeObject(result);
                    
                    //userData userdata = JsonConvert.DeserializeObject<userData>(result);
                    userData data_result = JsonConvert.DeserializeObject<userData>(result);
                    Console.WriteLine(data_result.results);
                    Console.WriteLine(data_result.GetType());
                }
            }
        }
    }
    public class Data
    {
        public string Title {get;set;}
        public string Body {get;set;}
        public int userId {get;set;}
    }
    public class userData
    {
        public object name {get;set;}
        public string picture {get;set;}
        public string gender {get;set;}
        public string email {get;set;}
        public string age {get;set;}
        public object info {get;set;}
        public object results {get;set;}
    }
}
