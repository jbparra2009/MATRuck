using System.Collections.Generic;
using System.Threading.Tasks;
using MATruck.Application.CreateDrivers;
using MATruck.Application.GetDrivers;
using MATruck.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MATruck.UI.Pages
{
    public class DriverModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public DriverModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public Application.CreateDrivers.DriverViewModel Driver { get; set; }

        public IEnumerable<Application.GetDrivers.DriverViewModel> Drivers { get; set; }

        public void OnGet()
        {
            Drivers = new GetDrivers(_ctx).Do();
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateDriver(_ctx).Do(Driver);

            return RedirectToPage("Driver");
        }
    }
}
