using MATruck.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MATruck.Application.DriversAdmin
{
    public class GetDriver
    {
        private readonly ApplicationDbContext _ctx;

        public GetDriver(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public DriverViewModel Do(int id) =>
            _ctx.Drivers.Where(x => x.Id == id).Select(x => new DriverViewModel
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
                DOB = x.DOB,
                CDLClass = x.CDLClass,
                CDLIssued = x.CDLIssued,
                CDLExpires = x.CDLExpires,
                CDLState = x.CDLState,
                CorpName = x.CorpName,
                EIN = x.EIN,
                Created = x.Created,
                Status = x.Status,

            })
            .FirstOrDefault();

        public class DriverViewModel
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
            public DateTime DOB { get; set; }
            public string CDLClass { get; set; }
            public DateTime CDLIssued { get; set; }
            public DateTime CDLExpires { get; set; }
            public string CDLState { get; set; }

            public string CorpName { get; set; }
            public string EIN { get; set; }

            public DateTime Created { get; set; }
            public string Status { get; set; } // Active, Standby, Deleted.

        }
    }
}
