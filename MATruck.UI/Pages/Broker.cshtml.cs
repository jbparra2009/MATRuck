using System.Collections.Generic;
using System.Threading.Tasks;
using MATruck.Application.CreateBrokers;
using MATruck.Application.GetBrokers;
using MATruck.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MATruck.UI.Pages
{
    public class BrokersModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public BrokersModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public Application.CreateBrokers.BrokerViewModel Broker { get; set; }

        public IEnumerable<Application.GetBrokers.BrokerViewModel> Brokers { get; set; }

        public void OnGet()
        {
            Brokers = new GetBrokers(_ctx).Do();
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateBroker(_ctx).Do(Broker);

            return RedirectToPage("Broker");
        }
    }
}
