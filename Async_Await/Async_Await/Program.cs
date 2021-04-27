using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program
    {
        static private void ScaricaPaginaWeb(string url)
        {
            WebClient web = new WebClient();
            string page = web.DownloadString(url);
            Console.WriteLine("Sincrono: Fine");
        }
        static private async void ScaricaPaginaWebAsync(string url)
        {
            WebClient web = new WebClient();
            string page = await web.DownloadStringTaskAsync(url);
            //Console.WriteLine(page);
            Console.WriteLine("Async: Fine");
        }
        static void Main(string[] args)
        {        
            ScaricaPaginaWebAsync("http://google.com");
            ScaricaPaginaWeb("http://google.com");
            Console.ReadKey();
        }
    }
}
