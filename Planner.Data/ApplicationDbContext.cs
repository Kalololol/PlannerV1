using Microsoft.EntityFrameworkCore;
using Planner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        DbSet<Contract> Contracts { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Ward> Wards { get; set; }
        DbSet<Indisposition> Indispositions { get; set; }
        DbSet<PlanDay> PlanDays { get; set; }
        DbSet<PlanMonth> PlanMonths { get; set; }
        DbSet<Request> Requests { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        }
}
