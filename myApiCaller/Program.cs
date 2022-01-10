using System.Text;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace myApiCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var client = new HttpClient())
            {
                var endPoint = new Uri("https://jsonplaceholder.typicode.com/posts");
                
                var result = client.GetAsync(endPoint).Result.Content.ReadAsStringAsync().Result;

                var payload = JsonConvert.SerializeObject(result);
                var a = new StringContent(payload, Encoding.UTF8, "application/json");
                
                List<Post> post = JsonConvert.DeserializeObject<List<Post>>(result);

                foreach(var item in post){
                    Console.WriteLine();
                }

                //var newPost = new Post()
                //{
                //    Title = "test post",
                //    Body = "hello world!",
                //    UserId = 44
                //}; 
                //var newJson = JsonConvert.SerializeObject(newPost);
                //var payload = new StringContent(newJson, Encoding.UTF8, "application/json");

                //var result = client.PostAsync(endPoint, payload);

                //Console.WriteLine(result.Result.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
