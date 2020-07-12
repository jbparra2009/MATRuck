﻿using MATruck.Database;
using MATruck.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MATruck.Application.CreateDispatches
{
    public class CreateDispatch
    {
        private readonly ApplicationDbContext _ctx;

        public CreateDispatch(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Do(DispatchViewModel vm)
        {
            _ctx.Dispatches.Add(new Dispatch
            {
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                Description = vm.Description,
                Email = vm.Email,
                Phone1 = vm.Phone1,
                Phone2 = vm.Phone2,
                Rate = vm.Rate,
                Address1 = vm.Address1,
                Address2 = vm.Address2,
                City = vm.City,
                State = vm.State,
                ZipCode = vm.ZipCode,
                SS = vm.SS,
                CorpName = vm.CorpName,
                EIN = vm.EIN,
                Status = vm.Status,
            });

            await _ctx.SaveChangesAsync();
        }
 
    }
    public class DispatchViewModel
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
        public string CorpName { get; set; }
        public string EIN { get; set; }

        public string Status { get; set; } // Active, Standby, Deleted.

    }
}
