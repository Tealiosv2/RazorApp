using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages;

public class IndexModel : PageModel
{
    public string? Company { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }



    public void OnGet()
    {
        ViewData["MyName"] = "Wyman Ng";
        Company = "A01295107";
    }
    
    public void OnPost(){

    }
}
