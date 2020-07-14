using System.Collections.Generic;
using MATruck.Application.Trucks;
using MATruck.Database;
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

        public IEnumerable<GetTrucks.TruckViewModel> Trucks { get; set; }

        public void OnGet()
        {
            Trucks = new GetTrucks(_ctx).Do();
        }
    }
}
