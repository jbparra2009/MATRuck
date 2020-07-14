using System.Collections.Generic;
using MATruck.Application.Factories;
using MATruck.Database;
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

        public IEnumerable<GetFactories.FactoryViewModel> Factories { get; set; }

        public void OnGet()
        {
            Factories = new GetFactories(_ctx).Do();
        }
    }
}
