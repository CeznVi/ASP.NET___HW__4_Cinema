using AllCinemaLib;
using CinemaLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.CORE2023._10._28.Pages
{
    public class SeaarchModel : PageModel
    {
        DataContainer allCinema = DataContainer.Create();

        public List<CinemaModel> searhResult = null;

        public void OnGet(string typeSearh, string searchData)
        {
            if (searchData != null)
            {
                if (typeSearh == "fName")
                {
                    searhResult = allCinema.FindByFname(searchData);
                }
                else if (typeSearh == "fInf")
                {
                    searhResult = allCinema.FindByfInf(searchData);
                }
                else if(typeSearh == "fDir")
                {
                    searhResult = allCinema.FindByfDir(searchData);
                }

            }
            
            //searhResult = allCinema.data.FindAll((p) => p.Name == searchData);
            // searhResult = allCinema.data;

            //if(searchData != null) 
            //{ 
            //    if(typeSearh == "fName") 
            //    {
            //        searhResult = allCinema.data;
            //    }

            //}
        }


    }
}
