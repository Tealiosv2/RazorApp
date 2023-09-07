using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorApp.Pages
{
    public class Future : PageModel
    {
        private readonly ILogger<Future> _logger;

        public Future(ILogger<Future> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}