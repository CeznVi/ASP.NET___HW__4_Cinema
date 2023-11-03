using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AllCinemaLib;
using CinemaLib;

namespace ASP.CORE2023._10._28.Pages
{
    public class DetailsModel : PageModel
    {
        DataContainer all = DataContainer.Create();
        public CinemaModel data=null;
        public void OnGet(int pos)
        {
            if (pos >= 0 && pos < all.data.Count)
                data = all.data[pos];            
        }
    }
}
