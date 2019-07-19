using MVC_Money.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Money.Services
{
    public class MoneyService
    {
        MoneyDbContext model1;

        public MoneyService()
        {
            this.model1 = new MoneyDbContext();
        }

        public IEnumerable<AccountBook> getList()
        {
            return model1.AccountBook.ToList();
        }
    }
}