using MVC_Money.Models.EntityModel;
using MVC_Money.Models.ViewModels;
using MVC_Money.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Money.Controllers
{
    public class MoneyController : Controller
    {
        MoneyService moneyService;

        public MoneyController()
        {
            this.moneyService = new MoneyService();
        }

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
            var db = moneyService.getList();
            var list = new List<MoneyViewModel>();
            string[] categoryArray = { "存入", "支出" };
            foreach (var item in db)
            {
                list.Add(new MoneyViewModel
                {
                    Category = categoryArray[item.Categoryyy],
                    Date = item.Dateee,
                    Money = item.Amounttt,
                    Note = item.Remarkkk
                });
            }
            return View(list);
        }


    }
}