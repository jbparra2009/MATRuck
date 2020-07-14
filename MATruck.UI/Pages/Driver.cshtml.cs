using System.Collections.Generic;
using MATruck.Application.Drivers;
using MATruck.Database;
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

        public IEnumerable<GetDrivers.DriverViewModel> Drivers { get; set; }

        public void OnGet()
        {
            Drivers = new GetDrivers(_ctx).Do();
        }

    }
}
