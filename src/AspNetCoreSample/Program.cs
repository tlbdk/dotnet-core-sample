using System;
using Microsoft.AspNetCore.Hosting;

namespace AspNetCoreSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Loading web host");
            var webHost = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            webHost.Run();
        }
    }

    
}
