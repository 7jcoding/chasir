using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace chasir
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ///命令行配置端口号执行
            ///dotnet chasir.dll --server.urls="http://localhost:6001;http://localhost:6002"
            var host_config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();
            //配置文件配置端口号执行
            //var host_config = new ConfigurationBuilder()
            //.SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("hosting.json", optional: true)
            //.Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseConfiguration(host_config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
