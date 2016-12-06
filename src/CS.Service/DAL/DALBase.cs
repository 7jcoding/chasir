using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace CS.Service.DAL
{
    public class DALBase
    {        
        protected PetaPoco.NetCore.Database db = null;
        protected static string _connectionString = string.Empty;

        /// <summary>
        /// 配置文件中的数据库连接名
        /// </summary>
        /// <param name="connectString"> </param>
        protected DALBase()
        {
            var config = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();
            _connectionString = config.GetConnectionString("DefaultConnection");
            db = new PetaPoco.NetCore.Database(new MySqlConnection(_connectionString));
        }
        /// <summary>
        /// 配置文件中的数据库连接名
        /// </summary>
        /// <param name="connectString"> </param>
        protected DALBase(string connectString)
        {
            db = new PetaPoco.NetCore.Database(new MySqlConnection(connectString));
        }
    }
}
