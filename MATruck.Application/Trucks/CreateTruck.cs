using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.Threading.Tasks;

namespace MATruck.Application.CreateTrucks
{
    public class CreateTruck
    {
        private readonly ApplicationDbContext _ctx;

        public CreateTruck(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Do(TruckViewModel vm)
        {
            _ctx.Trucks.Add(new Truck
            {
                VIN = vm.VIN,
                Year = vm.Year,
                Make = vm.Make,
                Type = vm.Type,
                Class = vm.Class,
                BodyType = vm.BodyType,
                Lenght = vm.Lenght,
                Description = vm.Description,
                Plate = vm.Plate,
                UnitNumber = vm.UnitNumber,
                RegistrantName = vm.RegistrantName,
                TitleState = vm.TitleState,
                OwnerLessorName = vm.OwnerLessorName,
                ExpiresDate = vm.ExpiresDate,
                EfectiveDate = vm.EfectiveDate,
                IssueDate = vm.IssueDate,
                PurchasePrice = vm.PurchasePrice,
                PurchaseDate = vm.PurchaseDate,
                Status = vm.Status,
            });

            await _ctx.SaveChangesAsync();
        }
    }

    public class TruckViewModel
    {
        public string VIN { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string BodyType { get; set; }
        public string Lenght { get; set; }
        public string Description { get; set; }

        public string Plate { get; set; }
        public string UnitNumber { get; set; }

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
