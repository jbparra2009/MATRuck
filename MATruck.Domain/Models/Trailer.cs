using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATruck.Domain.Models
{
    public class Trailer
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

        public string Plate { get; set; }
        public string TitleNumber { get; set; }
        public string TitleState { get; set; }
        public DateTime TitleIssueDate { get; set; }
        public int PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }

        public string Status { get; set; } // Active, Standby, Deleted.

    }
}
