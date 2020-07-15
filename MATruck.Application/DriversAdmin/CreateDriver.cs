using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MATruck.Application.DriversAdmin
{
    public class CreateDriver
    {
        private readonly ApplicationDbContext _ctx;

        public CreateDriver(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var driver = new Driver
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Description = request.Description,
                Email = request.Email,
                Phone1 = request.Phone1,
                Phone2 = request.Phone2,
                Rate = request.Rate,
                Address1 = request.Address1,
                Address2 = request.Address2,
                City = request.City,
                State = request.State,
                ZipCode = request.ZipCode,
                SS = request.SS,
                DOB = request.DOB,
                CDLClass = request.CDLClass,
                CDLIssued = request.CDLIssued,
                CDLExpires = request.CDLExpires,
                CDLState = request.CDLState,
                CorpName = request.CorpName,
                EIN = request.EIN,
                Status = request.Status,
            };

            _ctx.Drivers.Add(driver);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = driver.Id,
                FirstName = driver.FirstName,
                LastName = driver.LastName,
                Description = driver.Description,
                Email = driver.Email,
                Phone1 = driver.Phone1,
                Phone2 = driver.Phone2,
                Rate = driver.Rate,
                Address1 = driver.Address1,
                Address2 = driver.Address2,
                City = driver.City,
                State = driver.State,
                ZipCode = driver.ZipCode,
                SS = driver.SS,
                DOB = driver.DOB,
                CDLClass = driver.CDLClass,
                CDLIssued = driver.CDLIssued,
                CDLExpires = driver.CDLExpires,
                CDLState = driver.CDLState,
                CorpName = driver.CorpName,
                EIN = driver.EIN,
                Created = driver.Created,
                Status = driver.Status,
            };
        }

        public class Request
        {
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

            public string Status { get; set; } // Active, Standby, Deleted.

        }

        public class Response
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
