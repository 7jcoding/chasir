using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS.Model;
using PetaPoco.NetCore;

namespace CS.Service.DAL
{
    public class UserDAL : DALBase
    {
        private readonly string table_name = "test_user";
        private readonly string primary_key = "UserName";
        //public UserDAL() : base("Data Source = 192.168.1.221; Initial Catalog = fanhuansqlserver; User ID = sa; Password=123456")
        //{ }

        /// <summary>
        /// 添加一个用户数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        internal int Add(User model)
        {
            var result = db.Insert(table_name, primary_key, model);
            return result == null ? 0 : Convert.ToInt32(result);
        }
        internal User GetUser(int userId)
        {
            return db.FirstOrDefault<User>("SELECT * FROM KS_USER WHERE USERID = @0", userId);
        }
    }
}
