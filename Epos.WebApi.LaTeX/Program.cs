﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Epos.Blog.LaTeX
{
    public class Program
    {
        public static void Main(string[] args) {
            WebHost
                .CreateDefaultBuilder(args)
                .UseUrls("http://[::]:81")
                .UseStartup<Startup>()
                .Build()
                .Run();
        }
    }
}
