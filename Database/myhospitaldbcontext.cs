using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalCRUD
{
     class myhospitaldbcontext :DbContext
    {
        
        public myhospitaldbcontext(): base("ForConnectingstrings")
        {


        }

        public DbSet<Patientdata> patienttable { get; set; }
        public DbSet<Appuser> Appusertable { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appuser>()
                .HasIndex(p => p.Username)
                .IsUnique();
        }
    }
}
