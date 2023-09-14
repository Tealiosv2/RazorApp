using Microsoft.AspNetCore.Mvc.RazorPages;
namespace zodiac.Pages;

using Microsoft.AspNetCore.Mvc;
using zodiac.Models;
public class ZodiacModel : PageModel
{
    public string Zodiac { get; set; }
    public string ZodiacImg { get; set; }

    public string Message { get; set; }

    [BindProperty]
    public int Year { get; set; }

    public void OnPost(Utils Models)
    {
        if (Year >= 1900 && Year <= 2024){
            Zodiac = Models.GetZodiac(Year);

            ZodiacImg = "/images/" + Zodiac + ".png";
        }else{
            Message = "Please enter a year between 1900 and 2024";
        }

        

    }


}
