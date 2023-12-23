using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleService.Domain.Entities;
using SampleService.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleService.Persistence.Contexts
{
    public class SampleServiceDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public SampleServiceDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Personel> Personels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
