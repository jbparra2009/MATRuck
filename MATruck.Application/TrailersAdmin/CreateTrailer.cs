using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.Threading.Tasks;

namespace MATruck.Application.TrailersAdmin
{
    public class CreateTrailer
    {
        private readonly ApplicationDbContext _ctx;

        public CreateTrailer(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Response> Do(Request request)
        {
            var trailer = new Trailer
            {
                VIN = request.VIN,
                Year = request.Year,
                Make = request.Make,
                Model = request.Model,
                Class = request.Class,
                BodyType = request.BodyType,
                Lenght = request.Lenght,
                Description = request.Description,
                TrailerPlate = request.TrailerPlate,
                TrailerNumber = request.TrailerNumber,
                TitleNumber = request.TitleNumber,
                TitleState = request.TitleState,
                TitleIssueDate = request.TitleIssueDate,
                PurchasePrice = request.PurchasePrice,
                PurchaseDate = request.PurchaseDate,
                Status = request.Status,
            };

            _ctx.Trailers.Add(trailer);

            await _ctx.SaveChangesAsync();

            return new Response
            {
                Id = trailer.Id,
                VIN = trailer.VIN,
                Year = trailer.Year,
                Make = trailer.Make,
                Model = trailer.Model,
                Class = trailer.Class,
                BodyType = trailer.BodyType,
                Lenght = trailer.Lenght,
                Description = trailer.Description,
                TrailerPlate = trailer.TrailerPlate,
                TrailerNumber = trailer.TrailerNumber,
                TitleNumber = trailer.TitleNumber,
                TitleState = trailer.TitleState,
                TitleIssueDate = trailer.TitleIssueDate,
                PurchasePrice = trailer.PurchasePrice,
                PurchaseDate = trailer.PurchaseDate,
                Status = trailer.Status,
            };
        }

        public class Request
        {
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

        public class Response
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
