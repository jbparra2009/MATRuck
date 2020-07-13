using MATruck.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATruck.Application.BrokersAdmin
{
    public class UpdateBroker
    {
        private readonly ApplicationDbContext _ctx;

        public UpdateBroker(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var broker = _ctx.Brokers.FirstOrDefault(x => x.Id == request.Id);

            broker.BrokerName = request.BrokerName;
            broker.Description = request.Description;
            broker.Email = request.Email;
            broker.Phone1 = request.Phone1;
            broker.Phone2 = request.Phone2;
            broker.Address1 = request.Address1;
            broker.Address2 = request.Address2;
            broker.City = request.City;
            broker.State = request.State;
            broker.ZipCode = request.ZipCode;
            broker.Status = request.Status;

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
                Status = broker.Status,
            };     
        }

        public class Request
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
