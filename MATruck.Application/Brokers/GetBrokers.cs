using MATruck.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MATruck.Application.GetBrokers
{
    public class GetBrokers
    {
        private readonly ApplicationDbContext _ctx;

        public GetBrokers(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<BrokerViewModel> Do() => 
            _ctx.Brokers.ToList().Select(x => new BrokerViewModel
            {
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
            });
    }

    public class BrokerViewModel
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

        public DateTime Created { get; set; }
        public string Status { get; set; } // Active, Standby, Deleted.

    }
}
