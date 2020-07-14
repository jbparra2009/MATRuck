using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MATruck.Application.FactoriesAdmin
{
    public class CreateFactory
    {
        private readonly ApplicationDbContext _ctx;

        public CreateFactory(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var factory = new Factory
            {
                Name = request.Name,
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

            _ctx.Factories.Add(factory);

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
