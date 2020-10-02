using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PennslyvaniaNationalParks.Models;

namespace PennslyvaniaNationalParks.Pages
{
    public class ParksModel : PageModel
    {
        public List<Models.Parks> paParks;
        public void OnGet()
        {
            ParksContext context = HttpContext.RequestServices.GetService(typeof(ParksContext)) as ParksContext;
            paParks = context.GetAllParks();
        }
    }
}
