using MATruck.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MATruck.Application.DispatchesAdmin
{
    public class GetDispatches
    {
        private readonly ApplicationDbContext _ctx;

        public GetDispatches(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<DispatchViewModel> Do() =>
            _ctx.Dispatches.ToList().Select(x => new DispatchViewModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Description = x.Description,
                Email = x.Email,
                Phone1 = x.Phone1,
                Phone2 = x.Phone2,
                Rate = x.Rate,
                Address1 = x.Address1,
                Address2 = x.Address2,
                City = x.City,
                State = x.State,
                ZipCode = x.ZipCode,
                SS = x.SS,
                CorpName = x.CorpName,
                EIN = x.EIN,
                Created = x.Created,
                Status = x.Status,
            });

        public class DispatchViewModel
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Description { get; set; }
            public string Email { get; set; }
            public string Phone1 { get; set; }
            public string Phone2 { get; set; }

            [Column(TypeName = "decimal(18,2)")]
            public decimal Rate { get; set; }

            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public string SS { get; set; }
            public string CorpName { get; set; }
            public string EIN { get; set; }

            public DateTime Created { get; set; }
            public string Status { get; set; } // Active, Standby, Deleted.

        }
    }
}
