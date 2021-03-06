﻿using System;
using System.IO;
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
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseUrls("http://0.0.0.0:5000")
                .UseStartup<Startup>()
                .Build();
            webHost.Run();
        }
    }

    
}
