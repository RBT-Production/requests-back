// ***********************************************************************
// Assembly         : WebAPI
// Author           : Andrey Lavrinenko
// Created          : 08-23-2019
//
// Last Modified By : Andrey Lavrinenko
// Last Modified On : 08-23-2019
// ***********************************************************************
// <copyright file="Program.cs" company="WebAPI">
//     Copyright (c) Andrey Lavrinenko. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebAPI
{
    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates the web host builder.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>IWebHostBuilder.</returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
