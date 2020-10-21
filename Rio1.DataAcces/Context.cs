using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.DataAcces
{
    public class Context : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.Proveedores>().ToTable("Proveedores");
            modelBuilder.Entity<Model.Productos>().ToTable("Productos");
            modelBuilder.Entity<Model.AspNetUsers>().ToTable("AspNetUsers");
            modelBuilder.Entity<Model.AspNetRole>().ToTable("AspNetRoles");



        }
        public DbSet<Model.Proveedores> Proveedores { get; set; }
        public DbSet<Model.Productos> Productos { get; set; }
        public DbSet<Model.AspNetUsers> AspNetUsers { get; set; }
        public DbSet<Model.AspNetRole> AspNetRoles{ get; set; }



    }
}
