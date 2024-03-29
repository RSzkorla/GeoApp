﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;


namespace GeoAppServer
{
  public class Program
  {

    public static void Main(string[] args)
    {
      BuildWebHost(args).Run();
    }

    public static IWebHost BuildWebHost(string[] args)
    {
      return WebHost.CreateDefaultBuilder(args)
        .UseUrls("http://*:5000;http://localhost:5001")
        .UseStartup<Startup>()
        .Build();
    }
  }
}