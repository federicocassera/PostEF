using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostEF
{
    internal class PostContext : DbContext
    {
        //per segnalare ogni modifica al database --> tramite line console
        //creare migrazione con add-migration 'nome'
        //e poi fare update database
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().Property(p => p.Note).HasColumnName("appunto");
        }
        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
