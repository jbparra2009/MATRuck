using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MATruck.Application.CreateFactories
{
    public class CreateFactory
    {
        private readonly ApplicationDbContext _ctx;

        public CreateFactory(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Do(FactoryViewModel vm)
        {
            _ctx.Factories.Add(new Factory
            {
                Name = vm.Name,
                Description = vm.Description,
                Email = vm.Email,
                Phone1 = vm.Phone1,
                Phone2 = vm.Phone2,
                Address1 = vm.Address1,
                Address2 = vm.Address2,
                City = vm.City,
                State = vm.State,
                ZipCode = vm.ZipCode,
                Created = vm.Created,
                Status = vm.Status,
            });

            await _ctx.SaveChangesAsync();
        }
    }

    public class FactoryViewModel
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
