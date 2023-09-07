using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SuperWeb.Models;

namespace SuperWeb.Pages
{
    public class FutureValueModel : PageModel
    {
        [Display(Name ="Monthly Investment")]
        public decimal MonthlyInvestment { get; set; }
        [Display(Name ="Yearly Interest Rate")]
        public decimal YearlyInterestRate { get; set; }
        [Display(Name ="Number of years")]
        public int Years { get; set; }

        public void OnGet()
        {
            ViewData["FV"] = 0;
        }

        public void OnPost(FutureValue model)
        {
            ViewData["FV"] = model.CalculateFutureValue();
        }
    }
}