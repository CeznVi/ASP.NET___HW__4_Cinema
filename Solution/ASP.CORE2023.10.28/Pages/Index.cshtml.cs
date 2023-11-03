using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AllCinemaLib;
using CinemaLib;

namespace ASP.CORE2023._10._28.Pages
{
    public class IndexModel : PageModel
    {
        public DataContainer data = DataContainer.Create();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}