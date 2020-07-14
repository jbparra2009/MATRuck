using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MATruck.Application.FactoriesAdmin
{
    public class UpdateFactory
    {
        private readonly ApplicationDbContext _ctx;

        public UpdateFactory(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var factory = _ctx.Factories.FirstOrDefault(x => x.Id == request.Id);

            factory.Name = request.Name;
            factory.Description = request.Description;
            factory.Email = request.Email;
            factory.Phone1 = request.Phone1;
            factory.Phone2 = request.Phone2;
            factory.Rate = request.Rate;
            factory.Address1 = request.Address1;
            factory.Address2 = request.Address2;
            factory.City = request.City;
            factory.State = request.State;
            factory.ZipCode = request.ZipCode;
            factory.Status = request.Status;

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = factory.Id,
                Name = factory.Name,
                Description = factory.Description,
                Email = factory.Email,
                Phone1 = factory.Phone1,
                Phone2 = factory.Phone2,
                Rate = factory.Rate,
                Address1 = factory.Address1,
                Address2 = factory.Address2,
                City = factory.City,
                State = factory.State,
                ZipCode = factory.ZipCode,
                Created = factory.Created,
                Status = factory.Status,
            };
        }

        public class Request
        {
            public int Id { get; set; }
            public string Name { get; set; }
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

            public string Status { get; set; } // Active, Standby, Deleted.

        }

        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
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

            public DateTime Created { get; set; }
            public string Status { get; set; } // Active, Standby, Deleted.

        }
    } 
}
