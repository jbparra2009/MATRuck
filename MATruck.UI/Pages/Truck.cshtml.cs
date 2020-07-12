using System.Collections.Generic;
using System.Threading.Tasks;
using MATruck.Application.CreateTrucks;
using MATruck.Application.GetTrucks;
using MATruck.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MATruck.UI.Pages
{
    public class TruckModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public TruckModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public Application.CreateTrucks.TruckViewModel Truck { get; set; }

        public IEnumerable<Application.GetTrucks.TruckViewModel> Trucks { get; set; }

        public void OnGet()
        {
            Trucks = new GetTrucks(_ctx).Do();
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateTruck(_ctx).Do(Truck);

            return RedirectToPage("Truck");
        }
    }
}
