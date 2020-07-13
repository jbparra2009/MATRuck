using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.Threading.Tasks;

namespace MATruck.Application.CreateTrailers
{
    public class CreateTrailer
    {
        private readonly ApplicationDbContext _ctx;

        public CreateTrailer(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Do(TrailerViewModel vm)
        {
            _ctx.Trailers.Add(new Trailer
            {
                VIN = vm.VIN,
                Year = vm.Year,
                Make = vm.Make,
                Model = vm.Model,
                Class = vm.Class,
                BodyType = vm.BodyType,
                Lenght = vm.Lenght,
                Description = vm.Description,
                TrailerPlate = vm.TrailerPlate,
                TrailerNumber = vm.TrailerNumber,
                TitleNumber = vm.TitleNumber,
                TitleState = vm.TitleState,
                TitleIssueDate = vm.TitleIssueDate,
                PurchasePrice = vm.PurchasePrice,
                PurchaseDate = vm.PurchaseDate,
                Status = vm.Status,
            });

            await _ctx.SaveChangesAsync();
        }

        public class TrailerViewModel
        {
            public int Id { get; set; }
            public string VIN { get; set; }
            public string Year { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Class { get; set; }
            public string BodyType { get; set; }
            public string Lenght { get; set; }
            public string Description { get; set; }

            public string TrailerPlate { get; set; }
            public string TrailerNumber { get; set; }

            public string TitleNumber { get; set; }
            public string TitleState { get; set; }
            public DateTime TitleIssueDate { get; set; }
            public int PurchasePrice { get; set; }
            public DateTime PurchaseDate { get; set; }

            public string Status { get; set; } // Active, Standby, Deleted.

        }
    }
}
