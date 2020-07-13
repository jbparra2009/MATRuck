using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.Threading.Tasks;

namespace MATruck.Application.BrokersAdmin
{
    public class CreateBroker
    {
        private readonly ApplicationDbContext _ctx;

        public CreateBroker(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var broker = new Broker
            {
                BrokerName = request.BrokerName,
                Description = request.Description,
                Email = request.Email,
                Phone1 = request.Phone1,
                Phone2 = request.Phone2,
                Address1 = request.Address1,
                Address2 = request.Address2,
                City = request.City,
                State = request.State,
                ZipCode = request.ZipCode,
                Status = request.Status,
            };

            _ctx.Brokers.Add(broker);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = broker.Id,
                BrokerName = broker.BrokerName,
                Description = broker.Description,
                Email = broker.Email,
                Phone1 = broker.Phone1,
                Phone2 = broker.Phone2,
                Address1 = broker.Address1,
                Address2 = broker.Address2,
                City = broker.City,
                State = broker.State,
                ZipCode = broker.ZipCode,
                Created = broker.Created,
                Status = broker.Status,
            };
        }

        public class Request
        {
            public string BrokerName { get; set; }
            public string Description { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Phone2 { get; set; }

            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public string Status { get; set; } // Active, Standby, Deleted.
        }

        public class Response
        {
            public int Id { get; set; }
            public string BrokerName { get; set; }
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
}
