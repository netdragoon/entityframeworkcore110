using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClsAppEntityFrameworkCore.Models
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Phone> Phone { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string strConn = "Server=.\\SQLExpress;Database=Db;User Id=sa;Password=senha;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(strConn, c =>
            {                  
            });

            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            ClientMap.Create(modelBuilder.Entity<Client>());
            PhoneMap.Create(modelBuilder.Entity<Phone>());
            
            //base.OnModelCreating(modelBuilder);
        }
    }
}
