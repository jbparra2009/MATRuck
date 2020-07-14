using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MATruck.Application.TrucksAdmin
{
    public class CreateTruck
    {
        private readonly ApplicationDbContext _ctx;

        public CreateTruck(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var truck = new Truck
            {
                VIN = request.VIN,
                Year = request.Year,
                Make = request.Make,
                Type = request.Type,
                Class = request.Class,
                BodyType = request.BodyType,
                Lenght = request.Lenght,
                Description = request.Description,
                TruckPlate = request.TruckPlate,
                TruckNumber = request.TruckNumber,
                RegistrantName = request.RegistrantName,
                TitleState = request.TitleState,
                OwnerLessorName = request.OwnerLessorName,
                ExpiresDate = request.ExpiresDate,
                EfectiveDate = request.EfectiveDate,
                IssueDate = request.IssueDate,
                PurchasePrice = request.PurchasePrice,
                PurchaseDate = request.PurchaseDate,
                Status = request.Status,
            };

            _ctx.Trucks.Add(truck);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = truck.Id,
                VIN = truck.VIN,
                Year = truck.Year,
                Make = truck.Make,
                Type = truck.Type,
                Class = truck.Class,
                BodyType = truck.BodyType,
                Lenght = truck.Lenght,
                Description = truck.Description,
                TruckPlate = truck.TruckPlate,
                TruckNumber = truck.TruckNumber,
                RegistrantName = truck.RegistrantName,
                TitleState = truck.TitleState,
                OwnerLessorName = truck.OwnerLessorName,
                ExpiresDate = truck.ExpiresDate,
                EfectiveDate = truck.EfectiveDate,
                IssueDate = truck.IssueDate,
                PurchasePrice = truck.PurchasePrice,
                PurchaseDate = truck.PurchaseDate,
                Status = truck.Status,
            };
        }

        public class Request
        {
            public string VIN { get; set; }
            public string Year { get; set; }
            public string Make { get; set; }
            public string Type { get; set; }
            public string Class { get; set; }
            public string BodyType { get; set; }
            public string Lenght { get; set; }
            public string Description { get; set; }

            public string TruckPlate { get; set; }
            public string TruckNumber { get; set; }

            public string RegistrantName { get; set; }
            public string TitleState { get; set; }
            public string OwnerLessorName { get; set; }
            public DateTime ExpiresDate { get; set; }
            public DateTime EfectiveDate { get; set; }
            public DateTime IssueDate { get; set; }
            public int PurchasePrice { get; set; }
            public DateTime PurchaseDate { get; set; }

            public string Status { get; set; } // Active, Standby, Sold, Deleted.

        }

        public class Response
        {
            public int Id { get; set; }
            public string VIN { get; set; }
            public string Year { get; set; }
            public string Make { get; set; }
            public string Type { get; set; }
            public string Class { get; set; }
            public string BodyType { get; set; }
            public string Lenght { get; set; }
            public string Description { get; set; }

            public string TruckPlate { get; set; }
            public string TruckNumber { get; set; }

            public string RegistrantName { get; set; }
            public string TitleState { get; set; }
            public string OwnerLessorName { get; set; }
            public DateTime ExpiresDate { get; set; }
            public DateTime EfectiveDate { get; set; }
            public DateTime IssueDate { get; set; }
            public int PurchasePrice { get; set; }
            public DateTime PurchaseDate { get; set; }

            public string Status { get; set; } // Active, Standby, Sold, Deleted.

        }
    }
}
