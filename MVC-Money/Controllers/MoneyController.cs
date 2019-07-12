using MVC_Money.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Money.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult List()
        {
            Random random = new Random();
            var diffDay = 0;
            var list = new List<MoneyViewModel>();
            string[] categoryArray = { "存入", "支出" };
            for (int i = 0; i < 100; i++)
            {
                diffDay -= random.Next(0, 7);
                var date = DateTime.Now.AddDays(diffDay);
                list.Add(new MoneyViewModel
                {
                    Category = categoryArray[random.Next(2)],
                    Date = date,
                    Money = (int)random.Next(10000)
                });
            }
            return View(list);
        }


    }
}