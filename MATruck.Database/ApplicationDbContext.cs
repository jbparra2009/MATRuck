using MATruck.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MATruck.Database
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Dispatch> Dispatches { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<Truck> Trucks { get; set; }
    }
}
