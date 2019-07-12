using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Money.Models.ViewModels
{
    public class MoneyViewModel
    {
        [Display(Name = "類別")]
        public String Category { get; set; }
        [Display(Name = "日期")]
        public DateTime Date { get; set; }
        [Display(Name = "金額")]
        public int Money { get; set; }
        [Display(Name = "備註")]
        public string Note { get; set; }
    }
}