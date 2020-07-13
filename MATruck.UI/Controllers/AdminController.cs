using MATruck.Application.BrokersAdmin;
using MATruck.Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MATruck.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _ctx;

        public AdminController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("brokers")]
        public IActionResult GetBrokers() => Ok(new GetBrokers(_ctx).Do());

        [HttpGet("brokers/{id}")]
        public IActionResult GetBroker(int id) => Ok(new GetBroker(_ctx).Do(id));

        [HttpPost("brokers")]
        public async Task<IActionResult> CreateBroker([FromBody] CreateBroker.Request request) => Ok(await new CreateBroker(_ctx).Do(request));

        [HttpDelete("brokers/{id}")]
        public async Task<IActionResult> DeleteBroker(int id) => Ok(await new DeleteBroker(_ctx).Do(id));

        [HttpPut("brokers")]
        public async Task<IActionResult> UpdateBroker([FromBody] UpdateBroker.Request request) => Ok(await new UpdateBroker(_ctx).Do(request));

    }
}
