using AllCinemaLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.CORE2023._10._28.Pages.Admin
{
    public class DeletePanelModel : PageModel
    {
		public DataContainer data = DataContainer.Create();


		public void OnGet()
        {
        }
    }
}
