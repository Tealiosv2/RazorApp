using Microsoft.AspNetCore.Mvc.RazorPages;
namespace zodiac.Pages;

using Microsoft.AspNetCore.Mvc;
using zodiac.Models;
public class ZodiacModel : PageModel
{
    public string Zodiac { get; set; }
    public string ZodiacImg { get; set; }

    public string message { get; set; }

    [BindProperty]
    public int year { get; set; }

        private readonly ILogger<IndexModel> _logger;

    public void OnPost(Utils Models)
    {
        if (year >= 1900 && year <= 2024){
            Zodiac = Models.GetZodiac(year);

            ZodiacImg = "/images/" + Zodiac + ".png";
        }else{
            message = "Please enter a year between 1900 and 2024";
        }

        

    }


}
