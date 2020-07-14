using MATruck.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATruck.Application.TrailersAdmin
{
    public class GetTrailers
    {
        private readonly ApplicationDbContext _ctx;

        public GetTrailers(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<TrailerViewModel> Do() =>
            _ctx.Trailers.ToList().Select(x => new TrailerViewModel
            {
                Id = x.Id,
                VIN = x.VIN,
                Year = x.Year,
                Make = x.Make,
                Model = x.Model,
                Class = x.Class,
                BodyType = x.BodyType,
                Lenght = x.Lenght,
                Description = x.Description,
                TrailerPlate = x.TrailerPlate,
                TrailerNumber = x.TrailerNumber,
                TitleNumber = x.TitleNumber,
                TitleState = x.TitleState,
                TitleIssueDate = x.TitleIssueDate,
                PurchasePrice = x.PurchasePrice,
                PurchaseDate = x.PurchaseDate,
                Status = x.Status,
            });

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
