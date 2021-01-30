using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HTTP_POST_REQUESTS
{
    class Program
    {
        static async void sendingReq()
        {
            Console.WriteLine("Input: ");
            var content = new StringContent(Console.ReadLine());
            HttpClient client = new HttpClient();
            var response = await client.PostAsync("http://localhost:3000/test", content);
            var responseString = await response.Content.ReadAsStringAsync();
        }
        static void Main(string[] args)
        {
            sendingReq();

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
