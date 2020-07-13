using MATruck.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MATruck.Application.BrokersAdmin
{
    public class GetBroker
    {
        private readonly ApplicationDbContext _ctx;

        public GetBroker(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public BrokerViewModel Do(int id) => 
            _ctx.Brokers.Where(x => x.Id == id).Select(x => new BrokerViewModel
            {
                Id = x.Id,
                BrokerName = x.BrokerName,
                Description = x.Description,
                Email = x.Email,
                Phone1 = x.Phone1,
                Phone2 = x.Phone2,
                Address1 = x.Address1,
                Address2 = x.Address2,
                City = x.City,
                State = x.State,
                ZipCode = x.ZipCode,
                Created = x.Created,
                Status = x.Status,
            })
            .FirstOrDefault();

        public class BrokerViewModel
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
