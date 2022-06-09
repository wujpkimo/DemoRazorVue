using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoRazorVue.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string Message { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Message = "Test msg from backend";
    }

    public JsonResult OnGetGetOption()
    {
        var options = new List<string>()
        {
            "Test1","test2","Mini","Mic"
        };
        return new JsonResult(options);
    }
}