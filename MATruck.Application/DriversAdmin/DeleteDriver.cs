using MATruck.Database;
using System.Linq;
using System.Threading.Tasks;

namespace MATruck.Application.DriversAdmin
{
    public class DeleteDriver
    {
        private readonly ApplicationDbContext _ctx;

        public DeleteDriver(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var Driver = _ctx.Drivers.FirstOrDefault(x => x.Id == id);
            _ctx.Drivers.Remove(Driver);

            await _ctx.SaveChangesAsync();

            return true;
        }

    }
}
