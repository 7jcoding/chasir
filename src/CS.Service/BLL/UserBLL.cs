using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS.Model;
using CS.Service.DAL;

namespace CS.Service.BLL
{
    public class UserBLL
    {
        protected UserDAL _dal = new UserDAL();

        public int Add(User model)
        {
            return _dal.Add(model);
        }
        public User GetUser(int userId)
        {
            return _dal.GetUser(userId);
        }
    }
}
