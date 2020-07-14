using System.Collections.Generic;
using MATruck.Application.Dispatches;
using MATruck.Database;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MATruck.UI.Pages
{
    public class DispatchModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public DispatchModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetDispatches.DispatchViewModel> Dispatches { get; set; }

        public void OnGet()
        {
            Dispatches = new GetDispatches(_ctx).Do();
        }
    }
}
