using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace CS.Service.DAL
{
    public class DALBase
    {        
        protected PetaPoco.NetCore.Database db = null;
        protected static string _connectString = "server=127.0.0.1; userid=root; password=root; database=test; pooling=false;Port=3306;";

        /// <summary>
        /// 配置文件中的数据库连接名
        /// </summary>
        /// <param name="connectString"> </param>
        protected DALBase()
        {
            db = new PetaPoco.NetCore.Database(new MySqlConnection(_connectString));
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
