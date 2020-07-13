using System.Collections.Generic;
using System.Threading.Tasks;
using MATruck.Application.CreateTrailers;
using MATruck.Application.Trailers;
using MATruck.Database;
using Microsoft.AspNetCore.Mvc;
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

        [BindProperty]
        public CreateTrailer.TrailerViewModel Trailer { get; set; }

        public IEnumerable<GetTrailers.TrailerViewModel> Trailers { get; set; }

        public void OnGet()
        {
            Trailers = new GetTrailers(_ctx).Do();
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateTrailer(_ctx).Do(Trailer);

            return RedirectToPage("Trailer");
        }
    }
}
