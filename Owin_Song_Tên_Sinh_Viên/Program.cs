using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Owin_Song_Tên_Sinh_Viên
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApp.Start<Startup>(url: "http://localhost:1111");
            HttpClient client = new HttpClient();
            Task<HttpResponseMessage> resp = client.GetAsync("http://localhost:1111/Owin/Song");
            var respone = resp.Result;
            Task<String> respMessage = respone.Content.ReadAsStringAsync();
            Console.WriteLine(respone);
            Console.WriteLine(respMessage.Result);
            Console.ReadLine();
        }
    }
}
