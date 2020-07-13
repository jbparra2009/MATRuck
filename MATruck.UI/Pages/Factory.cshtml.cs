using System.Collections.Generic;
using System.Threading.Tasks;
using MATruck.Application.CreateFactories;
using MATruck.Application.Factories;
using MATruck.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MATruck.UI.Pages
{
    public class FactoryModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public FactoryModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public CreateFactory.FactoryViewModel Factory { get; set; }

        public IEnumerable<GetFactories.FactoryViewModel> Factories { get; set; }

        public void OnGet()
        {
            Factories = new GetFactories(_ctx).Do();
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateFactory(_ctx).Do(Factory);

            return RedirectToPage("Broker");
        }
    }
}
