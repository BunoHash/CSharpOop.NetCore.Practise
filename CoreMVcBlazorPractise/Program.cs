using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CorePractise
{
    public class Program
    {
        public static System.Net.WebSockets.WebSocket wb = null;
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();



            List<int> numbs = new List<int>(2);
            numbs[2] = 9;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        //numbs[0]
     

    }
}
