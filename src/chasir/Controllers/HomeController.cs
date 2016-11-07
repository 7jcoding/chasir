using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using CS.Model;
using CS.Service.BLL;

namespace chasir.Controllers
{
    public class HomeController : Controller
    {
        public SiteConfig config;
        public HomeController(IOptions<SiteConfig> option)
        {
            config = option.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            //var _strConn = "Data Source=192.168.1.221;Initial Catalog=fanhuansqlserver;User ID=sa;Password=123456";
            //var db = new PetaPoco.NetCore.Database(new SqlConnection(_strConn));
            //StringBuilder result = new StringBuilder();
            //foreach (var orderId in db.Query<string>("SELECT OrderId FROM KS_ORDER WHERE USERID = @0", 224))
            //{
            //    result.AppendFormat("{0}|", orderId);
            //}

            //using (SqlConnection connection = new SqlConnection(_strConn))
            //{
            //    connection.Open();
            //    DynamicParameters p = new DynamicParameters();
            //    p.Add("@UserId", 224);
            //    var list = connection.Query<string>("SELECT OrderId FROM KS_ORDER WHERE USERID = @UserId", p);
            //    foreach (var orderId in list)
            //    {
            //        result.AppendFormat("{0}|", orderId);
            //    }
            //}


            //ViewBag.Redis = result.ToString();
            //var user = new UserBLL().GetUser(224);       
            config.Name = config.Name + new UserBLL().Add(new User { UserName = "lin",Password ="123",Mobile = "11111111111",Email = "test@linggan.com",RegTime=DateTime.Now,RegIp = Request.Host.Host.ToString() });
            return View(config);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
