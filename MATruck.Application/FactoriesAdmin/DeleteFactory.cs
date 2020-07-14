using MATruck.Database;
using System.Linq;
using System.Threading.Tasks;

namespace MATruck.Application.FactoriesAdmin
{
    public class DeleteFactory
    {
        private readonly ApplicationDbContext _ctx;

        public DeleteFactory(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<bool> Do(int id)
        {
            var Factory = _ctx.Factories.FirstOrDefault(x => x.Id == id);
            _ctx.Factories.Remove(Factory);

            await _ctx.SaveChangesAsync();

            return true;
        }
    } 
}
