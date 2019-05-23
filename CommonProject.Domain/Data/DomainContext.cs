using CommonProject.Domain.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProject.Domain.Data
{
    public partial class DomainContext : DbContext
    {
        
        public DomainContext() : base("name=TestConnect")
        {
             Database.SetInitializer<DomainContext>(null);
        }

        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().ToTable("Tests");
            base.OnModelCreating(modelBuilder);
        }
    }
}
