using Gringots.Models;
using GringotsDbContext.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GringotsDbContext
{
    public class GringotsContext : DbContext
    {
        public GringotsContext() : base("GringotsDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GringotsContext, Configuration>());
        }

        public DbSet<WizzardDeposit> WizardDeposits { get; set; }
    }
}
