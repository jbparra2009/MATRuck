using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.Threading.Tasks;

namespace MATruck.Application.CreateBrokers
{
    public class CreateBroker
    {
        private readonly ApplicationDbContext _ctx;

        public CreateBroker(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Do(BrokerViewModel vm)
        {
            _ctx.Brokers.Add(new Broker
            {
                Name = vm.Name,
                Description = vm.Description,
                Email = vm.Email,
                Phone1 = vm.Phone1,
                Phone2 = vm.Phone2,
                Address1 = vm.Address1,
                Address2 = vm.Address2,
                City = vm.City,
                State = vm.State,
                ZipCode = vm.ZipCode,
                Created = vm.Created,
                Status = vm.Status,
            });

            await _ctx.SaveChangesAsync();
        }
 
    }
    public class BrokerViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public DateTime Created { get; set; }
        public string Status { get; set; } // Active, Standby, Deleted.

    }
}
