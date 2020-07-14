using System.Collections.Generic;
using MATruck.Application.Trailers;
using MATruck.Database;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MATruck.UI.Pages
{
    public class TrailerModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public TrailerModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetTrailers.TrailerViewModel> Trailers { get; set; }

        public void OnGet()
        {
            Trailers = new GetTrailers(_ctx).Do();
        }
    }
}
