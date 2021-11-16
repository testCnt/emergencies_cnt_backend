using System;
using General.Maps;
using Microsoft.EntityFrameworkCore;
using General.Models;

namespace General.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<EmergencyPatient> EmergencyPatient { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new EmergencyPatientMap(modelBuilder.Entity<EmergencyPatient>());
        }
    }
}
