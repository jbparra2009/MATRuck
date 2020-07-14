using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MATruck.Application.DriversAdmin
{
    public class UpdateDriver
    {
        private readonly ApplicationDbContext _ctx;

        public UpdateDriver(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var driver = _ctx.Drivers.FirstOrDefault(x => x.Id == request.Id);

            driver.FirstName = request.FirstName;
            driver.LastName = request.LastName;
            driver.Description = request.Description;
            driver.Email = request.Email;
            driver.Phone1 = request.Phone1;
            driver.Phone2 = request.Phone2;
            driver.Rate = request.Rate;
            driver.Address1 = request.Address1;
            driver.Address2 = request.Address2;
            driver.City = request.City;
            driver.State = request.State;
            driver.ZipCode = request.ZipCode;
            driver.SS = request.SS;
            driver.DOB = request.DOB;
            driver.CDLClass = request.CDLClass;
            driver.CDLIssued = request.CDLIssued;
            driver.CDLExpires = request.CDLExpires;
            driver.CDLState = request.CDLState;
            driver.CorpName = request.CorpName;
            driver.EIN = request.EIN;
            driver.Status = request.Status;

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
